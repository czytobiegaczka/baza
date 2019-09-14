namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnWaga = new System.Windows.Forms.Button();
            this.btnTrening = new System.Windows.Forms.Button();
            this.btnWstaw = new System.Windows.Forms.Button();
            this.btnRozlacz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConnect.Location = new System.Drawing.Point(26, 51);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(133, 51);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreate.Location = new System.Drawing.Point(226, 51);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(124, 51);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Miesiac";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnWaga
            // 
            this.btnWaga.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWaga.Location = new System.Drawing.Point(406, 51);
            this.btnWaga.Name = "btnWaga";
            this.btnWaga.Size = new System.Drawing.Size(120, 51);
            this.btnWaga.TabIndex = 0;
            this.btnWaga.Text = "Waga";
            this.btnWaga.UseVisualStyleBackColor = true;
            this.btnWaga.Click += new System.EventHandler(this.BtnWaga_Click);
            // 
            // btnTrening
            // 
            this.btnTrening.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrening.Location = new System.Drawing.Point(406, 145);
            this.btnTrening.Name = "btnTrening";
            this.btnTrening.Size = new System.Drawing.Size(120, 48);
            this.btnTrening.TabIndex = 1;
            this.btnTrening.Text = "Trening";
            this.btnTrening.UseVisualStyleBackColor = true;
            this.btnTrening.Click += new System.EventHandler(this.BtnTrening_Click);
            // 
            // btnWstaw
            // 
            this.btnWstaw.AllowDrop = true;
            this.btnWstaw.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWstaw.Location = new System.Drawing.Point(604, 51);
            this.btnWstaw.Name = "btnWstaw";
            this.btnWstaw.Size = new System.Drawing.Size(108, 50);
            this.btnWstaw.TabIndex = 2;
            this.btnWstaw.Text = "Wstaw";
            this.btnWstaw.UseVisualStyleBackColor = true;
            this.btnWstaw.Click += new System.EventHandler(this.BtnWstaw_Click);
            // 
            // btnRozlacz
            // 
            this.btnRozlacz.Location = new System.Drawing.Point(685, 383);
            this.btnRozlacz.Name = "btnRozlacz";
            this.btnRozlacz.Size = new System.Drawing.Size(75, 23);
            this.btnRozlacz.TabIndex = 3;
            this.btnRozlacz.Text = "Rozlacz";
            this.btnRozlacz.UseVisualStyleBackColor = true;
            this.btnRozlacz.Click += new System.EventHandler(this.BtnRozlacz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRozlacz);
            this.Controls.Add(this.btnWstaw);
            this.Controls.Add(this.btnTrening);
            this.Controls.Add(this.btnWaga);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnWaga;
        private System.Windows.Forms.Button btnTrening;
        private System.Windows.Forms.Button btnWstaw;
        private System.Windows.Forms.Button btnRozlacz;
    }
}

