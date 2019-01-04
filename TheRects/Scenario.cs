using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TheRects
{
    public enum ScenarioType
    {
        None, Image, Rectangle, Ellipse,
        SameSquares, Image2,
        SameCircles,
        SquaresSmallLarge,
        SquaresLargeSmall,
        Empty,
        CirclesLargeSmall,
        CirclesSmallLarge,
        SameThinRectangle,
        SameThickRectangle,
        ThinThickRectangle,
        ThickThinRectangle,
        ImageOpposite //the same as image but left<->right are interchanged
    }

    public class Scenario
    {
        public Scenario(string name, int id, int iterations, string label, ScenarioType scenarioType)
        {
            ID = id;
            Iterations = iterations;
            ScenarioType = scenarioType;
            Name = name;
            Label = label;
        }
        public Scenario(string name, int id, int iterations, string label, Image image, bool isOpposite) :
            this(name, id, iterations, label,
                isOpposite ? ScenarioType.ImageOpposite : ScenarioType.Image)
        {
            Image = image;
        }
        public Scenario(string name, int id, int iterations, string label, Image image, Image image2) :
            this(name, id, iterations, label, ScenarioType.Image2)
        {
            Image = image;
            Image2 = image2;
        }

        public int ID;
        public string Name;
        public string Label;
        public int Iterations;

        public ScenarioType ScenarioType;

        public Image Image;
        public Image Image2;

        //public void Draw(Graphics g,
        //    Rectangle leftRect, Rectangle rightRect,
        //    Color colorLeft, Color colorRight)
        //{
        //    switch (ScenarioType)
        //    { 
        //        case ScenarioType.Rectangle:
        //            using (SolidBrush bLeft = new SolidBrush(colorLeft))
        //                g.FillRectangle(bLeft, leftRect);
        //            using (SolidBrush bRight = new SolidBrush(colorRight))
        //                g.FillRectangle(bRight, rightRect);
        //            break;
        //        case ScenarioType.Ellipse:
        //            using (SolidBrush bLeft = new SolidBrush(colorLeft))
        //                g.FillEllipse(bLeft, leftRect);
        //            using (SolidBrush bRight = new SolidBrush(colorRight))
        //                g.FillEllipse(bRight, rightRect);
        //            break;
        //        case ScenarioType.Image:
        //            g.DrawImage(Image, leftRect);
        //            g.DrawImage(Image, rightRect);
        //            break;
        //    }
        //}

        /// <summary>
        /// Get all iterations for the specific scenario.
        /// </summary>
        /// <returns></returns>
        public List<GradeInfo> GetDefaultGradeInfos()
        {
            return Enumerable.Range(1, Iterations).Select(i => new GradeInfo() { Iteration = i, Scenario = this, Value = 0.0 }).ToList();
        }

        public override string ToString()
        {
            return Label;
        }

    }
}
