using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace TheRects
{
    public partial class frmCalibrator : Form
    {
        public frmCalibrator()
        {
            InitializeComponent();


            AddHandlers();

            painter = new Painter(picCanvas);
            painter.BeginLoadData();
            trackBarScaleRatio.EditValue = painter.ScaleRatio;
            trackBarDistance.EditValue = painter.Distance;
            trackBarOrientation.EditValue = painter.Orientation;
            trackBarRectRatio.EditValue = painter.RectRatio;
            trackBarTrackerSize.EditValue = painter.TrackerSize;

            colorLeft.Color = painter.ColorLeft;
            colorRight.Color = painter.ColorRight;
            colorLine.Color = painter.ColorLine;
            spinEditLineWidth.EditValue = painter.LineWidth;
            painter.EndLoadData();

            painter.Click += Painter_Click;

            game = Program.Game;
            cboInterior.Properties.Items.AddRange(game.Scenarios);
            cboInterior.SelectedIndexChanged += CboInterior_SelectedIndexChanged;
            cboInterior.SelectedIndex = 0;
        }

        private void AddHandlers()
        {
            trackBarScaleRatio.EditValueChanged += (o, e) =>
            {
                txtScaleRatio.EditValue = trackBarScaleRatio.EditValue;
                if (painter == null) return;
                painter.ScaleRatio = (int)trackBarScaleRatio.EditValue;
            };

            trackBarDistance.EditValueChanged += (o, e) =>
            {
                txtDistance.EditValue = trackBarDistance.EditValue;
                if (painter == null) return;
                painter.Distance = (int)trackBarDistance.EditValue;
            };

            trackBarRectRatio.EditValueChanged += (o, e) =>
            {
                txtRectRatio.EditValue = trackBarRectRatio.EditValue;
                if (painter == null) return;
                painter.RectRatio = (int)trackBarRectRatio.EditValue;
            };

            trackBarOrientation.EditValueChanged += (o, e) =>
            {
                txtAngle.EditValue = trackBarOrientation.EditValue;
                if (painter == null) return;
                painter.Orientation = (int)trackBarOrientation.EditValue;
            };

            trackBarTrackerSize.EditValueChanged += (o, e) =>
            {
                txtTrackerSize.EditValue = trackBarTrackerSize.EditValue;
                if (painter == null) return;
                painter.TrackerSize = (int)trackBarTrackerSize.EditValue;
            };

            colorLeft.EditValueChanged += (o, e) =>
            {
                if (painter == null) return;
                painter.ColorLeft = colorLeft.Color;
            };
            colorRight.EditValueChanged += (o, e) =>
            {
                if (painter == null) return;
                painter.ColorRight = colorRight.Color;
            };
            colorLine.EditValueChanged += (o, e) =>
            {
                if (painter == null) return;
                painter.ColorLine = colorLine.Color;
            };
            spinEditLineWidth.EditValueChanged += (o, e) =>
            {
                if (painter == null) return;
                painter.LineWidth = Convert.ToInt32(spinEditLineWidth.EditValue);
            };
        }

        Game game;

        private void Painter_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{painter.Lambda:P1}");
        }

        private void CboInterior_SelectedIndexChanged(object sender, EventArgs e)
        {
            painter.Scenario = (Scenario)cboInterior.EditValue;
            picCanvas.Invalidate();
        }

        Painter painter;

        private void btnReset_Click(object sender, EventArgs e)
        {
            trackBarDistance.Value = 50;
            trackBarRectRatio.Value = 50;
            trackBarScaleRatio.Value = 50;
            trackBarOrientation.Value = 0;
            trackBarTrackerSize.Value = 0;

            cboInterior.SelectedIndex = 0;

            colorLeft.Color = Color.White;
            colorRight.Color = Color.DarkOrange;
            colorLine.Color = Color.Black;
            spinEditLineWidth.Value = 1;
        }
    }
}
