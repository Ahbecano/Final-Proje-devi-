
namespace OgrenciNotFormUygulamasi
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
            label1 = new Label();
            label2 = new Label();
            lblStudentName = new Label();
            label3 = new Label();
            txtStudentName = new TextBox();
            lblScore = new Label();
            txtScore = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 8);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // lblStudentName
            // 
            lblStudentName.Location = new Point(20, 20);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(100, 25);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Öğrenci Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 51);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(130, 20);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(180, 27);
            txtStudentName.TabIndex = 3;
            txtStudentName.TextChanged += textBox1_TextChanged;
            // 
            // lblScore
            // 
            lblScore.Location = new Point(20, 60);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(100, 25);
            lblScore.TabIndex = 2;
            lblScore.Text = "Not:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(130, 60);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(180, 27);
            txtScore.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(340, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(340, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 30);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 110);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(560, 250);
            dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 373);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtScore);
            Controls.Add(txtStudentName);
            Controls.Add(label3);
            Controls.Add(lblScore);
            Controls.Add(lblStudentName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Not Takip Sistemi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label lblStudentName;
        private Label label3;
        private TextBox txtStudentName;
        private Label lblScore;
        private TextBox txtScore;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}
