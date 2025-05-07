namespace KahootSockets
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSortir = new System.Windows.Forms.Button();
            this.lbTitol = new System.Windows.Forms.Label();
            this.lbIp = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbTextPuerto = new System.Windows.Forms.Label();
            this.lbIpText = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.lbPrueba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSortir
            // 
            this.btSortir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSortir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSortir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSortir.Location = new System.Drawing.Point(1041, 12);
            this.btSortir.Name = "btSortir";
            this.btSortir.Size = new System.Drawing.Size(98, 69);
            this.btSortir.TabIndex = 0;
            this.btSortir.Text = "Salir";
            this.btSortir.UseVisualStyleBackColor = false;
            this.btSortir.Click += new System.EventHandler(this.btSortir_Click);
            // 
            // lbTitol
            // 
            this.lbTitol.AutoSize = true;
            this.lbTitol.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitol.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTitol.Location = new System.Drawing.Point(186, 44);
            this.lbTitol.Name = "lbTitol";
            this.lbTitol.Size = new System.Drawing.Size(416, 116);
            this.lbTitol.TabIndex = 1;
            this.lbTitol.Text = "QuestIt";
            // 
            // lbIp
            // 
            this.lbIp.AutoSize = true;
            this.lbIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIp.Location = new System.Drawing.Point(350, 222);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(93, 73);
            this.lbIp.TabIndex = 1;
            this.lbIp.Text = "IP";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(119, 222);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(176, 73);
            this.lbPort.TabIndex = 0;
            this.lbPort.Text = "6969";
            // 
            // lbTextPuerto
            // 
            this.lbTextPuerto.AutoSize = true;
            this.lbTextPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextPuerto.Location = new System.Drawing.Point(120, 179);
            this.lbTextPuerto.Name = "lbTextPuerto";
            this.lbTextPuerto.Size = new System.Drawing.Size(178, 33);
            this.lbTextPuerto.TabIndex = 2;
            this.lbTextPuerto.Text = "El puerto es:";
            // 
            // lbIpText
            // 
            this.lbIpText.AutoSize = true;
            this.lbIpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIpText.Location = new System.Drawing.Point(328, 179);
            this.lbIpText.Name = "lbIpText";
            this.lbIpText.Size = new System.Drawing.Size(129, 33);
            this.lbIpText.TabIndex = 3;
            this.lbIpText.Text = "La IP es:";
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(293, 386);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(298, 103);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Comenzar";
            this.btStart.UseVisualStyleBackColor = false;
            // 
            // lbPrueba
            // 
            this.lbPrueba.AutoSize = true;
            this.lbPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrueba.Location = new System.Drawing.Point(122, 539);
            this.lbPrueba.Name = "lbPrueba";
            this.lbPrueba.Size = new System.Drawing.Size(176, 73);
            this.lbPrueba.TabIndex = 5;
            this.lbPrueba.Text = "6969";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1166, 739);
            this.Controls.Add(this.lbPrueba);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbIpText);
            this.Controls.Add(this.lbTextPuerto);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbIp);
            this.Controls.Add(this.lbTitol);
            this.Controls.Add(this.btSortir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "QuestIt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSortir;
        private System.Windows.Forms.Label lbTitol;
        private System.Windows.Forms.Label lbIp;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbTextPuerto;
        private System.Windows.Forms.Label lbIpText;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbPrueba;
    }
}

