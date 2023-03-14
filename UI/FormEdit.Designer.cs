namespace SistemaVeterinaria1.UI
{
    partial class FormEdit
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textComPassword = new System.Windows.Forms.TextBox();
            this.textPasswordActual = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editar Información de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevos Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nuevos Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nuevo Correo Electrónico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nueva Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Repite nueva contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "Contraseña Actual (*):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(209, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Los campos con (*) son obligatorios.";
            // 
            // textNombres
            // 
            this.textNombres.Location = new System.Drawing.Point(338, 112);
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(209, 20);
            this.textNombres.TabIndex = 9;
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(338, 152);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(209, 20);
            this.textApellidos.TabIndex = 10;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(338, 189);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(209, 20);
            this.textEmail.TabIndex = 11;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(338, 229);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(209, 20);
            this.textPassword.TabIndex = 12;
            // 
            // textComPassword
            // 
            this.textComPassword.Location = new System.Drawing.Point(338, 272);
            this.textComPassword.Name = "textComPassword";
            this.textComPassword.Size = new System.Drawing.Size(209, 20);
            this.textComPassword.TabIndex = 13;
            // 
            // textPasswordActual
            // 
            this.textPasswordActual.Location = new System.Drawing.Point(338, 311);
            this.textPasswordActual.Name = "textPasswordActual";
            this.textPasswordActual.Size = new System.Drawing.Size(209, 20);
            this.textPasswordActual.TabIndex = 14;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.Location = new System.Drawing.Point(254, 355);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(165, 36);
            this.btnCambiar.TabIndex = 15;
            this.btnCambiar.Text = "Confirmar Cambios";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(667, 403);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.textPasswordActual);
            this.Controls.Add(this.textComPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.textNombres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarInformacion";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textComPassword;
        private System.Windows.Forms.TextBox textPasswordActual;
        private System.Windows.Forms.Button btnCambiar;
    }
}