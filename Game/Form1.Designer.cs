namespace Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lplVida = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuracaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensibilidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ldlGameOver = new System.Windows.Forms.Label();
            this.restartBT = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.ldlPontos = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lplVida
            // 
            this.lplVida.AutoSize = true;
            this.lplVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lplVida.Location = new System.Drawing.Point(176, 33);
            this.lplVida.Name = "lplVida";
            this.lplVida.Size = new System.Drawing.Size(86, 31);
            this.lplVida.TabIndex = 0;
            this.lplVida.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracaoToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.novoJogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuracaoToolStripMenuItem
            // 
            this.configuracaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensibilidadeToolStripMenuItem});
            this.configuracaoToolStripMenuItem.Name = "configuracaoToolStripMenuItem";
            this.configuracaoToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.configuracaoToolStripMenuItem.Text = "configuracao";
            // 
            // sensibilidadeToolStripMenuItem
            // 
            this.sensibilidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baixaToolStripMenuItem,
            this.mediaToolStripMenuItem,
            this.altaToolStripMenuItem});
            this.sensibilidadeToolStripMenuItem.Name = "sensibilidadeToolStripMenuItem";
            this.sensibilidadeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.sensibilidadeToolStripMenuItem.Text = "sensibilidade";
            // 
            // baixaToolStripMenuItem
            // 
            this.baixaToolStripMenuItem.Name = "baixaToolStripMenuItem";
            this.baixaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.baixaToolStripMenuItem.Text = "baixa";
            this.baixaToolStripMenuItem.Click += new System.EventHandler(this.baixaToolStripMenuItem_Click);
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.Checked = true;
            this.mediaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.mediaToolStripMenuItem.Text = "media";
            this.mediaToolStripMenuItem.Click += new System.EventHandler(this.mediaToolStripMenuItem_Click);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.altaToolStripMenuItem.Text = "alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.restartToolStripMenuItem.Text = "restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // novoJogoToolStripMenuItem
            // 
            this.novoJogoToolStripMenuItem.Name = "novoJogoToolStripMenuItem";
            this.novoJogoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.novoJogoToolStripMenuItem.Text = "Novo Jogo";
            this.novoJogoToolStripMenuItem.Click += new System.EventHandler(this.novoJogoToolStripMenuItem_Click);
            // 
            // ldlGameOver
            // 
            this.ldlGameOver.AutoSize = true;
            this.ldlGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlGameOver.ForeColor = System.Drawing.Color.Red;
            this.ldlGameOver.Location = new System.Drawing.Point(49, 129);
            this.ldlGameOver.Name = "ldlGameOver";
            this.ldlGameOver.Size = new System.Drawing.Size(378, 76);
            this.ldlGameOver.TabIndex = 2;
            this.ldlGameOver.Text = "Game Over";
            this.ldlGameOver.Visible = false;
            // 
            // restartBT
            // 
            this.restartBT.Location = new System.Drawing.Point(197, 208);
            this.restartBT.Name = "restartBT";
            this.restartBT.Size = new System.Drawing.Size(75, 23);
            this.restartBT.TabIndex = 3;
            this.restartBT.Text = "Restart";
            this.restartBT.UseVisualStyleBackColor = true;
            this.restartBT.Visible = false;
            this.restartBT.Click += new System.EventHandler(this.restartBT_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(12, 24);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(47, 20);
            this.time.TabIndex = 4;
            this.time.Text = "time: ";
            // 
            // ldlPontos
            // 
            this.ldlPontos.AutoSize = true;
            this.ldlPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlPontos.Location = new System.Drawing.Point(12, 44);
            this.ldlPontos.Name = "ldlPontos";
            this.ldlPontos.Size = new System.Drawing.Size(71, 20);
            this.ldlPontos.TabIndex = 5;
            this.ldlPontos.Text = "Pontos : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 512);
            this.Controls.Add(this.ldlPontos);
            this.Controls.Add(this.time);
            this.Controls.Add(this.restartBT);
            this.Controls.Add(this.ldlGameOver);
            this.Controls.Add(this.lplVida);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GAME";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lplVida;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuracaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensibilidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.Label ldlGameOver;
        private System.Windows.Forms.Button restartBT;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.ToolStripMenuItem novoJogoToolStripMenuItem;
        private System.Windows.Forms.Label ldlPontos;
    }
}

