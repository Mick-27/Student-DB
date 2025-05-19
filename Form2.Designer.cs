namespace Assignemtn_Question_2_B1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtSponName = new TextBox();
            txtDOB = new TextBox();
            txtJoinDate = new TextBox();
            txtNationality = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblDOB = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(306, 74);
            label1.Name = "label1";
            label1.Size = new Size(182, 38);
            label1.TabIndex = 0;
            label1.Text = "Add Student";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 196);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(408, 188);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(408, 253);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 3;
            // 
            // txtSponName
            // 
            txtSponName.Location = new Point(408, 318);
            txtSponName.Name = "txtSponName";
            txtSponName.Size = new Size(125, 27);
            txtSponName.TabIndex = 4;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(408, 383);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(125, 27);
            txtDOB.TabIndex = 5;
            // 
            // txtJoinDate
            // 
            txtJoinDate.Location = new Point(408, 449);
            txtJoinDate.Name = "txtJoinDate";
            txtJoinDate.Size = new Size(125, 27);
            txtJoinDate.TabIndex = 6;
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(408, 512);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(125, 27);
            txtNationality.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(258, 188);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 8;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(258, 260);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 9;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(258, 318);
            label4.Name = "label4";
            label4.Size = new Size(147, 22);
            label4.TabIndex = 10;
            label4.Text = "Sponsor Name:";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDOB.Location = new Point(258, 383);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(129, 22);
            lblDOB.TabIndex = 11;
            lblDOB.Text = "Date of Birth:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(258, 452);
            label6.Name = "label6";
            label6.Size = new Size(101, 22);
            label6.TabIndex = 12;
            label6.Text = "Join Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(258, 519);
            label7.Name = "label7";
            label7.Size = new Size(111, 22);
            label7.TabIndex = 13;
            label7.Text = "Nationality:";
            label7.Click += label7_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(259, 592);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 45);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(408, 592);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 46);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(748, 668);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblDOB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNationality);
            Controls.Add(txtJoinDate);
            Controls.Add(txtDOB);
            Controls.Add(txtSponName);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtSponName;
        private TextBox txtDOB;
        private TextBox txtJoinDate;
        private TextBox txtNationality;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblDOB;
        private Label label6;
        private Label label7;
        private Button btnSave;
        private Button btnCancel;
        private OpenFileDialog openFileDialog1;
    }
}