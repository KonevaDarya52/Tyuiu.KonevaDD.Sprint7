namespace Tyuiu.KonevaDD.Sprint7.Project.V10
{
    partial class FormAboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutMe));
            textBoxAboutMe = new TextBox();
            buttonOK_KDD = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxAboutMe
            // 
            textBoxAboutMe.Dock = DockStyle.Fill;
            textBoxAboutMe.Font = new Font("Segoe UI", 12F);
            textBoxAboutMe.Location = new Point(0, 0);
            textBoxAboutMe.Margin = new Padding(3, 4, 3, 4);
            textBoxAboutMe.Multiline = true;
            textBoxAboutMe.Name = "textBoxAboutMe";
            textBoxAboutMe.ReadOnly = true;
            textBoxAboutMe.Size = new Size(633, 696);
            textBoxAboutMe.TabIndex = 1;
            textBoxAboutMe.Text = resources.GetString("textBoxAboutMe.Text");
            // 
            // buttonOK_KDD
            // 
            buttonOK_KDD.Location = new Point(523, 663);
            buttonOK_KDD.Margin = new Padding(3, 4, 3, 4);
            buttonOK_KDD.Name = "buttonOK_KDD";
            buttonOK_KDD.Size = new Size(86, 31);
            buttonOK_KDD.TabIndex = 2;
            buttonOK_KDD.Text = "Ok";
            buttonOK_KDD.UseVisualStyleBackColor = true;
            buttonOK_KDD.Click += buttonOK_KDD_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, 220);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 282);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormAboutMe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 696);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOK_KDD);
            Controls.Add(textBoxAboutMe);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAboutMe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAboutMe";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxAboutMe;
        private Button buttonOK_KDD;
        private PictureBox pictureBox1;
    }
}
