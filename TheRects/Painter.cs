using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace TheRects
{
    class Painter
    {
        public Painter(PictureBox picCanvas)
        {

            this.picCanvas = picCanvas;
            picCanvas.MouseDown += PicCanvas_MouseDown;
            picCanvas.Resize += PicCanvas_Resize;
            picCanvas.MouseMove += PicCanvas_MouseMove;
            picCanvas.Paint += PicCanvas_Paint;

            Reset();
        }
        PictureBox picCanvas;

        public event EventHandler Click;
        protected void OnClick() => Click?.Invoke(this, EventArgs.Empty);

        double lambda;
        //lambda is a value in the range [0,1]
        public double Lambda { get { return lambda; } }


        bool isLoading;
        public void BeginLoadData()
        {
            isLoading = true;
        }
        public void EndLoadData()
        {
            isLoading = false;
        }
        public Scenario Scenario { get; set; }

        public void Repaint() => picCanvas.Invalidate();

        private Point _trackerPoint;

        #region Picture Canvas events

        private void PicCanvas_Resize(object sender, EventArgs e) => Repaint();

        private void PicCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            _trackerPoint = e.Location;
            Repaint();
        }

        private void PicCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            //lambda is calculated
            if (e.Button == MouseButtons.Left)
            {
                OnClick();
                //MessageBox.Show($"{lambda:P1}");
            }
        }


        private struct DrawingInfo
        {
            public int w, h; //client width and client height
            public int mL, mR; //margin left and margin right
            public int d; //connector distance

            public int wMax; //maximum left/right image width
            public int xLineLeft, xLineRight; //connector left and right x coordinates
            public int yLine; //the y of the connector

            public int trackerHeight, xTrackerCenter, yTrackerCenter; //tracker size and coordinates

            public DrawingInfo(float dpi, int w, int h, int trackerX)
            {
                //horizontal margins (fixed)2
                mL = mR = 40;

                this.w = w; this.h = h;
                yLine = h / 2;
                d = (int)(11.5 / 2.54 * dpi);
                if (d % 2 == 1) d++; //increase by 1 pixel to be symmetrical

                wMax = (w - d - mL - mR) / 2;

                xLineLeft = mL + wMax;
                xLineRight = xLineLeft + d;

                //tracker height (1.0 mm)
                trackerHeight = (int)(0.1 * dpi / 2.54d);
                if (trackerHeight % 2 == 1) trackerHeight++; //increase by 1 pixel to be symmetrical
                xTrackerCenter = trackerX;
                if (xTrackerCenter < xLineLeft) xTrackerCenter = xLineLeft;
                else if (xTrackerCenter > xLineRight) xTrackerCenter = xLineRight;
                yTrackerCenter = yLine;
            }

            public void DrawConnector(Graphics g) =>
                g.DrawLine(Pens.Black, xLineLeft, h / 2, xLineRight, h / 2);

            public void DrawTracker(Graphics g) =>
                g.DrawLine(Pens.Black, xTrackerCenter, h / 2 - trackerHeight / 2, xTrackerCenter, h / 2 + trackerHeight / 2);

            public void DrawLeftImage(Graphics g, Image image, int width, int height)
            {
                //width<=wMax
                Rectangle r = new Rectangle(mL + wMax - width, h / 2 - height / 2, width, height);
                g.DrawImage(image, r);
            }

            public void DrawRightImage(Graphics g, Image image, int width, int height)
            {
                //width<=wMax
                Rectangle r = new Rectangle(w - mR - wMax, h / 2 - height / 2, width, height);
                g.DrawImage(image, r);
            }
            public void DrawLeftRectangle(Graphics g, int width, int height)
            {
                //width<=wMax
                Rectangle r = new Rectangle(mL + wMax - width, h / 2 - height / 2, width, height);
                g.FillRectangle(Brushes.Black, r);
            }

            public void DrawRightRectangle(Graphics g, int width, int height)
            {
                //width<=wMax
                Rectangle r = new Rectangle(w - mR - wMax, h / 2 - height / 2, width, height);
                g.FillRectangle(Brushes.Black, r);
            }

            public void DrawLeftEllipse(Graphics g, int width, int height)
            {
                //width<=wMax
                Rectangle r = new Rectangle(mL + wMax - width, h / 2 - height / 2, width, height);
                g.FillEllipse(Brushes.Black, r);
            }

            public void DrawRightEllipse(Graphics g, int width, int height)
            {
                //width<=wMax
                Rectangle r = new Rectangle(w - mR - wMax, h / 2 - height / 2, width, height);
                g.FillEllipse(Brushes.Black, r);
            }

            public double GetLambda()
            {
                return 100.0 * (xTrackerCenter - xLineLeft) / (xLineRight-xLineLeft);
            }
        }

        private void DrawSmallLargeImageScenario(Graphics g, Image image, Point trackerPoint, bool isLeftSmall = true)
        {
            int w = picCanvas.ClientRectangle.Width;
            int h = picCanvas.ClientRectangle.Height;

            //double a = 0.5;
            //double p = (1 + a) / (1 - a);
            double widthScaleFactorRelativeToSmall = 2; //p
            double widthScaleFactorRelativeToNormal = (widthScaleFactorRelativeToSmall - 1.0) / (widthScaleFactorRelativeToSmall + 1.0); //a

            //connector length (11.5 cm)
            int d = (int)(11.5 / 2.54 * g.DpiX);
            if (d % 2 == 1) d++; //increase by 1 pixel to be symmetrical
            //tracker height (1.0 mm)
            int trackerHeight = (int)(0.1 * g.DpiX / 2.54d);
            if (trackerHeight % 2 == 1) trackerHeight++; //increase by 1 pixel to be symmetrical
            //horizontal margins (fixed)
            const int marginLeft = 50, marginRight = marginLeft;

            //rectangle dimensions
            int wSmall = (int)((w - marginLeft - marginRight - d) / (widthScaleFactorRelativeToSmall + 1.0));//w - marginRight - xLineRight;
            int wLarge = (int)(wSmall * widthScaleFactorRelativeToSmall);// (w - marginLeft - marginRight - d) / 2;
            int hSmall = (int)(1.0 / (1.0 - widthScaleFactorRelativeToNormal) * image.Height / image.Width * wSmall);
            //int wLarge = 2 * wSmall; //wLarge = 1.5 * wNormal, wSmall = 0.5 * wNormal
            //all object are of the same height
            int hLarge = hSmall;

            //connector dimensions
            int xLineLeft = marginLeft + wSmall; //(w - d) / 2;
            int xLineRight = w - marginRight - wLarge;  //(w + d) / 2;
            int yLine = h / 2;

            //tracker dimensions
            int xTrackerCenter = _trackerPoint.X;
            if (xTrackerCenter < xLineLeft) xTrackerCenter = xLineLeft;
            else if (xTrackerCenter > xLineRight) xTrackerCenter = xLineRight;
            int yTrackerCenter = yLine;
            //update lambda (only if tracking is enabled)
            if (trackingEnabled)
                lambda = 100.0 * (xTrackerCenter - xLineLeft) / (xLineRight - xLineLeft);

            int wLeft, hLeft, wRight, hRight;
            if (isLeftSmall)
            {
                wLeft = wSmall; hLeft = hSmall;
                wRight = wLarge; hRight = hLarge;
            }
            else
            {
                wLeft = wLarge; hLeft = hLarge;
                wRight = wSmall; hRight = hSmall;
            }
            Rectangle leftRectangle = new Rectangle(marginLeft, h / 2 - hLeft / 2, wLeft, hLeft),
                rightRectangle = new Rectangle(w - marginRight - wLarge, h / 2 - hRight / 2, wRight, hRight);

            //draw everything now
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            //left image 
            g.DrawImage(image, leftRectangle);
            //right image
            g.DrawImage(image, rightRectangle);
            //connector line
            g.DrawLine(Pens.Black, xLineLeft, h / 2, xLineRight, h / 2);

            if (trackingEnabled)
                //tracker
                g.DrawLine(Pens.Black, xTrackerCenter, h / 2 - trackerHeight / 2, xTrackerCenter, h / 2 + trackerHeight / 2);
        }


        //private void DrawTwoImagesScenario(Graphics g, Image leftImage, Image rightImage, Point trackerPoint)
        //{
        //    int w = picCanvas.ClientRectangle.Width;
        //    int h = picCanvas.ClientRectangle.Height;

        //    //double a = 0.5;
        //    //double p = (1 + a) / (1 - a);
        //    double widthScaleFactorRelativeToSmall = 1;
        //    double widthScaleFactorRelativeToNormal = (widthScaleFactorRelativeToSmall - 1.0) / (widthScaleFactorRelativeToSmall + 1.0);

        //    //connector length (11.5 cm)
        //    int d = (int)(11.5 / 2.54 * g.DpiX);
        //    if (d % 2 == 1) d++; //increase by 1 pixel to be symmetrical
        //    //tracker height (1.0 mm)
        //    int trackerHeight = (int)(0.1 * g.DpiX / 2.54d);
        //    if (trackerHeight % 2 == 1) trackerHeight++; //increase by 1 pixel to be symmetrical
        //    //horizontal margins (fixed)
        //    const int marginLeft = 50, marginRight = marginLeft;

        //    //rectangle dimensions
        //    int wSmall = (int)((w - marginLeft - marginRight - d) / (widthScaleFactorRelativeToSmall + 1.0));//w - marginRight - xLineRight;
        //    int wLarge = (int)(wSmall * widthScaleFactorRelativeToSmall);// (w - marginLeft - marginRight - d) / 2;
        //    int hSmall = (int)(1.0 / (1.0 - widthScaleFactorRelativeToNormal) * image.Height / image.Width * wSmall);
        //    //int wLarge = 2 * wSmall; //wLarge = 1.5 * wNormal, wSmall = 0.5 * wNormal
        //    //all object are of the same height
        //    int hLarge = hSmall;

        //    //connector dimensions
        //    int xLineLeft = marginLeft + wSmall; //(w - d) / 2;
        //    int xLineRight = w - marginRight - wLarge;  //(w + d) / 2;
        //    int yLine = h / 2;

        //    //tracker dimensions
        //    int xTrackerCenter = _trackerPoint.X;
        //    if (xTrackerCenter < xLineLeft) xTrackerCenter = xLineLeft;
        //    else if (xTrackerCenter > xLineRight) xTrackerCenter = xLineRight;
        //    int yTrackerCenter = yLine;
        //    //update lambda (only if tracking is enabled)
        //    if (trackingEnabled)
        //        lambda = 100.0 * (xTrackerCenter - xLineLeft) / (xLineRight - xLineLeft);

        //    int wLeft, hLeft, wRight, hRight;
        //    if (isLeftSmall)
        //    {
        //        wLeft = wSmall; hLeft = hSmall;
        //        wRight = wLarge; hRight = hLarge;
        //    }
        //    else
        //    {
        //        wLeft = wLarge; hLeft = hLarge;
        //        wRight = wSmall; hRight = hSmall;
        //    }
        //    Rectangle leftRectangle = new Rectangle(marginLeft, h / 2 - hLeft / 2, wLeft, hLeft),
        //        rightRectangle = new Rectangle(w - marginRight - wLarge, h / 2 - hRight / 2, wRight, hRight);

        //    //draw everything now
        //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        //    g.Clear(Color.White);

        //    //left image 
        //    g.DrawImage(image, leftRectangle);
        //    //right image
        //    g.DrawImage(image, rightRectangle);
        //    //connector line
        //    g.DrawLine(Pens.Black, xLineLeft, h / 2, xLineRight, h / 2);

        //    if (trackingEnabled)
        //        //tracker
        //        g.DrawLine(Pens.Black, xTrackerCenter, h / 2 - trackerHeight / 2, xTrackerCenter, h / 2 + trackerHeight / 2);
        //}


        bool trackingEnabled = true;
        public void EnableTracking()
        {
            trackingEnabled = true;
            picCanvas.Invalidate();
        }

        public void DisableTracking()
        {
            trackingEnabled = false;
            picCanvas.Invalidate();
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (Scenario == null || isLoading) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            //DrawSmallLargeImageScenario(e.Graphics, Scenario.Image, _trackerPoint, true);
            DrawingInfo info = new DrawingInfo(g.DpiX, picCanvas.ClientRectangle.Width, picCanvas.ClientRectangle.Height, _trackerPoint.X);
            info.DrawConnector(g);

            switch (Scenario.ScenarioType)
            {
                //case ScenarioType.Empty: //just proceed
                case ScenarioType.Image:
                    {
                        double p = 2.0, a = (p - 1.0) / (p + 1.0);
                        int wSmall = info.wMax / 2;
                        int hSmall = (int)(1.0 / (1.0 - a) * Scenario.Image.Height / Scenario.Image.Width * wSmall);
                        info.DrawLeftImage(g, Scenario.Image, wSmall, hSmall);
                        info.DrawRightImage(g, Scenario.Image, info.wMax, hSmall);
                        break;
                    }
                case ScenarioType.ImageOpposite: //user-images scenario
                    {
                        double p = 2.0, a = (p - 1.0) / (p + 1.0);
                        int wSmall = info.wMax / 2;
                        int hSmall = (int)(1.0 / (1.0 - a) * Scenario.Image.Height / Scenario.Image.Width * wSmall);
                        info.DrawLeftImage(g, Scenario.Image, info.wMax, hSmall);
                        info.DrawRightImage(g, Scenario.Image, wSmall, hSmall);
                        break;
                    }
                case ScenarioType.Image2: //two different images scenario
                    {
                        int hLeft = (int)((double)Scenario.Image.Height / Scenario.Image.Width * info.wMax);
                        int hRight = (int)((double)Scenario.Image2.Height / Scenario.Image2.Width * info.wMax);
                        info.DrawLeftImage(g, Scenario.Image, info.wMax, hLeft);
                        info.DrawRightImage(g, Scenario.Image2, info.wMax, hRight);
                        break;
                    }
                case ScenarioType.SameSquares:
                    info.DrawLeftRectangle(g, info.wMax / 2, info.wMax / 2);
                    info.DrawRightRectangle(g, info.wMax / 2, info.wMax / 2);
                    break;
                case ScenarioType.SquaresSmallLarge:
                    info.DrawLeftRectangle(g, info.wMax / 2, info.wMax / 2);
                    info.DrawRightRectangle(g, info.wMax, info.wMax);
                    break;
                case ScenarioType.SquaresLargeSmall:
                    info.DrawLeftRectangle(g, info.wMax, info.wMax);
                    info.DrawRightRectangle(g, info.wMax / 2, info.wMax / 2);
                    break;
                case ScenarioType.SameCircles:
                    info.DrawLeftEllipse(g, info.wMax / 2, info.wMax / 2);
                    info.DrawRightEllipse(g, info.wMax / 2, info.wMax / 2);
                    break;
                case ScenarioType.CirclesSmallLarge:
                    info.DrawLeftEllipse(g, info.wMax / 2, info.wMax / 2);
                    info.DrawRightEllipse(g, info.wMax, info.wMax);
                    break;
                case ScenarioType.CirclesLargeSmall:
                    info.DrawLeftEllipse(g, info.wMax, info.wMax);
                    info.DrawRightEllipse(g, info.wMax / 2, info.wMax / 2);
                    break;
                case ScenarioType.SameThinRectangle:
                    info.DrawLeftRectangle(g, info.wMax / 4, info.wMax);
                    info.DrawRightRectangle(g, info.wMax / 4, info.wMax);
                    break;

                case ScenarioType.SameThickRectangle:
                    info.DrawLeftRectangle(g, info.wMax / 2, info.wMax);
                    info.DrawRightRectangle(g, info.wMax / 2, info.wMax);
                    break;
                case ScenarioType.ThinThickRectangle:
                    info.DrawLeftRectangle(g, info.wMax / 4, info.wMax);
                    info.DrawRightRectangle(g, info.wMax / 2, info.wMax);
                    break;
                case ScenarioType.ThickThinRectangle:
                    info.DrawLeftRectangle(g, info.wMax / 2, info.wMax);
                    info.DrawRightRectangle(g, info.wMax / 4, info.wMax);
                    break;

            }

            if (trackingEnabled)
            {
                lambda = info.GetLambda();
                info.DrawTracker(g);
            }

        }

        #endregion

        #region Main properties

        public void Reset()
        {
            distance = 50;
            rectRatio = 50;
            scaleRatio = 50;
            orientation = 0;
            trackerSize = 4;
            colorLeft = Color.White;
            colorRight = Color.DarkOrange;
            colorLine = Color.Black;
            lineWidth = 1;

            picCanvas.Invalidate();
        }

        int distance;
        public int Distance
        {
            get { return distance; }
            set
            {
                distance = value;
                if (!isLoading) Repaint();
            }
        }


        int rectRatio;
        public int RectRatio
        {
            get { return rectRatio; }
            set
            {
                rectRatio = value;
                if (!isLoading) Repaint();
            }
        }

        int scaleRatio;
        public int ScaleRatio
        {
            get { return scaleRatio; }
            set
            {
                scaleRatio = value;
                if (!isLoading) Repaint();
            }
        }

        int orientation;
        public int Orientation
        {
            get { return orientation; }
            set
            {
                orientation = value;
                if (!isLoading) Repaint();
            }
        }

        int trackerSize;
        public int TrackerSize
        {
            get { return trackerSize; }
            set
            {
                trackerSize = value;
                if (!isLoading) Repaint();
            }
        }


        Color colorLeft;
        public Color ColorLeft
        {
            get { return colorLeft; }
            set
            {
                colorLeft = value;
                if (!isLoading) Repaint();
            }
        }

        Color colorRight;
        public Color ColorRight
        {
            get { return colorRight; }
            set
            {
                colorRight = value;
                if (!isLoading) Repaint();
            }
        }

        Color colorLine;
        public Color ColorLine
        {
            get { return colorLine; }
            set
            {
                colorLine = value;
                if (!isLoading) Repaint();
            }
        }

        int lineWidth;
        public int LineWidth
        {
            get { return lineWidth; }
            set
            {
                lineWidth = value;
                if (!isLoading) Repaint();
            }
        }
        #endregion

    }
}
