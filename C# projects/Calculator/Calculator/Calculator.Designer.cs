namespace Calculator
{
    partial class Calculator
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnMInus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn5Divi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOperation = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Azure;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(32, 112);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(54, 48);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button_click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Azure;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(92, 112);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(54, 48);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button_click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Azure;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(152, 112);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(63, 48);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button_click);
            // 
            // txtDis
            // 
            this.txtDis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDis.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDis.Location = new System.Drawing.Point(0, 25);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(251, 23);
            this.txtDis.TabIndex = 1;
            this.txtDis.Text = "0";
            this.txtDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.Azure;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Location = new System.Drawing.Point(221, 112);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(66, 48);
            this.btnMult.TabIndex = 2;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.operator_click);
            // 
            // btnMInus
            // 
            this.btnMInus.BackColor = System.Drawing.Color.Azure;
            this.btnMInus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMInus.Location = new System.Drawing.Point(221, 220);
            this.btnMInus.Name = "btnMInus";
            this.btnMInus.Size = new System.Drawing.Size(66, 52);
            this.btnMInus.TabIndex = 3;
            this.btnMInus.Text = "-";
            this.btnMInus.UseVisualStyleBackColor = false;
            this.btnMInus.Click += new System.EventHandler(this.operator_click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Azure;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Location = new System.Drawing.Point(221, 278);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(66, 45);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Azure;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Location = new System.Drawing.Point(32, 278);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(54, 45);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.button_click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Azure;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(152, 220);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(63, 52);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.button_click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Azure;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(92, 220);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(52, 52);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.button_click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Azure;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(32, 220);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(54, 52);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.button_click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Azure;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(152, 166);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(63, 49);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button_click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Azure;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(92, 166);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(54, 49);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.button_click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Azure;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(32, 166);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(54, 49);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button_click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Azure;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Location = new System.Drawing.Point(152, 278);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(62, 45);
            this.btnEqual.TabIndex = 12;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn5Divi
            // 
            this.btn5Divi.BackColor = System.Drawing.Color.Azure;
            this.btn5Divi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5Divi.Location = new System.Drawing.Point(221, 166);
            this.btn5Divi.Name = "btn5Divi";
            this.btn5Divi.Size = new System.Drawing.Size(66, 49);
            this.btn5Divi.TabIndex = 13;
            this.btn5Divi.Text = "/";
            this.btn5Divi.UseVisualStyleBackColor = false;
            this.btn5Divi.Click += new System.EventHandler(this.operator_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn5Divi);
            this.groupBox1.Controls.Add(this.btnEqual);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Controls.Add(this.btnMInus);
            this.groupBox1.Controls.Add(this.btnMult);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(92, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtDis);
            this.panel1.Controls.Add(this.labelOperation);
            this.panel1.Location = new System.Drawing.Point(32, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 52);
            this.panel1.TabIndex = 1;
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOperation.Location = new System.Drawing.Point(0, 0);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(0, 25);
            this.labelOperation.TabIndex = 14;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(322, 326);
            this.Controls.Add(this.groupBox1);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnMInus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn5Divi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;

    }
}

