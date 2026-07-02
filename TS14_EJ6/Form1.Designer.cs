namespace TS14_EJ6
{
    partial class Form1
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
            this.lblTituloRanking = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnRestablecerRanking = new System.Windows.Forms.Button();
            this.lstRanking = new System.Windows.Forms.ListBox();
            this.lblMayor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloRanking
            // 
            this.lblTituloRanking.AutoSize = true;
            this.lblTituloRanking.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTituloRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRanking.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTituloRanking.Location = new System.Drawing.Point(260, 26);
            this.lblTituloRanking.Name = "lblTituloRanking";
            this.lblTituloRanking.Size = new System.Drawing.Size(245, 17);
            this.lblTituloRanking.TabIndex = 0;
            this.lblTituloRanking.Text = "Ranking de estudiantes por nota";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Gold;
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(196, 80);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(141, 37);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar Ranking";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnRestablecerRanking
            // 
            this.btnRestablecerRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecerRanking.Location = new System.Drawing.Point(431, 80);
            this.btnRestablecerRanking.Name = "btnRestablecerRanking";
            this.btnRestablecerRanking.Size = new System.Drawing.Size(141, 37);
            this.btnRestablecerRanking.TabIndex = 2;
            this.btnRestablecerRanking.Text = "Restablecer";
            this.btnRestablecerRanking.UseVisualStyleBackColor = true;
            this.btnRestablecerRanking.Click += new System.EventHandler(this.btnRestablecerRanking_Click);
            // 
            // lstRanking
            // 
            this.lstRanking.FormattingEnabled = true;
            this.lstRanking.Location = new System.Drawing.Point(58, 150);
            this.lstRanking.Name = "lstRanking";
            this.lstRanking.Size = new System.Drawing.Size(686, 212);
            this.lstRanking.TabIndex = 3;
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblMayor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor.Location = new System.Drawing.Point(57, 394);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(119, 18);
            this.lblMayor.TabIndex = 4;
            this.lblMayor.Text = "Primer Puesto: -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.lstRanking);
            this.Controls.Add(this.btnRestablecerRanking);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.lblTituloRanking);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloRanking;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnRestablecerRanking;
        private System.Windows.Forms.ListBox lstRanking;
        private System.Windows.Forms.Label lblMayor;
    }
}

