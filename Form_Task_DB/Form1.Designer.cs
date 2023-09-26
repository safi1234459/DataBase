namespace Form_Task_DB
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
            txtID = new TextBox();
            txtCompanyName = new TextBox();
            txtMessageText = new TextBox();
            btnUpdate = new Button();
            btnCount = new Button();
            btnView = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 30);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 69);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Company Name:";
            // 
            // txtID
            // 
            txtID.Location = new Point(170, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 27);
            txtID.TabIndex = 9;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(170, 69);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(125, 27);
            txtCompanyName.TabIndex = 3;
            txtCompanyName.TextChanged += textBox2_TextChanged;
            // 
            // txtMessageText
            // 
            txtMessageText.Enabled = false;
            txtMessageText.Location = new Point(399, 12);
            txtMessageText.Multiline = true;
            txtMessageText.Name = "txtMessageText";
            txtMessageText.Size = new Size(353, 96);
            txtMessageText.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(110, 111);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Database";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(525, 128);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(157, 29);
            btnCount.TabIndex = 6;
            btnCount.Text = "Count Records";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(363, 402);
            btnView.Name = "btnView";
            btnView.Size = new Size(124, 29);
            btnView.TabIndex = 7;
            btnView.Text = "View Database";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(707, 188);
            dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnView);
            Controls.Add(btnCount);
            Controls.Add(btnUpdate);
            Controls.Add(txtMessageText);
            Controls.Add(txtCompanyName);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtCompanyName;
        private TextBox txtMessageText;
        private Button btnUpdate;
        private Button btnCount;
        private Button btnView;
        private DataGridView dataGridView1;
    }
}