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
            this.button_reset = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.comboBox_operaciones = new System.Windows.Forms.ComboBox();
            this.button_calcular = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_numero1
            // 
            this.label_numero1.AutoSize = true;
            this.label_numero1.Location = new System.Drawing.Point(17, 34);
            this.label_numero1.Name = "label_numero1";
            this.label_numero1.Size = new System.Drawing.Size(58, 15);
            this.label_numero1.TabIndex = 0;
            this.label_numero1.Text = "numero 1";
            // 
            // label_numero2
            // 
            this.label_numero2.AutoSize = true;
            this.label_numero2.Location = new System.Drawing.Point(17, 103);
            this.label_numero2.Name = "label_numero2";
            this.label_numero2.Size = new System.Drawing.Size(58, 15);
            this.label_numero2.TabIndex = 1;
            this.label_numero2.Text = "numero 2";
            // 
            // textbox_numero1
            // 
            this.textbox_numero1.Location = new System.Drawing.Point(17, 62);
            this.textbox_numero1.Name = "textbox_numero1";
            this.textbox_numero1.Size = new System.Drawing.Size(100, 23);
            this.textbox_numero1.TabIndex = 2;
            this.textbox_numero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_numero1_KeyPress);
            // 
            // textbox_numero2
            // 
            this.textbox_numero2.Location = new System.Drawing.Point(17, 133);
            this.textbox_numero2.Name = "textbox_numero2";
            this.textbox_numero2.Size = new System.Drawing.Size(100, 23);
            this.textbox_numero2.TabIndex = 3;
            this.textbox_numero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_numero2_KeyPress);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_reset.Location = new System.Drawing.Point(383, 299);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(76, 27);
            this.button_reset.TabIndex = 5;
            this.button_reset.Text = "resetear";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(79, 179);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(38, 23);
            this.resultado.TabIndex = 6;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(17, 184);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(56, 15);
            this.result.TabIndex = 7;
            this.result.Text = "resultado";
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
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label_numero1);
            this.groupBox.Controls.Add(this.textbox_numero1);
            this.groupBox.Controls.Add(this.label_numero2);
            this.groupBox.Controls.Add(this.textbox_numero2);
            this.groupBox.Controls.Add(this.result);
            this.groupBox.Controls.Add(this.resultado);
            this.groupBox.Location = new System.Drawing.Point(177, 127);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 224);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "inputs";
            // 
            // comboBox_operaciones
            // 
            this.comboBox_operaciones.FormattingEnabled = true;
            this.comboBox_operaciones.Items.AddRange(new object[] {
            "sumar",
            "restar",
            "multiplicar",
            "dividir"});
            this.comboBox_operaciones.Location = new System.Drawing.Point(392, 177);
            this.comboBox_operaciones.Name = "comboBox_operaciones";
            this.comboBox_operaciones.Size = new System.Drawing.Size(137, 23);
            this.comboBox_operaciones.TabIndex = 14;
            this.comboBox_operaciones.Text = "operaciones";
            this.comboBox_operaciones.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_calcular
            // 
            this.button_calcular.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_calcular.Location = new System.Drawing.Point(473, 298);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(75, 28);
            this.button_calcular.TabIndex = 15;
            this.button_calcular.Text = "calcular";
            this.button_calcular.UseVisualStyleBackColor = false;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.comboBox_operaciones);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.button_reset);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_numero1;
        private Label label_numero2;
        private TextBox textbox_numero1;
        private TextBox textbox_numero2;
        private Button button_reset;
        private TextBox resultado;
        private Label result;
        private Label titulo;
        private Label errorMessage;
        private GroupBox groupBox;
        private ComboBox comboBox_operaciones;
        private Button button_calcular;
    }
}