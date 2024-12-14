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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            buttonOK_KDD = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            //
            // pictureBox1
            //
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 413);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            //
            // textBox1
            //
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(-1, -8);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(380, 77);
            textBox1.TabIndex = 1;
            textBox1.Text = "Работу выполнила студентка 1-го курса, группы АСОиУБ-24-1, Конева Дарья Денисовна.";
            //
            // buttonOK_KDD
            //
            buttonOK_KDD.Location = new Point(326, 384);
            buttonOK_KDD.Name = "buttonOK_KDD";
            buttonOK_KDD.Size = new Size(75, 23);
            buttonOK_KDD.TabIndex = 2;
            buttonOK_KDD.Text = "Ok";
            buttonOK_KDD.UseVisualStyleBackColor = true;
            buttonOK_KDD.Click += buttonOK_KDD_Click;
            //
            // FormAboutMe
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 413);
            Controls.Add(buttonOK_KDD);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
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

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button buttonOK_KDD;
    }
}
