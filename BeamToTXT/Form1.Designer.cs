namespace BeamToTXT
{
    partial class frmBeamToText
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
            this.btnSaveSelected = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.Location = new System.Drawing.Point(10, 12);
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(100, 23);
            this.btnSaveSelected.TabIndex = 0;
            this.btnSaveSelected.Text = "Save Selected";
            this.btnSaveSelected.UseVisualStyleBackColor = true;
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(116, 12);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(105, 23);
            this.btnSaveAll.TabIndex = 1;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmBeamToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 55);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.btnSaveSelected);
            this.Name = "frmBeamToText";
            this.Text = "Beam to Text File";
            this.Load += new System.EventHandler(this.frmBeamToText_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSelected;
        private System.Windows.Forms.Button btnSaveAll;
    }
}

