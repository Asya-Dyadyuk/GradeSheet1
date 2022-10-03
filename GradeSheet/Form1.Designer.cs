namespace GradeSheet
{
    partial class GradeSheetForm
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.GradeTB = new System.Windows.Forms.TextBox();
            this.NameCourse = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCredits = new System.Windows.Forms.Label();
            this.CreditsTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highest = new System.Windows.Forms.TextBox();
            this.lowest = new System.Windows.Forms.TextBox();
            this.av = new System.Windows.Forms.TextBox();
            this.ave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(143, 30);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(149, 26);
            this.NameTB.TabIndex = 0;
            // 
            // GradeTB
            // 
            this.GradeTB.Location = new System.Drawing.Point(375, 30);
            this.GradeTB.Name = "GradeTB";
            this.GradeTB.Size = new System.Drawing.Size(149, 26);
            this.GradeTB.TabIndex = 1;
            // 
            // NameCourse
            // 
            this.NameCourse.AutoSize = true;
            this.NameCourse.Location = new System.Drawing.Point(23, 36);
            this.NameCourse.Name = "NameCourse";
            this.NameCourse.Size = new System.Drawing.Size(114, 20);
            this.NameCourse.TabIndex = 2;
            this.NameCourse.Text = " Course Name:";
            this.NameCourse.Click += new System.EventHandler(this.NameCourse_Click);
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(311, 36);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(58, 20);
            this.Grade.TabIndex = 3;
            this.Grade.Text = "Grade:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(27, 147);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(115, 38);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(450, 147);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(115, 38);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(242, 147);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(115, 38);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(660, 147);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(115, 38);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Highest Grade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lowest Grade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Average Grade:";
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Location = new System.Drawing.Point(556, 39);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(63, 20);
            this.labelCredits.TabIndex = 12;
            this.labelCredits.Text = "Credits:";
            // 
            // CreditsTB
            // 
            this.CreditsTB.Location = new System.Drawing.Point(625, 30);
            this.CreditsTB.Name = "CreditsTB";
            this.CreditsTB.Size = new System.Drawing.Size(149, 26);
            this.CreditsTB.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Credits});
            this.dataGridView1.Location = new System.Drawing.Point(27, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(747, 223);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Course Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Grade";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Credits
            // 
            this.Credits.HeaderText = "Credits";
            this.Credits.MinimumWidth = 8;
            this.Credits.Name = "Credits";
            this.Credits.ReadOnly = true;
            this.Credits.Width = 150;
            // 
            // highest
            // 
            this.highest.Location = new System.Drawing.Point(143, 456);
            this.highest.Name = "highest";
            this.highest.Size = new System.Drawing.Size(90, 26);
            this.highest.TabIndex = 15;
            // 
            // lowest
            // 
            this.lowest.Location = new System.Drawing.Point(387, 456);
            this.lowest.Name = "lowest";
            this.lowest.Size = new System.Drawing.Size(90, 26);
            this.lowest.TabIndex = 16;
            // 
            // av
            // 
            this.av.Location = new System.Drawing.Point(0, 0);
            this.av.Name = "av";
            this.av.Size = new System.Drawing.Size(100, 26);
            this.av.TabIndex = 0;
            // 
            // ave
            // 
            this.ave.Location = new System.Drawing.Point(625, 459);
            this.ave.Name = "ave";
            this.ave.Size = new System.Drawing.Size(90, 26);
            this.ave.TabIndex = 17;
            // 
            // GradeSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 350);
            this.Controls.Add(this.ave);
            this.Controls.Add(this.lowest);
            this.Controls.Add(this.highest);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CreditsTB);
            this.Controls.Add(this.labelCredits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.NameCourse);
            this.Controls.Add(this.GradeTB);
            this.Controls.Add(this.NameTB);
            this.Name = "GradeSheetForm";
            this.Text = "Grade Sheet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox GradeTB;
        private System.Windows.Forms.Label NameCourse;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.TextBox CreditsTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credits;
        private System.Windows.Forms.TextBox highest;
        private System.Windows.Forms.TextBox lowest;
        private System.Windows.Forms.TextBox average;
        private System.Windows.Forms.TextBox av;
        private System.Windows.Forms.TextBox ave;
    }
}

