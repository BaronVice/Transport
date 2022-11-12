
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
            this.clearTable = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.btnSetSize = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlSetTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(951, 854);
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
            // clearTable
            // 
            this.clearTable.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearTable.ForeColor = System.Drawing.SystemColors.Highlight;
            this.clearTable.Location = new System.Drawing.Point(6, 747);
            this.clearTable.Name = "clearTable";
            this.clearTable.Size = new System.Drawing.Size(951, 110);
            this.clearTable.TabIndex = 6;
            this.clearTable.Text = "Очистить текущую таблицу";
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(985, 1034);
            this.MinimumSize = new System.Drawing.Size(985, 1018);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Т-задача. Метод минимальной стоимости";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlSetTable.ResumeLayout(false);
            this.pnlSetTable.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

