namespace Gambirasio_Cassaforte
{
    partial class Form1
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
            Imposta = new Button();
            Apri = new Button();
            Chiudi = new Button();
            Sblocca = new Button();
            PIN = new NumericUpDown();
            CodiceDiSblocco = new TextBox();
            Cassaforte = new Label();
            ((System.ComponentModel.ISupportInitialize)PIN).BeginInit();
            SuspendLayout();
            // 
            // Imposta
            // 
            Imposta.Location = new Point(102, 63);
            Imposta.Name = "Imposta";
            Imposta.Size = new Size(104, 43);
            Imposta.TabIndex = 0;
            Imposta.Text = "IMPOSTA";
            Imposta.UseVisualStyleBackColor = true;
            Imposta.Click += Imposta_Click;
            // 
            // Apri
            // 
            Apri.Location = new Point(102, 131);
            Apri.Name = "Apri";
            Apri.Size = new Size(104, 43);
            Apri.TabIndex = 1;
            Apri.Text = "APRI";
            Apri.UseVisualStyleBackColor = true;
            Apri.Click += Apri_Click;
            // 
            // Chiudi
            // 
            Chiudi.Location = new Point(102, 202);
            Chiudi.Name = "Chiudi";
            Chiudi.Size = new Size(104, 43);
            Chiudi.TabIndex = 2;
            Chiudi.Text = "CHIUDI";
            Chiudi.UseVisualStyleBackColor = true;
            Chiudi.Click += Chiudi_Click;
            // 
            // Sblocca
            // 
            Sblocca.Location = new Point(102, 274);
            Sblocca.Name = "Sblocca";
            Sblocca.Size = new Size(104, 43);
            Sblocca.TabIndex = 3;
            Sblocca.Text = "SBLOCCA";
            Sblocca.UseVisualStyleBackColor = true;
            Sblocca.Click += Sblocca_Click;
            // 
            // PIN
            // 
            PIN.Location = new Point(261, 104);
            PIN.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            PIN.Name = "PIN";
            PIN.Size = new Size(120, 23);
            PIN.TabIndex = 4;
            // 
            // CodiceDiSblocco
            // 
            CodiceDiSblocco.Location = new Point(261, 244);
            CodiceDiSblocco.Name = "CodiceDiSblocco";
            CodiceDiSblocco.Size = new Size(115, 23);
            CodiceDiSblocco.TabIndex = 5;
            // 
            // Cassaforte
            // 
            Cassaforte.AutoSize = true;
            Cassaforte.BackColor = SystemColors.ActiveCaption;
            Cassaforte.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cassaforte.Location = new Point(596, 161);
            Cassaforte.Name = "Cassaforte";
            Cassaforte.Size = new Size(97, 106);
            Cassaforte.TabIndex = 6;
            Cassaforte.Text = "A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cassaforte);
            Controls.Add(CodiceDiSblocco);
            Controls.Add(PIN);
            Controls.Add(Sblocca);
            Controls.Add(Chiudi);
            Controls.Add(Apri);
            Controls.Add(Imposta);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PIN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Imposta;
        private Button Apri;
        private Button Chiudi;
        private Button Sblocca;
        private NumericUpDown PIN;
        private TextBox CodiceDiSblocco;
        private Label Cassaforte;
    }
}