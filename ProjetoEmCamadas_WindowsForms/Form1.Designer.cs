namespace ProjetoEmCamadas_WindowsForms
{
    partial class frmCadastro
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
            this.btnCadastroCategoria = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroCategoria
            // 
            this.btnCadastroCategoria.Location = new System.Drawing.Point(26, 29);
            this.btnCadastroCategoria.Name = "btnCadastroCategoria";
            this.btnCadastroCategoria.Size = new System.Drawing.Size(171, 23);
            this.btnCadastroCategoria.TabIndex = 0;
            this.btnCadastroCategoria.Text = "CADASTRAR CATEGORIA";
            this.btnCadastroCategoria.UseVisualStyleBackColor = true;
            this.btnCadastroCategoria.Click += new System.EventHandler(this.btnCadastroCategoria_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(26, 91);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(171, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "LISTAR CATEGORIA";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(26, 153);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(171, 22);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "APAGAR CATEGORIA";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastroCategoria);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroCategoria;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnApagar;
    }
}

