namespace FloorCost
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
            this.calc = new System.Windows.Forms.Button();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.matBox = new System.Windows.Forms.TextBox();
            this.totalCost = new System.Windows.Forms.Label();
            this.cleanCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.Location = new System.Drawing.Point(281, 103);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(138, 35);
            this.calc.TabIndex = 0;
            this.calc.Text = "Calculate Total";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(12, 56);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 1;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(12, 118);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 20);
            this.lengthBox.TabIndex = 2;
            // 
            // matBox
            // 
            this.matBox.Location = new System.Drawing.Point(12, 179);
            this.matBox.Name = "matBox";
            this.matBox.Size = new System.Drawing.Size(100, 20);
            this.matBox.TabIndex = 3;
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.Location = new System.Drawing.Point(276, 173);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(110, 25);
            this.totalCost.TabIndex = 4;
            this.totalCost.Text = "Total Cost";
            // 
            // cleanCheckBox
            // 
            this.cleanCheckBox.AutoSize = true;
            this.cleanCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanCheckBox.Location = new System.Drawing.Point(282, 49);
            this.cleanCheckBox.Name = "cleanCheckBox";
            this.cleanCheckBox.Size = new System.Drawing.Size(116, 29);
            this.cleanCheckBox.TabIndex = 5;
            this.cleanCheckBox.Text = "Cleaning";
            this.cleanCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Flooring Cost Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Floor Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Floor Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Material (Carpet or \'Other\')";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 241);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cleanCheckBox);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.matBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox matBox;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.CheckBox cleanCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

