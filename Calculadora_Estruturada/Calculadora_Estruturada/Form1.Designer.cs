namespace Calculadora_Estruturada
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
            this.lv_num1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnsoma = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lv_num2 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_num1
            // 
            this.lv_num1.AutoSize = true;
            this.lv_num1.Location = new System.Drawing.Point(348, 183);
            this.lv_num1.Name = "lv_num1";
            this.lv_num1.Size = new System.Drawing.Size(40, 15);
            this.lv_num1.TabIndex = 0;
            this.lv_num1.Text = "Num1";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(348, 201);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 23);
            this.txtNum1.TabIndex = 1;
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(560, 201);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(75, 23);
            this.btnsoma.TabIndex = 2;
            this.btnsoma.Text = "Somar";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(454, 201);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 23);
            this.txtNum2.TabIndex = 3;
            // 
            // lv_num2
            // 
            this.lv_num2.AutoSize = true;
            this.lv_num2.Location = new System.Drawing.Point(454, 183);
            this.lv_num2.Name = "lv_num2";
            this.lv_num2.Size = new System.Drawing.Size(40, 15);
            this.lv_num2.TabIndex = 4;
            this.lv_num2.Text = "Num2";
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(348, 250);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(83, 15);
            this.res.TabIndex = 5;
            this.res.Text = "O Resultado é:";
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(560, 230);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(560, 259);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 7;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(560, 288);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 8;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.res);
            this.Controls.Add(this.lv_num2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lv_num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lv_num1;
        private TextBox txtNum1;
        private Button btnsoma;
        private TextBox txtNum2;
        private Label lv_num2;
        private Label res;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}