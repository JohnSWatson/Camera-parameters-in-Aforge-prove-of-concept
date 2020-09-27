namespace Camera_parameters_in_Aforge__prove_of_concept
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxCameras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxCapturedImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapturedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCameras
            // 
            this.comboBoxCameras.FormattingEnabled = true;
            this.comboBoxCameras.Location = new System.Drawing.Point(13, 36);
            this.comboBoxCameras.Name = "comboBoxCameras";
            this.comboBoxCameras.Size = new System.Drawing.Size(408, 28);
            this.comboBoxCameras.TabIndex = 0;
            this.comboBoxCameras.Text = "No camera selected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Camera";
            // 
            // pictureBoxCapturedImage
            // 
            this.pictureBoxCapturedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCapturedImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCapturedImage.Image")));
            this.pictureBoxCapturedImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCapturedImage.InitialImage")));
            this.pictureBoxCapturedImage.Location = new System.Drawing.Point(13, 71);
            this.pictureBoxCapturedImage.Name = "pictureBoxCapturedImage";
            this.pictureBoxCapturedImage.Size = new System.Drawing.Size(408, 275);
            this.pictureBoxCapturedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCapturedImage.TabIndex = 2;
            this.pictureBoxCapturedImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 561);
            this.Controls.Add(this.pictureBoxCapturedImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCameras);
            this.Name = "Form1";
            this.Text = "No camera selected";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapturedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCameras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCapturedImage;
    }
}

