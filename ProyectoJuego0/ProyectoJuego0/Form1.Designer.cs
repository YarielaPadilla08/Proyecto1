namespace ProyectoJuego0
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
            panel1 = new Panel();
            baceptar = new Button();
            tresultado = new TextBox();
            num1 = new Label();
            label12 = new Label();
            resultado = new Label();
            num2 = new Label();
            op = new Label();
            label1 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lerrores = new Label();
            laciertos = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lerrores2 = new Label();
            laciertos2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(baceptar);
            panel1.Controls.Add(tresultado);
            panel1.Controls.Add(num1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(resultado);
            panel1.Controls.Add(num2);
            panel1.Controls.Add(op);
            panel1.Location = new Point(58, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 489);
            panel1.TabIndex = 0;
            // 
            // baceptar
            // 
            baceptar.Location = new Point(31, 323);
            baceptar.Name = "baceptar";
            baceptar.Size = new Size(374, 91);
            baceptar.TabIndex = 7;
            baceptar.Text = "Aceptar";
            baceptar.UseVisualStyleBackColor = true;
            baceptar.Click += baceptar_Click;
            // 
            // tresultado
            // 
            tresultado.Location = new Point(35, 265);
            tresultado.Name = "tresultado";
            tresultado.Size = new Size(122, 27);
            tresultado.TabIndex = 6;
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.BorderStyle = BorderStyle.FixedSingle;
            num1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num1.Location = new Point(35, 154);
            num1.Name = "num1";
            num1.Size = new Size(42, 64);
            num1.TabIndex = 5;
            num1.Text = " ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(35, 44);
            label12.Name = "label12";
            label12.Size = new Size(383, 31);
            label12.TabIndex = 4;
            label12.Text = "DIJITE EL RESULATDO OPERACION";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.BorderStyle = BorderStyle.FixedSingle;
            resultado.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultado.Location = new Point(323, 154);
            resultado.Name = "resultado";
            resultado.Size = new Size(82, 64);
            resultado.TabIndex = 3;
            resultado.Text = "=?";
            // 
            // num2
            // 
            num2.AutoSize = true;
            num2.BorderStyle = BorderStyle.FixedSingle;
            num2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num2.Location = new Point(217, 154);
            num2.Name = "num2";
            num2.Size = new Size(42, 64);
            num2.TabIndex = 2;
            num2.Text = " ";
            // 
            // op
            // 
            op.AutoSize = true;
            op.BorderStyle = BorderStyle.FixedSingle;
            op.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            op.Location = new Point(123, 154);
            op.Name = "op";
            op.Size = new Size(42, 64);
            op.TabIndex = 1;
            op.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 20);
            label1.Name = "label1";
            label1.Size = new Size(506, 54);
            label1.TabIndex = 1;
            label1.Text = "JUEGO DE ARITMETICA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(665, 93);
            label6.Name = "label6";
            label6.Size = new Size(403, 46);
            label6.TabIndex = 2;
            label6.Text = "CANTIDAD JUGADORES";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(740, 170);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "UNO";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(951, 170);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "DOS";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(686, 222);
            label7.Name = "label7";
            label7.Size = new Size(234, 38);
            label7.TabIndex = 5;
            label7.Text = "Puntos jugador1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(694, 279);
            label8.Name = "label8";
            label8.Size = new Size(66, 23);
            label8.TabIndex = 6;
            label8.Text = "Errores";
            //label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LimeGreen;
            label9.Location = new Point(817, 279);
            label9.Name = "label9";
            label9.Size = new Size(75, 23);
            label9.TabIndex = 7;
            label9.Text = "Aciertos";
            // 
            // lerrores
            // 
            lerrores.AutoSize = true;
            lerrores.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lerrores.Location = new Point(710, 302);
            lerrores.Name = "lerrores";
            lerrores.Size = new Size(20, 23);
            lerrores.TabIndex = 8;
            lerrores.Text = "0";
            // 
            // laciertos
            // 
            laciertos.AutoSize = true;
            laciertos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            laciertos.Location = new Point(844, 302);
            laciertos.Name = "laciertos";
            laciertos.Size = new Size(20, 23);
            laciertos.TabIndex = 9;
            laciertos.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(686, 335);
            label2.Name = "label2";
            label2.Size = new Size(234, 38);
            label2.TabIndex = 10;
            label2.Text = "Puntos jugador2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(694, 385);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 11;
            label3.Text = "Errores";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LimeGreen;
            label4.Location = new Point(817, 385);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 12;
            label4.Text = "Aciertos";
            // 
            // lerrores2
            // 
            lerrores2.AutoSize = true;
            lerrores2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lerrores2.Location = new Point(710, 416);
            lerrores2.Name = "lerrores2";
            lerrores2.Size = new Size(20, 23);
            lerrores2.TabIndex = 13;
            lerrores2.Text = "0";
            // 
            // laciertos2
            // 
            laciertos2.AutoSize = true;
            laciertos2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            laciertos2.Location = new Point(844, 416);
            laciertos2.Name = "laciertos2";
            laciertos2.Size = new Size(20, 23);
            laciertos2.TabIndex = 14;
            laciertos2.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 631);
            Controls.Add(laciertos2);
            Controls.Add(lerrores2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(laciertos);
            Controls.Add(lerrores);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label resultado;
        private Label num2;
        private Label op;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lerrores;
        private Label laciertos;
        private Label label12;
        private Label num1;
        private Button baceptar;
        private TextBox tresultado;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lerrores2;
        private Label laciertos2;
    }
}
