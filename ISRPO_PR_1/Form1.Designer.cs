namespace ISRPO_PR_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb00 = new System.Windows.Forms.TextBox();
            this.tb01 = new System.Windows.Forms.TextBox();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.bIncColumn = new System.Windows.Forms.Button();
            this.bDegColumn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bDegRow = new System.Windows.Forms.Button();
            this.bIncRow = new System.Windows.Forms.Button();
            this.bResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNegativeColumns = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb00
            // 
            this.tb00.Location = new System.Drawing.Point(211, 87);
            this.tb00.Name = "tb00";
            this.tb00.Size = new System.Drawing.Size(40, 20);
            this.tb00.TabIndex = 0;
            this.tb00.TabStop = false;
            // 
            // tb01
            // 
            this.tb01.Location = new System.Drawing.Point(211, 113);
            this.tb01.Name = "tb01";
            this.tb01.Size = new System.Drawing.Size(40, 20);
            this.tb01.TabIndex = 1;
            this.tb01.TabStop = false;
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(257, 87);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(40, 20);
            this.tb10.TabIndex = 2;
            this.tb10.TabStop = false;
            // 
            // tb11
            // 
            this.tb11.Location = new System.Drawing.Point(257, 113);
            this.tb11.Name = "tb11";
            this.tb11.Size = new System.Drawing.Size(40, 20);
            this.tb11.TabIndex = 3;
            this.tb11.TabStop = false;
            // 
            // bIncColumn
            // 
            this.bIncColumn.Location = new System.Drawing.Point(69, 29);
            this.bIncColumn.Name = "bIncColumn";
            this.bIncColumn.Size = new System.Drawing.Size(40, 20);
            this.bIncColumn.TabIndex = 4;
            this.bIncColumn.TabStop = false;
            this.bIncColumn.Text = "+";
            this.bIncColumn.UseVisualStyleBackColor = true;
            this.bIncColumn.Click += new System.EventHandler(this.bIncColumn_Click);
            // 
            // bDegColumn
            // 
            this.bDegColumn.Enabled = false;
            this.bDegColumn.Location = new System.Drawing.Point(23, 29);
            this.bDegColumn.Name = "bDegColumn";
            this.bDegColumn.Size = new System.Drawing.Size(40, 20);
            this.bDegColumn.TabIndex = 6;
            this.bDegColumn.TabStop = false;
            this.bDegColumn.Text = "-";
            this.bDegColumn.UseVisualStyleBackColor = true;
            this.bDegColumn.Click += new System.EventHandler(this.bDegColumn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество столбцов";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bIncColumn);
            this.groupBox1.Controls.Add(this.bDegColumn);
            this.groupBox1.Location = new System.Drawing.Point(212, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 55);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bDegRow);
            this.groupBox2.Controls.Add(this.bIncRow);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 78);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество столбцов";
            // 
            // bDegRow
            // 
            this.bDegRow.Enabled = false;
            this.bDegRow.Location = new System.Drawing.Point(128, 18);
            this.bDegRow.Name = "bDegRow";
            this.bDegRow.Size = new System.Drawing.Size(40, 20);
            this.bDegRow.TabIndex = 4;
            this.bDegRow.TabStop = false;
            this.bDegRow.Text = "-";
            this.bDegRow.UseVisualStyleBackColor = true;
            this.bDegRow.Click += new System.EventHandler(this.bDegRow_Click);
            // 
            // bIncRow
            // 
            this.bIncRow.Location = new System.Drawing.Point(128, 44);
            this.bIncRow.Name = "bIncRow";
            this.bIncRow.Size = new System.Drawing.Size(40, 20);
            this.bIncRow.TabIndex = 6;
            this.bIncRow.TabStop = false;
            this.bIncRow.Text = "+";
            this.bIncRow.UseVisualStyleBackColor = true;
            this.bIncRow.Click += new System.EventHandler(this.bIncRow_Click);
            // 
            // bResult
            // 
            this.bResult.Location = new System.Drawing.Point(12, 190);
            this.bResult.Name = "bResult";
            this.bResult.Size = new System.Drawing.Size(178, 23);
            this.bResult.TabIndex = 11;
            this.bResult.TabStop = false;
            this.bResult.Text = "Найти отрицательные столбцы";
            this.bResult.UseVisualStyleBackColor = true;
            this.bResult.Click += new System.EventHandler(this.bResult_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(226, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "1";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(272, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "2";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(-171, -90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 156);
            this.label5.TabIndex = 14;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(346, -90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(379, 156);
            this.label7.TabIndex = 16;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(34, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Отрицательные столбцы:";
            // 
            // labelNegativeColumns
            // 
            this.labelNegativeColumns.AutoSize = true;
            this.labelNegativeColumns.Location = new System.Drawing.Point(34, 273);
            this.labelNegativeColumns.Name = "labelNegativeColumns";
            this.labelNegativeColumns.Size = new System.Drawing.Size(13, 13);
            this.labelNegativeColumns.TabIndex = 18;
            this.labelNegativeColumns.Text = "1";
            this.labelNegativeColumns.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(77, -142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(379, 156);
            this.label8.TabIndex = 19;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(640, 337);
            this.Controls.Add(this.labelNegativeColumns);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb11);
            this.Controls.Add(this.tb10);
            this.Controls.Add(this.tb01);
            this.Controls.Add(this.tb00);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.MaximumSize = new System.Drawing.Size(656, 376);
            this.MinimumSize = new System.Drawing.Size(364, 376);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Поиск отрицательных столбцов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb00;
        private System.Windows.Forms.TextBox tb01;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.Button bIncColumn;
        private System.Windows.Forms.Button bDegColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDegRow;
        private System.Windows.Forms.Button bIncRow;
        private System.Windows.Forms.Button bResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNegativeColumns;
        private System.Windows.Forms.Label label8;
    }
}

