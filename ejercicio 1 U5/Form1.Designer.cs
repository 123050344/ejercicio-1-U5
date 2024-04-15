namespace ejercicio_1_U5
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
            btnsave = new Button();
            txtname = new TextBox();
            label1 = new Label();
            txtsalary = new TextBox();
            txthours = new TextBox();
            btncalculate = new Button();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            txttotal = new TextBox();
            txtnames = new TextBox();
            SuspendLayout();
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Brown;
            btnsave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsave.Location = new Point(578, 31);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(167, 78);
            btnsave.TabIndex = 0;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // txtname
            // 
            txtname.BackColor = Color.FromArgb(192, 0, 0);
            txtname.Location = new Point(233, 38);
            txtname.Name = "txtname";
            txtname.Size = new Size(291, 23);
            txtname.TabIndex = 1;
            txtname.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 31);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txtsalary
            // 
            txtsalary.BackColor = Color.FromArgb(192, 0, 0);
            txtsalary.Location = new Point(233, 86);
            txtsalary.Name = "txtsalary";
            txtsalary.Size = new Size(291, 23);
            txtsalary.TabIndex = 3;
            // 
            // txthours
            // 
            txthours.BackColor = Color.FromArgb(192, 0, 0);
            txthours.Location = new Point(233, 140);
            txthours.Name = "txthours";
            txthours.Size = new Size(291, 23);
            txthours.TabIndex = 4;
            // 
            // btncalculate
            // 
            btncalculate.BackColor = Color.Brown;
            btncalculate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncalculate.Location = new Point(578, 140);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(167, 79);
            btncalculate.TabIndex = 5;
            btncalculate.Text = "Calculate";
            btncalculate.UseVisualStyleBackColor = false;
            btncalculate.Click += btncalculate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 79);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 6;
            label2.Text = "Salary/hour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(39, 133);
            label6.Name = "label6";
            label6.Size = new Size(152, 30);
            label6.TabIndex = 10;
            label6.Text = "Hours worked";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(67, 196);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 11;
            label3.Text = "Total salary";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(233, 196);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(291, 23);
            txttotal.TabIndex = 12;
            // 
            // txtnames
            // 
            txtnames.Location = new Point(233, 276);
            txtnames.Name = "txtnames";
            txtnames.Size = new Size(291, 23);
            txtnames.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtnames);
            Controls.Add(txttotal);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(btncalculate);
            Controls.Add(txthours);
            Controls.Add(txtsalary);
            Controls.Add(label1);
            Controls.Add(txtname);
            Controls.Add(btnsave);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsave;
        private TextBox txtname;
        private Label label1;
        private TextBox txtsalary;
        private TextBox txthours;
        private Button btncalculate;
        private Label label2;
        private Label label6;
        private Label label3;
        private TextBox txttotal;
        private TextBox txtnames;
    }
}