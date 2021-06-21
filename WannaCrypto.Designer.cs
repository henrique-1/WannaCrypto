namespace WannaCrypto
{
    partial class WannaCrypto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WannaCrypto));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblFileSelected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDectypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtPassword4 = new System.Windows.Forms.TextBox();
            this.txtPassword3 = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlTopBar.Controls.Add(this.btnMinimize);
            this.pnlTopBar.Controls.Add(this.btnShutdown);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(393, 44);
            this.pnlTopBar.TabIndex = 0;
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTopBar_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::WannaCrypto.Properties.Resources.outline_minimize_white_48dp;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(303, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 36);
            this.btnMinimize.TabIndex = 24;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackgroundImage = global::WannaCrypto.Properties.Resources.outline_close_white_48dp;
            this.btnShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShutdown.FlatAppearance.BorderSize = 0;
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.ForeColor = System.Drawing.Color.White;
            this.btnShutdown.Location = new System.Drawing.Point(345, 3);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(36, 36);
            this.btnShutdown.TabIndex = 17;
            this.btnShutdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.BtnShutdown_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.Location = new System.Drawing.Point(12, 110);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(110, 66);
            this.btnSelectFile.TabIndex = 14;
            this.btnSelectFile.Text = "Selecione um Arquivo";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // lblFileSelected
            // 
            this.lblFileSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSelected.ForeColor = System.Drawing.Color.White;
            this.lblFileSelected.Location = new System.Drawing.Point(128, 110);
            this.lblFileSelected.Name = "lblFileSelected";
            this.lblFileSelected.Size = new System.Drawing.Size(253, 66);
            this.lblFileSelected.TabIndex = 15;
            this.lblFileSelected.Text = "Nenhum arquivo foi selecionado";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 53);
            this.label1.TabIndex = 16;
            this.label1.Text = "Wanna Crypto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDectypt
            // 
            this.btnDectypt.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDectypt.FlatAppearance.BorderSize = 0;
            this.btnDectypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDectypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.btnDectypt.ForeColor = System.Drawing.Color.White;
            this.btnDectypt.Location = new System.Drawing.Point(12, 438);
            this.btnDectypt.Name = "btnDectypt";
            this.btnDectypt.Size = new System.Drawing.Size(369, 118);
            this.btnDectypt.TabIndex = 23;
            this.btnDectypt.Text = "Decriptar";
            this.btnDectypt.UseVisualStyleBackColor = false;
            this.btnDectypt.Click += new System.EventHandler(this.BtnDectypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(12, 305);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(369, 118);
            this.btnEncrypt.TabIndex = 22;
            this.btnEncrypt.Text = "Encriptar";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // txtPassword4
            // 
            this.txtPassword4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPassword4.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword4.Location = new System.Drawing.Point(12, 266);
            this.txtPassword4.Name = "txtPassword4";
            this.txtPassword4.Size = new System.Drawing.Size(369, 22);
            this.txtPassword4.TabIndex = 21;
            this.txtPassword4.Text = "Password 4";
            this.txtPassword4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword4.Enter += new System.EventHandler(this.TxtPassword4_Enter);
            this.txtPassword4.Leave += new System.EventHandler(this.TxtPassword4_Leave);
            // 
            // txtPassword3
            // 
            this.txtPassword3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPassword3.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword3.Location = new System.Drawing.Point(12, 238);
            this.txtPassword3.Name = "txtPassword3";
            this.txtPassword3.Size = new System.Drawing.Size(369, 22);
            this.txtPassword3.TabIndex = 20;
            this.txtPassword3.Text = "Password 3";
            this.txtPassword3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword3.Enter += new System.EventHandler(this.TxtPassword3_Enter);
            this.txtPassword3.Leave += new System.EventHandler(this.TxtPassword3_Leave);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword2.Location = new System.Drawing.Point(12, 210);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(369, 22);
            this.txtPassword2.TabIndex = 19;
            this.txtPassword2.Text = "Password 2";
            this.txtPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword2.Enter += new System.EventHandler(this.TxtPassword2_Enter);
            this.txtPassword2.Leave += new System.EventHandler(this.TxtPassword2_Leave);
            // 
            // txtPassword1
            // 
            this.txtPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPassword1.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword1.Location = new System.Drawing.Point(12, 182);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(369, 22);
            this.txtPassword1.TabIndex = 18;
            this.txtPassword1.Text = "Password 1";
            this.txtPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword1.Enter += new System.EventHandler(this.TxtPassword1_Enter);
            this.txtPassword1.Leave += new System.EventHandler(this.TxtPassword1_Leave);
            // 
            // WannaCrypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(393, 580);
            this.Controls.Add(this.btnDectypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtPassword4);
            this.Controls.Add(this.txtPassword3);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFileSelected);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WannaCrypto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wanna Crypto";
            this.Load += new System.EventHandler(this.WannaCrypto_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblFileSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnDectypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtPassword4;
        private System.Windows.Forms.TextBox txtPassword3;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Button btnMinimize;
    }
}

