namespace IA2_CALCULATOR_srfn
{
    partial class distance_convertor_Form
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
            this.TBmilesTOkms = new System.Windows.Forms.TextBox();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.lblMilles = new System.Windows.Forms.Label();
            this.lblKms = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBmilesTOkms
            // 
            this.TBmilesTOkms.Location = new System.Drawing.Point(166, 111);
            this.TBmilesTOkms.Name = "TBmilesTOkms";
            this.TBmilesTOkms.Size = new System.Drawing.Size(100, 20);
            this.TBmilesTOkms.TabIndex = 3;
            this.TBmilesTOkms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(166, 178);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(75, 23);
            this.btnReset2.TabIndex = 4;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.BtnReset2_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(166, 217);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(75, 23);
            this.btnClose2.TabIndex = 5;
            this.btnClose2.Text = "Close";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.BtnClose2_Click);
            // 
            // lblMilles
            // 
            this.lblMilles.AutoSize = true;
            this.lblMilles.Location = new System.Drawing.Point(59, 183);
            this.lblMilles.Name = "lblMilles";
            this.lblMilles.Size = new System.Drawing.Size(49, 13);
            this.lblMilles.TabIndex = 6;
            this.lblMilles.Text = "miles (mi)";
            // 
            // lblKms
            // 
            this.lblKms.AutoSize = true;
            this.lblKms.Location = new System.Drawing.Point(298, 183);
            this.lblKms.Name = "lblKms";
            this.lblKms.Size = new System.Drawing.Size(76, 13);
            this.lblKms.TabIndex = 7;
            this.lblKms.Text = "Kilometers(Km)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IA2_CALCULATOR_srfn.Properties.Resources.one_kilometer;
            this.pictureBox3.Location = new System.Drawing.Point(290, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IA2_CALCULATOR_srfn.Properties.Resources._1_MILE_srfn;
            this.pictureBox1.Location = new System.Drawing.Point(29, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // distance_convertor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 279);
            this.Controls.Add(this.lblKms);
            this.Controls.Add(this.lblMilles);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.btnReset2);
            this.Controls.Add(this.TBmilesTOkms);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "distance_convertor_Form";
            this.Text = "distance_convertor_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TBmilesTOkms;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Label lblMilles;
        private System.Windows.Forms.Label lblKms;
    }
}