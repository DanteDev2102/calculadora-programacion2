namespace clase_basic
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
            this.label_numero1 = new System.Windows.Forms.Label();
            this.label_numero2 = new System.Windows.Forms.Label();
            this.textbox_numero1 = new System.Windows.Forms.TextBox();
            this.textbox_numero2 = new System.Windows.Forms.TextBox();
            this.button_restar = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.button_sumar = new System.Windows.Forms.Button();
            this.button_multiplicar = new System.Windows.Forms.Button();
            this.button_dividir = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_numero1
            // 
            this.label_numero1.AutoSize = true;
            this.label_numero1.Location = new System.Drawing.Point(270, 120);
            this.label_numero1.Name = "label_numero1";
            this.label_numero1.Size = new System.Drawing.Size(58, 15);
            this.label_numero1.TabIndex = 0;
            this.label_numero1.Text = "numero 1";
            this.label_numero1.Click += new System.EventHandler(this.label_numero1_Click);
            // 
            // label_numero2
            // 
            this.label_numero2.AutoSize = true;
            this.label_numero2.Location = new System.Drawing.Point(270, 182);
            this.label_numero2.Name = "label_numero2";
            this.label_numero2.Size = new System.Drawing.Size(58, 15);
            this.label_numero2.TabIndex = 1;
            this.label_numero2.Text = "numero 2";
            this.label_numero2.Click += new System.EventHandler(this.label_numero2_Click);
            // 
            // textbox_numero1
            // 
            this.textbox_numero1.Location = new System.Drawing.Point(270, 145);
            this.textbox_numero1.Name = "textbox_numero1";
            this.textbox_numero1.Size = new System.Drawing.Size(100, 23);
            this.textbox_numero1.TabIndex = 2;
            this.textbox_numero1.TextChanged += new System.EventHandler(this.textbox_numero1_TextChanged);
            // 
            // textbox_numero2
            // 
            this.textbox_numero2.Location = new System.Drawing.Point(270, 209);
            this.textbox_numero2.Name = "textbox_numero2";
            this.textbox_numero2.Size = new System.Drawing.Size(100, 23);
            this.textbox_numero2.TabIndex = 3;
            this.textbox_numero2.TextChanged += new System.EventHandler(this.textbox_numero2_TextChanged);
            // 
            // button_restar
            // 
            this.button_restar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_restar.Location = new System.Drawing.Point(383, 177);
            this.button_restar.Name = "button_restar";
            this.button_restar.Size = new System.Drawing.Size(76, 25);
            this.button_restar.TabIndex = 4;
            this.button_restar.Text = "restar";
            this.button_restar.UseVisualStyleBackColor = false;
            this.button_restar.Click += new System.EventHandler(this.button_restar_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_reset.Location = new System.Drawing.Point(465, 145);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(76, 27);
            this.button_reset.TabIndex = 5;
            this.button_reset.Text = "resetear";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(332, 248);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(38, 23);
            this.resultado.TabIndex = 6;
            this.resultado.TextChanged += new System.EventHandler(this.resultado_TextChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(270, 256);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(56, 15);
            this.result.TabIndex = 7;
            this.result.Text = "resultado";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // button_sumar
            // 
            this.button_sumar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_sumar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_sumar.Location = new System.Drawing.Point(383, 145);
            this.button_sumar.Name = "button_sumar";
            this.button_sumar.Size = new System.Drawing.Size(76, 25);
            this.button_sumar.TabIndex = 8;
            this.button_sumar.Text = "sumar";
            this.button_sumar.UseVisualStyleBackColor = false;
            this.button_sumar.Click += new System.EventHandler(this.button_sumar_Click);
            // 
            // button_multiplicar
            // 
            this.button_multiplicar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_multiplicar.Location = new System.Drawing.Point(383, 209);
            this.button_multiplicar.Name = "button_multiplicar";
            this.button_multiplicar.Size = new System.Drawing.Size(76, 25);
            this.button_multiplicar.TabIndex = 9;
            this.button_multiplicar.Text = "multiplicar";
            this.button_multiplicar.UseVisualStyleBackColor = false;
            this.button_multiplicar.Click += new System.EventHandler(this.button_multiplicar_Click_1);
            // 
            // button_dividir
            // 
            this.button_dividir.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_dividir.Location = new System.Drawing.Point(465, 177);
            this.button_dividir.Name = "button_dividir";
            this.button_dividir.Size = new System.Drawing.Size(76, 25);
            this.button_dividir.TabIndex = 10;
            this.button_dividir.Text = "dividir";
            this.button_dividir.UseVisualStyleBackColor = false;
            this.button_dividir.Click += new System.EventHandler(this.button_dividir_Click_1);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo.Location = new System.Drawing.Point(270, 43);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(278, 45);
            this.titulo.TabIndex = 11;
            this.titulo.Text = "calculadora basica";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(423, 251);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 15);
            this.errorMessage.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.button_dividir);
            this.Controls.Add(this.button_multiplicar);
            this.Controls.Add(this.button_sumar);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_restar);
            this.Controls.Add(this.textbox_numero2);
            this.Controls.Add(this.textbox_numero1);
            this.Controls.Add(this.label_numero2);
            this.Controls.Add(this.label_numero1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_numero1;
        private Label label_numero2;
        private TextBox textbox_numero1;
        private TextBox textbox_numero2;
        private Button button_restar;
        private Button button_reset;
        private TextBox resultado;
        private Label result;
        private Button button_sumar;
        private Button button_multiplicar;
        private Button button_dividir;
        private Label titulo;
        private Label errorMessage;
    }
}