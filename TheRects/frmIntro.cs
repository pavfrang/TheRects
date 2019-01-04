using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using static TheRects.PathExtensions;

namespace TheRects
{
    public partial class frmIntro : DevExpress.XtraEditors.XtraForm
    {
        public frmIntro()
        {
            InitializeComponent();
        }

        Player currentPlayer;

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            using (frmUser frm = new frmUser())
            {
                if (currentPlayer != null)
                    frm.Player = currentPlayer;
                DialogResult result = frm.ShowDialog();


                if (result == DialogResult.OK)
                {
                    currentPlayer = frm.Player;
                    lblUser.Text = currentPlayer.Name;
                    currentPlayer.InitializeGradeInfos(Program.Game.Scenarios, RandomizeType.RandomizeScenarios);

                    btnCreateUser.Text = "Επεξεργασία χρήστη...";
                }
            }

        }

        frmQuiz quiz = new frmQuiz();

        private void btnStart_Click(object sender, EventArgs e)
        {
            //reset quiz infos for the player
            if (currentPlayer == null)
            {
                MessageBox.Show("Δημιουργήστε χρήστη πρώτα!", "Δοκιμασία Επιλογής", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            quiz.Player = currentPlayer;
            // quiz.Player.InitializeGradeInfos(game.Scenarios, RandomizeType.None);
            DialogResult result = quiz.ShowDialog();

            if (result == DialogResult.OK)
            {
                currentPlayer.SaveGradesToFile(CombineWithExecutableDirectory("results.txt"), true);

                btnCreateUser.Enabled = btnStart.Enabled = false;
            }


        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
