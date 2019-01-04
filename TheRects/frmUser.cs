using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheRects
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        public frmUser()
        {
            InitializeComponent();

            cboAge.Properties.Items.AddRange(
                Enumerable.Range(17, 99 - 16).ToArray());
            cboAge.SelectedIndex = 0;

            cboHeight.Properties.Items.AddRange(
                Enumerable.Range(140, 210 - 139).Select(i => (i / 100.0).ToString("0.00")).ToArray());
            cboHeight.SelectedIndex = 0;

            cboWeight.Properties.Items.AddRange(
                Enumerable.Range(40, 210 - 39).ToArray());
            cboWeight.SelectedIndex = 0;

            cboHandednessFlanders.Properties.Items.Clear();
            cboHandednessFlanders.Properties.Items.AddRange(Enumerable.Range(-10, 21).ToArray());
            cboHandednessFlanders.EditValue = 0;

            cboHandednessCoren.Properties.Items.Clear();
            cboHandednessCoren.Properties.Items.AddRange(Enumerable.Range(-4, 9).ToArray());
            cboHandednessCoren.EditValue = 0;

            cboFootednessCoren.Properties.Items.Clear();
            cboFootednessCoren.Properties.Items.AddRange(Enumerable.Range(-4, 9).ToArray());
            cboFootednessCoren.EditValue = 0;

            cboEyednessCoren.Properties.Items.Clear();
            cboEyednessCoren.Properties.Items.AddRange(Enumerable.Range(-4, 9).ToArray());
            cboEyednessCoren.EditValue = 0;

            cboEarednessCoren.Properties.Items.Clear();
            cboEarednessCoren.Properties.Items.AddRange(Enumerable.Range(-4, 9).ToArray());
            cboEarednessCoren.EditValue = 0;

            cboBds.Properties.Items.Clear();
            cboBds.Properties.Items.AddRange(Enumerable.Range(1,9).ToArray());
            cboBds.EditValue = 1;

            txtName.Text = "<ΚΑΝΕΝΑΣ>";
        }


        public Player Player
        {
            get
            {
                return new Player()
                {
                    Age = (int)cboAge.EditValue,
                    Gender = cboGender.Text,
                    Name = txtName.Text,
                    Height = cboHeight.Text,
                    Weight = (int)cboWeight.EditValue,

                    //additional values
                    HandednessFlanders = (int)cboHandednessFlanders.EditValue,
                    HandednessCoren = (int)cboHandednessCoren.EditValue,
                    FootednessCoren = (int)cboFootednessCoren.EditValue,
                    EyednessCoren = (int)cboEyednessCoren.EditValue,
                    EarednessCoren = (int)cboEarednessCoren.EditValue,
                    Bds = (int)cboBds.EditValue
                };
            }
            set
            {
                if (value == null)
                {
                    cboAge.SelectedIndex = 0;
                    cboGender.SelectedIndex = 0;
                    cboHeight.SelectedIndex = 0;
                    cboWeight.SelectedIndex = 0;

                    cboHandednessFlanders.EditValue = 0;
                    cboHandednessCoren.EditValue = 0;
                    cboFootednessCoren.EditValue =0;
                    cboEyednessCoren.EditValue = 0;
                    cboEarednessCoren.EditValue = 0;
                    cboBds.EditValue = 1;

                }
                else
                {
                    Text = "Επεξεργασία χρήστη";

                    cboAge.EditValue = value.Age;
                    cboGender.EditValue = value.Gender;
                    txtName.EditValue = value.Name;
                    cboHeight.EditValue = value.Height;
                    cboWeight.EditValue = value.Weight;

                    cboHandednessFlanders.EditValue = value.HandednessFlanders;
                    cboHandednessCoren.EditValue = value.HandednessCoren;
                    cboFootednessCoren.EditValue = value.FootednessCoren;
                    cboEyednessCoren.EditValue = value.EyednessCoren;
                    cboEarednessCoren.EditValue = value.EarednessCoren;
                    cboBds.EditValue = value.Bds;
                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Παρακαλώ βάλε ένα μη κενό όνομα!", "Δοκιμασία Επιλογής", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //this will also hide the form
            DialogResult = DialogResult.OK;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }

        private void groupMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxEdit5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
