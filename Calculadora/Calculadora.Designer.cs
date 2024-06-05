namespace Calculadora
{
    partial class FrCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrCalculadora));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.BtnModulo = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSete = new System.Windows.Forms.Button();
            this.BtnOito = new System.Windows.Forms.Button();
            this.BtnNove = new System.Windows.Forms.Button();
            this.BtnDiviSão = new System.Windows.Forms.Button();
            this.BtnQuatro = new System.Windows.Forms.Button();
            this.BtnCinco = new System.Windows.Forms.Button();
            this.BtnSeis = new System.Windows.Forms.Button();
            this.BtnMultiplicacao = new System.Windows.Forms.Button();
            this.BtnSubtração = new System.Windows.Forms.Button();
            this.BtnUm = new System.Windows.Forms.Button();
            this.BtnDois = new System.Windows.Forms.Button();
            this.BtnTrês = new System.Windows.Forms.Button();
            this.BtnSoma = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnVirgula = new System.Windows.Forms.Button();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.LblOperacao = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.sairToolStripMenuItem,
            this.toolStripSeparator2});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.ajudaToolStripMenuItem1});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.ajudaToolStripMenuItem1.Text = "Ajuda ";
            this.ajudaToolStripMenuItem1.Click += new System.EventHandler(this.ajudaToolStripMenuItem1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(7, 38);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(344, 50);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnModulo
            // 
            this.BtnModulo.BackColor = System.Drawing.Color.DarkGray;
            this.BtnModulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModulo.ForeColor = System.Drawing.Color.White;
            this.BtnModulo.Location = new System.Drawing.Point(7, 94);
            this.BtnModulo.Name = "BtnModulo";
            this.BtnModulo.Size = new System.Drawing.Size(75, 52);
            this.BtnModulo.TabIndex = 2;
            this.BtnModulo.Text = "%";
            this.BtnModulo.UseVisualStyleBackColor = false;
            this.BtnModulo.Click += new System.EventHandler(this.BtnModulo_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.DarkGray;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(88, 94);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(95, 52);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.DarkGray;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(189, 94);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(162, 52);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = " ←";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSete
            // 
            this.BtnSete.BackColor = System.Drawing.Color.DarkGray;
            this.BtnSete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSete.ForeColor = System.Drawing.Color.White;
            this.BtnSete.Location = new System.Drawing.Point(7, 152);
            this.BtnSete.Name = "BtnSete";
            this.BtnSete.Size = new System.Drawing.Size(75, 52);
            this.BtnSete.TabIndex = 5;
            this.BtnSete.Text = "7";
            this.BtnSete.UseVisualStyleBackColor = false;
            this.BtnSete.Click += new System.EventHandler(this.BtnSete_Click);
            // 
            // BtnOito
            // 
            this.BtnOito.BackColor = System.Drawing.Color.DarkGray;
            this.BtnOito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOito.ForeColor = System.Drawing.Color.White;
            this.BtnOito.Location = new System.Drawing.Point(88, 152);
            this.BtnOito.Name = "BtnOito";
            this.BtnOito.Size = new System.Drawing.Size(75, 52);
            this.BtnOito.TabIndex = 6;
            this.BtnOito.Text = "8";
            this.BtnOito.UseVisualStyleBackColor = false;
            this.BtnOito.Click += new System.EventHandler(this.BtnOito_Click);
            // 
            // BtnNove
            // 
            this.BtnNove.BackColor = System.Drawing.Color.DarkGray;
            this.BtnNove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNove.ForeColor = System.Drawing.Color.White;
            this.BtnNove.Location = new System.Drawing.Point(169, 152);
            this.BtnNove.Name = "BtnNove";
            this.BtnNove.Size = new System.Drawing.Size(75, 52);
            this.BtnNove.TabIndex = 7;
            this.BtnNove.Text = "9";
            this.BtnNove.UseVisualStyleBackColor = false;
            this.BtnNove.Click += new System.EventHandler(this.BtnNove_Click);
            // 
            // BtnDiviSão
            // 
            this.BtnDiviSão.BackColor = System.Drawing.Color.DarkGray;
            this.BtnDiviSão.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDiviSão.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiviSão.ForeColor = System.Drawing.Color.White;
            this.BtnDiviSão.Location = new System.Drawing.Point(250, 152);
            this.BtnDiviSão.Name = "BtnDiviSão";
            this.BtnDiviSão.Size = new System.Drawing.Size(101, 52);
            this.BtnDiviSão.TabIndex = 8;
            this.BtnDiviSão.Text = "/";
            this.BtnDiviSão.UseVisualStyleBackColor = false;
            this.BtnDiviSão.Click += new System.EventHandler(this.BtnDiviSão_Click);
            // 
            // BtnQuatro
            // 
            this.BtnQuatro.BackColor = System.Drawing.Color.DarkGray;
            this.BtnQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuatro.ForeColor = System.Drawing.Color.White;
            this.BtnQuatro.Location = new System.Drawing.Point(7, 210);
            this.BtnQuatro.Name = "BtnQuatro";
            this.BtnQuatro.Size = new System.Drawing.Size(75, 52);
            this.BtnQuatro.TabIndex = 9;
            this.BtnQuatro.Text = "4";
            this.BtnQuatro.UseVisualStyleBackColor = false;
            this.BtnQuatro.Click += new System.EventHandler(this.BtnQuatro_Click);
            // 
            // BtnCinco
            // 
            this.BtnCinco.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCinco.ForeColor = System.Drawing.Color.White;
            this.BtnCinco.Location = new System.Drawing.Point(88, 210);
            this.BtnCinco.Name = "BtnCinco";
            this.BtnCinco.Size = new System.Drawing.Size(75, 52);
            this.BtnCinco.TabIndex = 10;
            this.BtnCinco.Text = "5";
            this.BtnCinco.UseVisualStyleBackColor = false;
            this.BtnCinco.Click += new System.EventHandler(this.BtnCinco_Click);
            // 
            // BtnSeis
            // 
            this.BtnSeis.BackColor = System.Drawing.Color.DarkGray;
            this.BtnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeis.ForeColor = System.Drawing.Color.White;
            this.BtnSeis.Location = new System.Drawing.Point(169, 210);
            this.BtnSeis.Name = "BtnSeis";
            this.BtnSeis.Size = new System.Drawing.Size(75, 52);
            this.BtnSeis.TabIndex = 11;
            this.BtnSeis.Text = "6";
            this.BtnSeis.UseVisualStyleBackColor = false;
            this.BtnSeis.Click += new System.EventHandler(this.BtnSeis_Click);
            // 
            // BtnMultiplicacao
            // 
            this.BtnMultiplicacao.BackColor = System.Drawing.Color.DarkGray;
            this.BtnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicacao.ForeColor = System.Drawing.Color.White;
            this.BtnMultiplicacao.Location = new System.Drawing.Point(250, 210);
            this.BtnMultiplicacao.Name = "BtnMultiplicacao";
            this.BtnMultiplicacao.Size = new System.Drawing.Size(101, 52);
            this.BtnMultiplicacao.TabIndex = 12;
            this.BtnMultiplicacao.Text = "X";
            this.BtnMultiplicacao.UseVisualStyleBackColor = false;
            this.BtnMultiplicacao.Click += new System.EventHandler(this.BtnMultiplicacao_Click);
            // 
            // BtnSubtração
            // 
            this.BtnSubtração.BackColor = System.Drawing.Color.DarkGray;
            this.BtnSubtração.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSubtração.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtração.ForeColor = System.Drawing.Color.White;
            this.BtnSubtração.Location = new System.Drawing.Point(251, 268);
            this.BtnSubtração.Name = "BtnSubtração";
            this.BtnSubtração.Size = new System.Drawing.Size(101, 52);
            this.BtnSubtração.TabIndex = 13;
            this.BtnSubtração.Text = "-";
            this.BtnSubtração.UseVisualStyleBackColor = false;
            this.BtnSubtração.Click += new System.EventHandler(this.BtnSubtração_Click);
            // 
            // BtnUm
            // 
            this.BtnUm.BackColor = System.Drawing.Color.DarkGray;
            this.BtnUm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUm.ForeColor = System.Drawing.Color.White;
            this.BtnUm.Location = new System.Drawing.Point(7, 268);
            this.BtnUm.Name = "BtnUm";
            this.BtnUm.Size = new System.Drawing.Size(75, 52);
            this.BtnUm.TabIndex = 14;
            this.BtnUm.Text = "1";
            this.BtnUm.UseVisualStyleBackColor = false;
            this.BtnUm.Click += new System.EventHandler(this.BtnUm_Click);
            // 
            // BtnDois
            // 
            this.BtnDois.BackColor = System.Drawing.Color.DarkGray;
            this.BtnDois.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDois.ForeColor = System.Drawing.Color.White;
            this.BtnDois.Location = new System.Drawing.Point(88, 268);
            this.BtnDois.Name = "BtnDois";
            this.BtnDois.Size = new System.Drawing.Size(75, 52);
            this.BtnDois.TabIndex = 15;
            this.BtnDois.Text = "2";
            this.BtnDois.UseVisualStyleBackColor = false;
            this.BtnDois.Click += new System.EventHandler(this.BtnDois_Click);
            // 
            // BtnTrês
            // 
            this.BtnTrês.BackColor = System.Drawing.Color.DarkGray;
            this.BtnTrês.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTrês.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrês.ForeColor = System.Drawing.Color.White;
            this.BtnTrês.Location = new System.Drawing.Point(170, 268);
            this.BtnTrês.Name = "BtnTrês";
            this.BtnTrês.Size = new System.Drawing.Size(75, 52);
            this.BtnTrês.TabIndex = 16;
            this.BtnTrês.Text = "3";
            this.BtnTrês.UseVisualStyleBackColor = false;
            this.BtnTrês.Click += new System.EventHandler(this.BtnTrês_Click);
            // 
            // BtnSoma
            // 
            this.BtnSoma.BackColor = System.Drawing.Color.DarkGray;
            this.BtnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoma.ForeColor = System.Drawing.Color.White;
            this.BtnSoma.Location = new System.Drawing.Point(250, 326);
            this.BtnSoma.Name = "BtnSoma";
            this.BtnSoma.Size = new System.Drawing.Size(101, 52);
            this.BtnSoma.TabIndex = 17;
            this.BtnSoma.Text = "+";
            this.BtnSoma.UseVisualStyleBackColor = false;
            this.BtnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // BtnZero
            // 
            this.BtnZero.BackColor = System.Drawing.Color.DarkGray;
            this.BtnZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZero.ForeColor = System.Drawing.Color.White;
            this.BtnZero.Location = new System.Drawing.Point(7, 326);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(75, 52);
            this.BtnZero.TabIndex = 18;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = false;
            this.BtnZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // BtnVirgula
            // 
            this.BtnVirgula.BackColor = System.Drawing.Color.DarkGray;
            this.BtnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVirgula.ForeColor = System.Drawing.Color.White;
            this.BtnVirgula.Location = new System.Drawing.Point(88, 326);
            this.BtnVirgula.Name = "BtnVirgula";
            this.BtnVirgula.Size = new System.Drawing.Size(75, 52);
            this.BtnVirgula.TabIndex = 19;
            this.BtnVirgula.Text = ",";
            this.BtnVirgula.UseVisualStyleBackColor = false;
            this.BtnVirgula.Click += new System.EventHandler(this.BtnVirgula_Click);
            // 
            // BtnIgual
            // 
            this.BtnIgual.BackColor = System.Drawing.Color.DarkGray;
            this.BtnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIgual.ForeColor = System.Drawing.Color.White;
            this.BtnIgual.Location = new System.Drawing.Point(170, 326);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(75, 52);
            this.BtnIgual.TabIndex = 20;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = false;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // LblOperacao
            // 
            this.LblOperacao.AutoSize = true;
            this.LblOperacao.BackColor = System.Drawing.Color.White;
            this.LblOperacao.Location = new System.Drawing.Point(10, 41);
            this.LblOperacao.Name = "LblOperacao";
            this.LblOperacao.Size = new System.Drawing.Size(0, 16);
            this.LblOperacao.TabIndex = 21;
            // 
            // FrCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(364, 385);
            this.Controls.Add(this.LblOperacao);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.BtnVirgula);
            this.Controls.Add(this.BtnZero);
            this.Controls.Add(this.BtnSoma);
            this.Controls.Add(this.BtnTrês);
            this.Controls.Add(this.BtnDois);
            this.Controls.Add(this.BtnUm);
            this.Controls.Add(this.BtnSubtração);
            this.Controls.Add(this.BtnMultiplicacao);
            this.Controls.Add(this.BtnSeis);
            this.Controls.Add(this.BtnCinco);
            this.Controls.Add(this.BtnQuatro);
            this.Controls.Add(this.BtnDiviSão);
            this.Controls.Add(this.BtnNove);
            this.Controls.Add(this.BtnOito);
            this.Controls.Add(this.BtnSete);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnModulo);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrCalculadora";
            this.Text = "Calculadora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button BtnModulo;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSete;
        private System.Windows.Forms.Button BtnOito;
        private System.Windows.Forms.Button BtnNove;
        private System.Windows.Forms.Button BtnDiviSão;
        private System.Windows.Forms.Button BtnQuatro;
        private System.Windows.Forms.Button BtnCinco;
        private System.Windows.Forms.Button BtnSeis;
        private System.Windows.Forms.Button BtnMultiplicacao;
        private System.Windows.Forms.Button BtnSubtração;
        private System.Windows.Forms.Button BtnUm;
        private System.Windows.Forms.Button BtnDois;
        private System.Windows.Forms.Button BtnTrês;
        private System.Windows.Forms.Button BtnSoma;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.Button BtnVirgula;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.Label LblOperacao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

