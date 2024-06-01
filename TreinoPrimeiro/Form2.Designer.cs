namespace TreinoPrimeiro
{
    partial class frmMidia
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
            this.btnSair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.primeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nadadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fatoraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(680, 366);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 72);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primeiroToolStripMenuItem,
            this.testeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // primeiroToolStripMenuItem
            // 
            this.primeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salárioToolStripMenuItem,
            this.nadadoresToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.fatoraçãoToolStripMenuItem});
            this.primeiroToolStripMenuItem.Name = "primeiroToolStripMenuItem";
            this.primeiroToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.primeiroToolStripMenuItem.Text = "PrimeiroProjeto";
            this.primeiroToolStripMenuItem.Click += new System.EventHandler(this.primeiroToolStripMenuItem_Click);
            // 
            // salárioToolStripMenuItem
            // 
            this.salárioToolStripMenuItem.Name = "salárioToolStripMenuItem";
            this.salárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salárioToolStripMenuItem.Text = "Salário";
            this.salárioToolStripMenuItem.Click += new System.EventHandler(this.salárioToolStripMenuItem_Click);
            // 
            // nadadoresToolStripMenuItem
            // 
            this.nadadoresToolStripMenuItem.Name = "nadadoresToolStripMenuItem";
            this.nadadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nadadoresToolStripMenuItem.Text = "Nadadores";
            this.nadadoresToolStripMenuItem.Click += new System.EventHandler(this.nadadoresToolStripMenuItem_Click_1);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teste1ToolStripMenuItem});
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.testeToolStripMenuItem.Text = "Teste";
            // 
            // teste1ToolStripMenuItem
            // 
            this.teste1ToolStripMenuItem.Name = "teste1ToolStripMenuItem";
            this.teste1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teste1ToolStripMenuItem.Text = "Teste1";
            this.teste1ToolStripMenuItem.Click += new System.EventHandler(this.teste1ToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click_1);
            // 
            // fatoraçãoToolStripMenuItem
            // 
            this.fatoraçãoToolStripMenuItem.Name = "fatoraçãoToolStripMenuItem";
            this.fatoraçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fatoraçãoToolStripMenuItem.Text = "Fatoração";
            this.fatoraçãoToolStripMenuItem.Click += new System.EventHandler(this.fatoraçãoToolStripMenuItem_Click);
            // 
            // frmMidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMidia";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem primeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nadadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fatoraçãoToolStripMenuItem;
    }
}