namespace Assignemtn_Question_2_B1
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
            btnAddStudents = new Button();
            btnShowStudents = new Button();
            btnExit = new Button();
            heading = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddStudents
            // 
            btnAddStudents.Cursor = Cursors.Hand;
            btnAddStudents.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddStudents.Location = new Point(315, 195);
            btnAddStudents.Name = "btnAddStudents";
            btnAddStudents.Size = new Size(256, 88);
            btnAddStudents.TabIndex = 0;
            btnAddStudents.Text = "Add Students ";
            btnAddStudents.UseVisualStyleBackColor = true;
            btnAddStudents.Click += button1_Click;
            // 
            // btnShowStudents
            // 
            btnShowStudents.Cursor = Cursors.Hand;
            btnShowStudents.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowStudents.Location = new Point(315, 344);
            btnShowStudents.Name = "btnShowStudents";
            btnShowStudents.Size = new Size(256, 88);
            btnShowStudents.TabIndex = 1;
            btnShowStudents.Text = "Show Students";
            btnShowStudents.UseVisualStyleBackColor = true;
            btnShowStudents.Click += btnShowStudents_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(315, 488);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(256, 88);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            heading.ForeColor = SystemColors.ActiveCaptionText;
            heading.Location = new Point(219, 30);
            heading.Name = "heading";
            heading.Size = new Size(464, 46);
            heading.TabIndex = 3;
            heading.Text = "Students Data Management";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(747, 651);
            Controls.Add(pictureBox1);
            Controls.Add(heading);
            Controls.Add(btnExit);
            Controls.Add(btnShowStudents);
            Controls.Add(btnAddStudents);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddStudents;
        private Button btnShowStudents;
        private Button btnExit;
        private Label heading;
        private PictureBox pictureBox1;
    }
}