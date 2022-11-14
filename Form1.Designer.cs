
namespace Transport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.btnCallTable = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlSetTable = new System.Windows.Forms.Panel();
            this.tbConsume = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbProduce = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearTable = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.btnSetSize = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlSetTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(951, 92);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGetResult
            // 
            this.btnGetResult.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGetResult.Location = new System.Drawing.Point(325, 863);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(313, 110);
            this.btnGetResult.TabIndex = 2;
            this.btnGetResult.Text = "Результат";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click_1);
            // 
            // btnCallTable
            // 
            this.btnCallTable.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCallTable.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCallTable.Location = new System.Drawing.Point(6, 863);
            this.btnCallTable.Name = "btnCallTable";
            this.btnCallTable.Size = new System.Drawing.Size(313, 110);
            this.btnCallTable.TabIndex = 3;
            this.btnCallTable.Text = "Таблица";
            this.btnCallTable.UseVisualStyleBackColor = true;
            this.btnCallTable.Click += new System.EventHandler(this.btnCallTable_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Location = new System.Drawing.Point(644, 863);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(313, 110);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlSetTable
            // 
            this.pnlSetTable.Controls.Add(this.tbConsume);
            this.pnlSetTable.Controls.Add(this.panel2);
            this.pnlSetTable.Controls.Add(this.tbProduce);
            this.pnlSetTable.Controls.Add(this.panel1);
            this.pnlSetTable.Controls.Add(this.clearTable);
            this.pnlSetTable.Controls.Add(this.goBack);
            this.pnlSetTable.Controls.Add(this.btnSetSize);
            this.pnlSetTable.Controls.Add(this.label4);
            this.pnlSetTable.Controls.Add(this.label3);
            this.pnlSetTable.Controls.Add(this.label2);
            this.pnlSetTable.Controls.Add(this.label1);
            this.pnlSetTable.Location = new System.Drawing.Point(0, 0);
            this.pnlSetTable.Name = "pnlSetTable";
            this.pnlSetTable.Size = new System.Drawing.Size(963, 980);
            this.pnlSetTable.TabIndex = 0;
            // 
            // tbConsume
            // 
            this.tbConsume.BackColor = System.Drawing.SystemColors.Control;
            this.tbConsume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConsume.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbConsume.Location = new System.Drawing.Point(651, 297);
            this.tbConsume.MaxLength = 2;
            this.tbConsume.Name = "tbConsume";
            this.tbConsume.Size = new System.Drawing.Size(262, 48);
            this.tbConsume.TabIndex = 10;
            this.tbConsume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbConsume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbConsume_KeyDown);
            this.tbConsume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbConsume_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(651, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 3);
            this.panel2.TabIndex = 9;
            // 
            // tbProduce
            // 
            this.tbProduce.BackColor = System.Drawing.SystemColors.Control;
            this.tbProduce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProduce.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbProduce.Location = new System.Drawing.Point(651, 229);
            this.tbProduce.MaxLength = 2;
            this.tbProduce.Name = "tbProduce";
            this.tbProduce.Size = new System.Drawing.Size(262, 48);
            this.tbProduce.TabIndex = 8;
            this.tbProduce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbProduce.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProduce_KeyDown);
            this.tbProduce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProduce_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(651, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 3);
            this.panel1.TabIndex = 7;
            // 
            // clearTable
            // 
            this.clearTable.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearTable.ForeColor = System.Drawing.SystemColors.Highlight;
            this.clearTable.Location = new System.Drawing.Point(6, 747);
            this.clearTable.Name = "clearTable";
            this.clearTable.Size = new System.Drawing.Size(951, 110);
            this.clearTable.TabIndex = 6;
            this.clearTable.Text = "Очистить значения таблиц";
            this.clearTable.UseVisualStyleBackColor = true;
            this.clearTable.Click += new System.EventHandler(this.clearTable_Click);
            // 
            // goBack
            // 
            this.goBack.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.goBack.Location = new System.Drawing.Point(6, 863);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(951, 110);
            this.goBack.TabIndex = 5;
            this.goBack.Text = "Вернуться к таблице";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // btnSetSize
            // 
            this.btnSetSize.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSetSize.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSetSize.Location = new System.Drawing.Point(6, 373);
            this.btnSetSize.Name = "btnSetSize";
            this.btnSetSize.Size = new System.Drawing.Size(951, 110);
            this.btnSetSize.TabIndex = 4;
            this.btnSetSize.Text = "Задать размерность";
            this.btnSetSize.UseVisualStyleBackColor = true;
            this.btnSetSize.Click += new System.EventHandler(this.btnSetSize_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(320, 680);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Или вы можете:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(200, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 96);
            this.label3.TabIndex = 2;
            this.label3.Text = "Чтобы задать размер\r\nвведите следующие данные:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество пунктов потребления:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество пунктов производства:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(951, 92);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 459);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(951, 398);
            this.dataGridView3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Chocolate;
            this.label5.Location = new System.Drawing.Point(284, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(416, 48);
            this.label5.TabIndex = 7;
            this.label5.Text = "Пункты потребления";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Chocolate;
            this.label6.Location = new System.Drawing.Point(277, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(431, 48);
            this.label6.TabIndex = 8;
            this.label6.Text = "Пункты производства";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(215, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(554, 48);
            this.label7.TabIndex = 9;
            this.label7.Text = "Затраты на транспортировку";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 978);
            this.Controls.Add(this.pnlSetTable);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCallTable);
            this.Controls.Add(this.btnGetResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(985, 1034);
            this.MinimumSize = new System.Drawing.Size(985, 1018);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Т-задача. Метод минимальной стоимости";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlSetTable.ResumeLayout(false);
            this.pnlSetTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.Button btnCallTable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlSetTable;
        private System.Windows.Forms.Button clearTable;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button btnSetSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConsume;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbProduce;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

