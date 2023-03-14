namespace SistemaVeterinaria1.UI
{
    partial class FormInicioSesion
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.menuSesion = new System.Windows.Forms.MenuStrip();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smEditarPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.smHistorialCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCita = new System.Windows.Forms.Label();
            this.btnCita = new System.Windows.Forms.Button();
            this.textMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.richTextChat = new System.Windows.Forms.RichTextBox();
            this.btnFinalizarChat = new System.Windows.Forms.Button();
            this.menuSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(54, 40);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(0, 13);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuSesion
            // 
            this.menuSesion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuSesion.Location = new System.Drawing.Point(0, 0);
            this.menuSesion.Name = "menuSesion";
            this.menuSesion.Size = new System.Drawing.Size(830, 24);
            this.menuSesion.TabIndex = 1;
            this.menuSesion.Text = "menuStrip1";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smEditarPerfil,
            this.smHistorialCitas});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // smEditarPerfil
            // 
            this.smEditarPerfil.Name = "smEditarPerfil";
            this.smEditarPerfil.Size = new System.Drawing.Size(163, 22);
            this.smEditarPerfil.Text = "Editar Perfil";
            this.smEditarPerfil.Click += new System.EventHandler(this.smEditarPerfil_Click);
            // 
            // smHistorialCitas
            // 
            this.smHistorialCitas.Name = "smHistorialCitas";
            this.smHistorialCitas.Size = new System.Drawing.Size(163, 22);
            this.smHistorialCitas.Text = "Historial de Citas";
            this.smHistorialCitas.Click += new System.EventHandler(this.smHistorialCitas_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // lblCita
            // 
            this.lblCita.AutoSize = true;
            this.lblCita.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCita.Location = new System.Drawing.Point(112, 117);
            this.lblCita.Name = "lblCita";
            this.lblCita.Size = new System.Drawing.Size(636, 93);
            this.lblCita.TabIndex = 2;
            this.lblCita.Text = "Para solicitar la atención de un asistente veterinario, \r\npresiona el siguiente b" +
    "otón:\r\n\r\n";
            // 
            // btnCita
            // 
            this.btnCita.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCita.Location = new System.Drawing.Point(355, 213);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(146, 64);
            this.btnCita.TabIndex = 3;
            this.btnCita.Text = "Solicitar Cita";
            this.btnCita.UseVisualStyleBackColor = true;
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            // 
            // textMensaje
            // 
            this.textMensaje.Location = new System.Drawing.Point(26, 468);
            this.textMensaje.Name = "textMensaje";
            this.textMensaje.Size = new System.Drawing.Size(690, 20);
            this.textMensaje.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(726, 465);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(98, 34);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(95, 42);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "label1";
            // 
            // richTextChat
            // 
            this.richTextChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextChat.Location = new System.Drawing.Point(26, 104);
            this.richTextChat.Name = "richTextChat";
            this.richTextChat.ReadOnly = true;
            this.richTextChat.Size = new System.Drawing.Size(690, 332);
            this.richTextChat.TabIndex = 8;
            this.richTextChat.Text = "";
            // 
            // btnFinalizarChat
            // 
            this.btnFinalizarChat.Location = new System.Drawing.Point(742, 104);
            this.btnFinalizarChat.Name = "btnFinalizarChat";
            this.btnFinalizarChat.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizarChat.TabIndex = 9;
            this.btnFinalizarChat.Text = "Finalizar";
            this.btnFinalizarChat.UseVisualStyleBackColor = true;
            this.btnFinalizarChat.Click += new System.EventHandler(this.btnFinalizarChat_Click);
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(830, 506);
            this.Controls.Add(this.btnFinalizarChat);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.textMensaje);
            this.Controls.Add(this.lblCita);
            this.Controls.Add(this.btnCita);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.menuSesion);
            this.Controls.Add(this.richTextChat);
            this.MainMenuStrip = this.menuSesion;
            this.Name = "FormInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInicioSesion_FormClosed);
            this.Load += new System.EventHandler(this.FormInicioSesion_Load);
            this.menuSesion.ResumeLayout(false);
            this.menuSesion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.MenuStrip menuSesion;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smEditarPerfil;
        private System.Windows.Forms.ToolStripMenuItem smHistorialCitas;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Label lblCita;
        private System.Windows.Forms.Button btnCita;
        private System.Windows.Forms.TextBox textMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.RichTextBox richTextChat;
        private System.Windows.Forms.Button btnFinalizarChat;
    }
}