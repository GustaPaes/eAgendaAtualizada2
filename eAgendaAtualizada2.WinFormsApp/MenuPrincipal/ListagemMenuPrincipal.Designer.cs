namespace eAgendaAtualizada2.WinApp
{
    partial class ListagemMenuPrincipal
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
            this.labelTituloPrincipal = new System.Windows.Forms.Label();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnCompromissos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTituloPrincipal
            // 
            this.labelTituloPrincipal.AutoSize = true;
            this.labelTituloPrincipal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTituloPrincipal.Location = new System.Drawing.Point(148, 36);
            this.labelTituloPrincipal.Name = "labelTituloPrincipal";
            this.labelTituloPrincipal.Size = new System.Drawing.Size(256, 28);
            this.labelTituloPrincipal.TabIndex = 0;
            this.labelTituloPrincipal.Text = "Menu Principal eAgenda 2.0";
            // 
            // btnTarefas
            // 
            this.btnTarefas.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTarefas.Location = new System.Drawing.Point(12, 96);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(155, 101);
            this.btnTarefas.TabIndex = 1;
            this.btnTarefas.Text = "Cadastro de Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnContatos
            // 
            this.btnContatos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContatos.Location = new System.Drawing.Point(197, 96);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(155, 101);
            this.btnContatos.TabIndex = 2;
            this.btnContatos.Text = "Cadastro de Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // btnCompromissos
            // 
            this.btnCompromissos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCompromissos.Location = new System.Drawing.Point(383, 96);
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.Size = new System.Drawing.Size(155, 101);
            this.btnCompromissos.TabIndex = 3;
            this.btnCompromissos.Text = "Cadastro de Compromissos";
            this.btnCompromissos.UseVisualStyleBackColor = true;
            this.btnCompromissos.Click += new System.EventHandler(this.btnCompromissos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 260);
            this.Controls.Add(this.btnCompromissos);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.btnTarefas);
            this.Controls.Add(this.labelTituloPrincipal);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloPrincipal;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnCompromissos;
    }
}
