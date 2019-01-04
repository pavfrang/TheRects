namespace TheRects
{
    partial class frmIntro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntro));
            this.btnCreateUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblUser = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnEnd = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateUser.ImageOptions.Image")));
            this.btnCreateUser.Location = new System.Drawing.Point(15, 36);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(171, 47);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Δημιουργία χρήστη...";
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnStart
            // 
            this.btnStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.ImageOptions.Image")));
            this.btnStart.Location = new System.Drawing.Point(14, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(172, 47);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Εκκίνηση δοκιμασίας...";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblUser);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnCreateUser);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(434, 105);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Χρήστης";
            // 
            // lblUser
            // 
            this.lblUser.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblUser.Appearance.Options.UseFont = true;
            this.lblUser.Location = new System.Drawing.Point(208, 64);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(95, 19);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "<ΚΑΝΕΝΑΣ>";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(208, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Τρέχων χρήστης:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnEnd);
            this.groupControl2.Controls.Add(this.btnStart);
            this.groupControl2.Location = new System.Drawing.Point(12, 133);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(434, 103);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Δοκιμασία";
            // 
            // btnEnd
            // 
            this.btnEnd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEnd.ImageOptions.Image")));
            this.btnEnd.Location = new System.Drawing.Point(208, 37);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(172, 47);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "Τερματισμός δοκιμασίας";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // frmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.Name = "frmIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Δοκιμασία Επιλογής";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCreateUser;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblUser;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnEnd;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}