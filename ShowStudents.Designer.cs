namespace assignment_trial
{
    partial class ShowStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStudents));
            label1 = new Label();
            lblName = new Label();
            lblLastName = new Label();
            lblSponName = new Label();
            lblDOB = new Label();
            lblJoinDate = new Label();
            lblNationality = new Label();
            txtName = new TextBox();
            pictureBox1 = new PictureBox();
            btnPrev = new Button();
            btnNext = new Button();
            btnBack = new Button();
            btnDlt = new Button();
            txtLastName = new TextBox();
            txtSponName = new TextBox();
            txtDOB = new TextBox();
            txtJDate = new TextBox();
            txtNat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(258, 38);
            label1.Name = "label1";
            label1.Size = new Size(404, 41);
            label1.TabIndex = 0;
            label1.Text = "List of Registered Students ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(207, 201);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(207, 252);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(113, 28);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblSponName
            // 
            lblSponName.AutoSize = true;
            lblSponName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSponName.Location = new Point(207, 305);
            lblSponName.Name = "lblSponName";
            lblSponName.Size = new Size(152, 28);
            lblSponName.TabIndex = 3;
            lblSponName.Text = "Sponsor Name:";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDOB.Location = new Point(207, 357);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(134, 28);
            lblDOB.TabIndex = 4;
            lblDOB.Text = "Date of Birth:";
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblJoinDate.Location = new Point(207, 415);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(102, 28);
            lblJoinDate.TabIndex = 5;
            lblJoinDate.Text = "Join Date:";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNationality.Location = new Point(207, 475);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(115, 28);
            lblNationality.TabIndex = 6;
            lblNationality.Text = "Nationality:";
            // 
            // txtName
            // 
            txtName.Location = new Point(370, 201);
            txtName.Name = "txtName";
            txtName.Size = new Size(302, 27);
            txtName.TabIndex = 8;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 192);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(207, 144);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(94, 29);
            btnPrev.TabIndex = 15;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += button1_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(654, 144);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 16;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(240, 542);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(134, 53);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDlt
            // 
            btnDlt.Location = new Point(528, 542);
            btnDlt.Name = "btnDlt";
            btnDlt.Size = new Size(134, 53);
            btnDlt.TabIndex = 18;
            btnDlt.Text = "Delete";
            btnDlt.UseVisualStyleBackColor = true;
            btnDlt.Click += btnDlt_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(370, 252);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(302, 27);
            txtLastName.TabIndex = 19;
            // 
            // txtSponName
            // 
            txtSponName.Location = new Point(370, 305);
            txtSponName.Name = "txtSponName";
            txtSponName.Size = new Size(302, 27);
            txtSponName.TabIndex = 20;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(370, 357);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(302, 27);
            txtDOB.TabIndex = 21;
            // 
            // txtJDate
            // 
            txtJDate.Location = new Point(370, 415);
            txtJDate.Name = "txtJDate";
            txtJDate.Size = new Size(302, 27);
            txtJDate.TabIndex = 22;
            // 
            // txtNat
            // 
            txtNat.Location = new Point(370, 475);
            txtNat.Name = "txtNat";
            txtNat.Size = new Size(302, 27);
            txtNat.TabIndex = 23;
            // 
            // ShowStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(824, 635);
            Controls.Add(txtNat);
            Controls.Add(txtJDate);
            Controls.Add(txtDOB);
            Controls.Add(txtSponName);
            Controls.Add(txtLastName);
            Controls.Add(btnDlt);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(pictureBox1);
            Controls.Add(txtName);
            Controls.Add(lblNationality);
            Controls.Add(lblJoinDate);
            Controls.Add(lblDOB);
            Controls.Add(lblSponName);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "ShowStudents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowStudents";
            Load += ShowStudents_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblLastName;
        private Label lblSponName;
        private Label lblDOB;
        private Label lblJoinDate;
        private Label lblNationality;
        private TextBox txtName;
        private PictureBox pictureBox1;
        private Button btnPrev;
        private Button btnNext;
        private Button btnBack;
        private Button btnDlt;
        private TextBox txtLastName;
        private TextBox txtSponName;
        private TextBox txtDOB;
        private TextBox txtJDate;
        private TextBox txtNat;
    }
}