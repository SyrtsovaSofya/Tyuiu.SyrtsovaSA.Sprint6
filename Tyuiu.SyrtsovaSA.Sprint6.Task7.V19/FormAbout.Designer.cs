namespace Tyuiu.SyrtsovaSA.Sprint6.Task7.V19
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo_SSA = new Label();
            buttonOK_SSA = new Button();
            pictureBoxPhoto_SSA = new PictureBox();
            labelAbout_SSA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_SSA).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_SSA
            // 
            labelInfo_SSA.AutoSize = true;
            labelInfo_SSA.Location = new Point(160, 20);
            labelInfo_SSA.Margin = new Padding(4, 0, 4, 0);
            labelInfo_SSA.Name = "labelInfo_SSA";
            labelInfo_SSA.Size = new Size(0, 20);
            labelInfo_SSA.TabIndex = 1;
            // 
            // buttonOK_SSA
            // 
            buttonOK_SSA.Location = new Point(368, 323);
            buttonOK_SSA.Margin = new Padding(4, 5, 4, 5);
            buttonOK_SSA.Name = "buttonOK_SSA";
            buttonOK_SSA.Size = new Size(100, 35);
            buttonOK_SSA.TabIndex = 2;
            buttonOK_SSA.Text = "Ок";
            buttonOK_SSA.UseVisualStyleBackColor = true;
            buttonOK_SSA.Click += buttonOK_SSA_Click;
            // 
            // pictureBoxPhoto_SSA
            // 
            pictureBoxPhoto_SSA.Image = (Image)resources.GetObject("pictureBoxPhoto_SSA.Image");
            pictureBoxPhoto_SSA.Location = new Point(17, 20);
            pictureBoxPhoto_SSA.Margin = new Padding(4, 5, 4, 5);
            pictureBoxPhoto_SSA.Name = "pictureBoxPhoto_SSA";
            pictureBoxPhoto_SSA.Size = new Size(255, 346);
            pictureBoxPhoto_SSA.TabIndex = 0;
            pictureBoxPhoto_SSA.TabStop = false;
            // 
            // labelAbout_SSA
            // 
            labelAbout_SSA.AutoSize = true;
            labelAbout_SSA.Location = new Point(272, 20);
            labelAbout_SSA.Name = "labelAbout_SSA";
            labelAbout_SSA.Size = new Size(196, 40);
            labelAbout_SSA.TabIndex = 3;
            labelAbout_SSA.Text = "Разработчик: Сырцова С.А.\r\nгруппа ИИПб-24-1\r\n";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 372);
            Controls.Add(labelAbout_SSA);
            Controls.Add(buttonOK_SSA);
            Controls.Add(labelInfo_SSA);
            Controls.Add(pictureBoxPhoto_SSA);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_SSA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhoto_SSA;
        private System.Windows.Forms.Label labelInfo_SSA;
        private System.Windows.Forms.Button buttonOK_SSA;
        private Label labelAbout_SSA;
    }
}