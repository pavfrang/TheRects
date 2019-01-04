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
    public partial class frmQuiz : Form
    {
        public frmQuiz()
        {
            InitializeComponent();

            painter = new Painter(picCanvas);

            painter.Click += Painter_Click;
        }


        private Painter painter;
        private GradeInfo gradeInfo;
        private int iCurrentInfo;

        private Player currentPlayer;
        public Player Player
        {
            get { return currentPlayer; }
            set
            {
                currentPlayer = value;
                Text = $"Δοκιμασία Επιλογής - [{currentPlayer}]";
                iCurrentInfo = 0;
                btnRepeat.Enabled = btnNext.Enabled = false;
                Proceed();
            }
        }

        public void Proceed()
        {
            gradeInfo = currentPlayer.Grades[iCurrentInfo++];
            //lblId.Text = $"S{gradeInfo.Scenario.ID}/I{gradeInfo.Iteration} ({iCurrentInfo}/{currentPlayer.Grades.Count})";
            lblId.Text = $"{iCurrentInfo}/{currentPlayer.Grades.Count}";
            painter.Scenario = gradeInfo.Scenario;
            painter.Repaint();

            if (iCurrentInfo == currentPlayer.Grades.Count)
            {
                //   MessageBox.Show("Η δοκιμασία τελείωσε! Ευχαριστούμε για τη συμμετοχή!", "Δοκιμασία Επιλογής", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // DialogResult = DialogResult.OK;
                btnNext.Text = "Τερματισμός";
            }

            lblStatus.Text = "Πατήστε στο κέντρο της γραμμής";
            btnRepeat.Enabled = btnNext.Enabled = false;
            painter.EnableTracking();
            picCanvas.Cursor = Cursors.Cross;


            startTime = DateTime.Now;
            iCountdown = 60;
            lblCountdown.Text = "60";
            tmrQuiz.Start();
        }

        DateTime startTime;

        private void Painter_Click(object sender, EventArgs e)
        {
            //assign grade and proceed
            gradeInfo.Value = painter.Lambda;
            gradeInfo.Seconds = (DateTime.Now - startTime).TotalSeconds;

            //var reply = MessageBox.Show("Πάτησε Ναι/Yes για συνέχεια ή Όχι/No για επανάληψη!", "Δοκιμασία Επιλογής", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (reply == DialogResult.Yes)
            //    Proceed();
            lblStatus.Text = "Πατήστε <i>Επόμενο</i> για επόμενη δοκιμασία ή <i>Επανάληψη</i>";
            painter.DisableTracking();
            picCanvas.Cursor = Cursors.Default;

            btnRepeat.Enabled = btnNext.Enabled = true;
        }
        private void btnRepeat_Click(object sender, EventArgs e)
        {
            iCurrentInfo--;
            Proceed();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (iCurrentInfo < currentPlayer.Grades.Count)
                Proceed();
            else //return
            {
                tmrQuiz.Stop();
                DialogResult = DialogResult.OK;
            }
        }

        //private void GoBack()
        //{
        //    gradeInfo = currentPlayer.Grades[--iCurrentInfo];
        //    //lblId.Text = $"S{gradeInfo.Scenario.ID}/I{gradeInfo.Iteration} ({iCurrentInfo}/{currentPlayer.Grades.Count})";
        //    lblId.Text = $"S{iCurrentInfo}/{currentPlayer.Grades.Count}";
        //    painter.Scenario = gradeInfo.Scenario;
        //    painter.Repaint();

        //    //wait for input!
        //    btnNext.Enabled = iCurrentInfo > 0;
        //}

        int iCountdown = 60;
        private void tmrQuiz_Tick(object sender, EventArgs e)
        {
            iCountdown--;
            //force pausing
            if (iCountdown == 0)
            {
                if (btnNext.Enabled)
                    btnNext.PerformClick();
                else
                    btnPause.PerformClick(); //pause
            }
            lblCountdown.Text = iCountdown.ToString();

            if (iCountdown == 0) tmrQuiz.Stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (tmrQuiz.Enabled)
            {
                tmrQuiz.Stop();
                btnPause.Text = "Συνέχιση";
                lblCountdown.Text = "-";
                lblCountdown.ForeColor = Color.Brown;
            }
            else
            {
                iCountdown = 60;
                  btnPause.Text = "Παύση";
              tmrQuiz.Start();
                lblCountdown.Text = "60";
                lblCountdown.ForeColor = Color.Black;
            }


        }
    }
}
