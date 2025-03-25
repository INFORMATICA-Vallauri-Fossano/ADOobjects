namespace ADOobjects
{
    partial class frmADONET
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAlunni = new System.Windows.Forms.DataGridView();
            this.btnNumeroAlunni = new System.Windows.Forms.Button();
            this.btnVisualizzaAlunni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaterie = new System.Windows.Forms.ComboBox();
            this.grbVoti = new System.Windows.Forms.GroupBox();
            this.btnInserireVoto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudVoto = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAlunno = new System.Windows.Forms.ComboBox();
            this.dgvMaterie = new System.Windows.Forms.DataGridView();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnEseguiQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunni)).BeginInit();
            this.grbVoti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunni
            // 
            this.dgvAlunni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunni.Location = new System.Drawing.Point(392, 12);
            this.dgvAlunni.Name = "dgvAlunni";
            this.dgvAlunni.Size = new System.Drawing.Size(396, 599);
            this.dgvAlunni.TabIndex = 0;
            // 
            // btnNumeroAlunni
            // 
            this.btnNumeroAlunni.Location = new System.Drawing.Point(12, 12);
            this.btnNumeroAlunni.Name = "btnNumeroAlunni";
            this.btnNumeroAlunni.Size = new System.Drawing.Size(173, 23);
            this.btnNumeroAlunni.TabIndex = 1;
            this.btnNumeroAlunni.Text = "NUMERO ALUNNI";
            this.btnNumeroAlunni.UseVisualStyleBackColor = true;
            this.btnNumeroAlunni.Click += new System.EventHandler(this.btnNumeroAlunni_Click);
            // 
            // btnVisualizzaAlunni
            // 
            this.btnVisualizzaAlunni.Location = new System.Drawing.Point(12, 41);
            this.btnVisualizzaAlunni.Name = "btnVisualizzaAlunni";
            this.btnVisualizzaAlunni.Size = new System.Drawing.Size(173, 23);
            this.btnVisualizzaAlunni.TabIndex = 2;
            this.btnVisualizzaAlunni.Text = "VISUALIZZA ALUNNI";
            this.btnVisualizzaAlunni.UseVisualStyleBackColor = true;
            this.btnVisualizzaAlunni.Click += new System.EventHandler(this.btnVisualizzaAlunni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MATERIA";
            // 
            // cmbMaterie
            // 
            this.cmbMaterie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterie.FormattingEnabled = true;
            this.cmbMaterie.Location = new System.Drawing.Point(89, 23);
            this.cmbMaterie.Name = "cmbMaterie";
            this.cmbMaterie.Size = new System.Drawing.Size(279, 21);
            this.cmbMaterie.TabIndex = 4;
            // 
            // grbVoti
            // 
            this.grbVoti.Controls.Add(this.btnInserireVoto);
            this.grbVoti.Controls.Add(this.label3);
            this.grbVoti.Controls.Add(this.nudVoto);
            this.grbVoti.Controls.Add(this.label2);
            this.grbVoti.Controls.Add(this.cmbAlunno);
            this.grbVoti.Controls.Add(this.label1);
            this.grbVoti.Controls.Add(this.cmbMaterie);
            this.grbVoti.Location = new System.Drawing.Point(12, 125);
            this.grbVoti.Name = "grbVoti";
            this.grbVoti.Size = new System.Drawing.Size(374, 167);
            this.grbVoti.TabIndex = 5;
            this.grbVoti.TabStop = false;
            this.grbVoti.Text = "INSERIMENTO VOTI";
            // 
            // btnInserireVoto
            // 
            this.btnInserireVoto.Location = new System.Drawing.Point(113, 121);
            this.btnInserireVoto.Name = "btnInserireVoto";
            this.btnInserireVoto.Size = new System.Drawing.Size(173, 23);
            this.btnInserireVoto.TabIndex = 6;
            this.btnInserireVoto.Text = "INSERIRE";
            this.btnInserireVoto.UseVisualStyleBackColor = true;
            this.btnInserireVoto.Click += new System.EventHandler(this.btnInserireVoto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "VOTO";
            // 
            // nudVoto
            // 
            this.nudVoto.DecimalPlaces = 1;
            this.nudVoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudVoto.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudVoto.Location = new System.Drawing.Point(89, 78);
            this.nudVoto.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudVoto.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudVoto.Name = "nudVoto";
            this.nudVoto.Size = new System.Drawing.Size(167, 22);
            this.nudVoto.TabIndex = 7;
            this.nudVoto.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ALUNNO";
            // 
            // cmbAlunno
            // 
            this.cmbAlunno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlunno.FormattingEnabled = true;
            this.cmbAlunno.Location = new System.Drawing.Point(89, 51);
            this.cmbAlunno.Name = "cmbAlunno";
            this.cmbAlunno.Size = new System.Drawing.Size(279, 21);
            this.cmbAlunno.TabIndex = 6;
            // 
            // dgvMaterie
            // 
            this.dgvMaterie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterie.Location = new System.Drawing.Point(794, 12);
            this.dgvMaterie.Name = "dgvMaterie";
            this.dgvMaterie.Size = new System.Drawing.Size(374, 599);
            this.dgvMaterie.TabIndex = 6;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(12, 298);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(374, 218);
            this.txtQuery.TabIndex = 7;
            // 
            // btnEseguiQuery
            // 
            this.btnEseguiQuery.Location = new System.Drawing.Point(213, 522);
            this.btnEseguiQuery.Name = "btnEseguiQuery";
            this.btnEseguiQuery.Size = new System.Drawing.Size(173, 23);
            this.btnEseguiQuery.TabIndex = 9;
            this.btnEseguiQuery.Text = "INSERIRE";
            this.btnEseguiQuery.UseVisualStyleBackColor = true;
            this.btnEseguiQuery.Click += new System.EventHandler(this.btnEseguiQuery_Click);
            // 
            // frmADONET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 623);
            this.Controls.Add(this.btnEseguiQuery);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.dgvMaterie);
            this.Controls.Add(this.grbVoti);
            this.Controls.Add(this.btnVisualizzaAlunni);
            this.Controls.Add(this.btnNumeroAlunni);
            this.Controls.Add(this.dgvAlunni);
            this.Name = "frmADONET";
            this.Text = "ALUNNI";
            this.Load += new System.EventHandler(this.frmObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunni)).EndInit();
            this.grbVoti.ResumeLayout(false);
            this.grbVoti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunni;
        private System.Windows.Forms.Button btnNumeroAlunni;
        private System.Windows.Forms.Button btnVisualizzaAlunni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaterie;
        private System.Windows.Forms.GroupBox grbVoti;
        private System.Windows.Forms.NumericUpDown nudVoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAlunno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserireVoto;
        private System.Windows.Forms.DataGridView dgvMaterie;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnEseguiQuery;
    }
}

