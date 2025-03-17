namespace Apollo
{
    partial class frmApollo
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
            this.lsvLeveranciers = new System.Windows.Forms.ListView();
            this.LVnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Firmanaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Postnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gemeente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeverancierLVnr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeverancierFirmanaam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLeverancierAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLeverancierPostnr = new System.Windows.Forms.TextBox();
            this.txtLeverancierGemeente = new System.Windows.Forms.TextBox();
            this.btnLeverancierWijzig = new System.Windows.Forms.Button();
            this.btnLeverancierAdd = new System.Windows.Forms.Button();
            this.btnLeverancierVerwijder = new System.Windows.Forms.Button();
            this.lsvWijnen = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jaar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Omschrijving = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inhoud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ppf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hoeveelheid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboOrdenWijnen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWijnCode = new System.Windows.Forms.TextBox();
            this.txtWijnPpf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWijnJaar = new System.Windows.Forms.TextBox();
            this.txtWijnHoeveelheidPerPak = new System.Windows.Forms.TextBox();
            this.txtWijnOmschrijving = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWijnVoorraad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWijnInhoud = new System.Windows.Forms.TextBox();
            this.txtWijnWijzig = new System.Windows.Forms.Button();
            this.txtWijnAdd = new System.Windows.Forms.Button();
            this.txtWijnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvLeveranciers
            // 
            this.lsvLeveranciers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVnr,
            this.Firmanaam,
            this.Adres,
            this.Postnr,
            this.Gemeente});
            this.lsvLeveranciers.FullRowSelect = true;
            this.lsvLeveranciers.HideSelection = false;
            this.lsvLeveranciers.Location = new System.Drawing.Point(13, 13);
            this.lsvLeveranciers.Name = "lsvLeveranciers";
            this.lsvLeveranciers.Size = new System.Drawing.Size(404, 250);
            this.lsvLeveranciers.TabIndex = 0;
            this.lsvLeveranciers.UseCompatibleStateImageBehavior = false;
            this.lsvLeveranciers.View = System.Windows.Forms.View.Details;
            this.lsvLeveranciers.SelectedIndexChanged += new System.EventHandler(this.lsvLeveranciers_SelectedIndexChanged);
            // 
            // LVnr
            // 
            this.LVnr.Text = "LVnr";
            // 
            // Firmanaam
            // 
            this.Firmanaam.Text = "Firmanaam";
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            // 
            // Postnr
            // 
            this.Postnr.Text = "Postnr";
            // 
            // Gemeente
            // 
            this.Gemeente.Text = "Gemeente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LVnr";
            // 
            // txtLeverancierLVnr
            // 
            this.txtLeverancierLVnr.Location = new System.Drawing.Point(16, 316);
            this.txtLeverancierLVnr.Name = "txtLeverancierLVnr";
            this.txtLeverancierLVnr.Size = new System.Drawing.Size(100, 20);
            this.txtLeverancierLVnr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firmanaam";
            // 
            // txtLeverancierFirmanaam
            // 
            this.txtLeverancierFirmanaam.Location = new System.Drawing.Point(141, 316);
            this.txtLeverancierFirmanaam.Name = "txtLeverancierFirmanaam";
            this.txtLeverancierFirmanaam.Size = new System.Drawing.Size(100, 20);
            this.txtLeverancierFirmanaam.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adres";
            // 
            // txtLeverancierAdres
            // 
            this.txtLeverancierAdres.Location = new System.Drawing.Point(270, 316);
            this.txtLeverancierAdres.Name = "txtLeverancierAdres";
            this.txtLeverancierAdres.Size = new System.Drawing.Size(100, 20);
            this.txtLeverancierAdres.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Postnr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gemeente";
            // 
            // txtLeverancierPostnr
            // 
            this.txtLeverancierPostnr.Location = new System.Drawing.Point(13, 367);
            this.txtLeverancierPostnr.Name = "txtLeverancierPostnr";
            this.txtLeverancierPostnr.Size = new System.Drawing.Size(100, 20);
            this.txtLeverancierPostnr.TabIndex = 2;
            // 
            // txtLeverancierGemeente
            // 
            this.txtLeverancierGemeente.Location = new System.Drawing.Point(138, 367);
            this.txtLeverancierGemeente.Name = "txtLeverancierGemeente";
            this.txtLeverancierGemeente.Size = new System.Drawing.Size(100, 20);
            this.txtLeverancierGemeente.TabIndex = 2;
            // 
            // btnLeverancierWijzig
            // 
            this.btnLeverancierWijzig.Location = new System.Drawing.Point(13, 442);
            this.btnLeverancierWijzig.Name = "btnLeverancierWijzig";
            this.btnLeverancierWijzig.Size = new System.Drawing.Size(100, 23);
            this.btnLeverancierWijzig.TabIndex = 3;
            this.btnLeverancierWijzig.Text = "Wijzig";
            this.btnLeverancierWijzig.UseVisualStyleBackColor = true;
            // 
            // btnLeverancierAdd
            // 
            this.btnLeverancierAdd.Location = new System.Drawing.Point(138, 442);
            this.btnLeverancierAdd.Name = "btnLeverancierAdd";
            this.btnLeverancierAdd.Size = new System.Drawing.Size(100, 23);
            this.btnLeverancierAdd.TabIndex = 3;
            this.btnLeverancierAdd.Text = "Add";
            this.btnLeverancierAdd.UseVisualStyleBackColor = true;
            // 
            // btnLeverancierVerwijder
            // 
            this.btnLeverancierVerwijder.Location = new System.Drawing.Point(270, 442);
            this.btnLeverancierVerwijder.Name = "btnLeverancierVerwijder";
            this.btnLeverancierVerwijder.Size = new System.Drawing.Size(100, 23);
            this.btnLeverancierVerwijder.TabIndex = 3;
            this.btnLeverancierVerwijder.Text = "Verwijder";
            this.btnLeverancierVerwijder.UseVisualStyleBackColor = true;
            // 
            // lsvWijnen
            // 
            this.lsvWijnen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Jaar,
            this.Omschrijving,
            this.Inhoud,
            this.ppf,
            this.Hoeveelheid,
            this.Voorraad});
            this.lsvWijnen.HideSelection = false;
            this.lsvWijnen.Location = new System.Drawing.Point(514, 50);
            this.lsvWijnen.Name = "lsvWijnen";
            this.lsvWijnen.Size = new System.Drawing.Size(461, 213);
            this.lsvWijnen.TabIndex = 4;
            this.lsvWijnen.UseCompatibleStateImageBehavior = false;
            this.lsvWijnen.View = System.Windows.Forms.View.Details;
            // 
            // Code
            // 
            this.Code.Text = "Code";
            // 
            // Jaar
            // 
            this.Jaar.Text = "Jaar";
            // 
            // Omschrijving
            // 
            this.Omschrijving.Text = "Omschrijving";
            // 
            // Inhoud
            // 
            this.Inhoud.Text = "Inhoud";
            // 
            // ppf
            // 
            this.ppf.Text = "ppf";
            // 
            // Hoeveelheid
            // 
            this.Hoeveelheid.Text = "Hoeveelheid";
            // 
            // Voorraad
            // 
            this.Voorraad.Text = "Voorraad";
            // 
            // cboOrdenWijnen
            // 
            this.cboOrdenWijnen.FormattingEnabled = true;
            this.cboOrdenWijnen.Location = new System.Drawing.Point(684, 13);
            this.cboOrdenWijnen.Name = "cboOrdenWijnen";
            this.cboOrdenWijnen.Size = new System.Drawing.Size(121, 21);
            this.cboOrdenWijnen.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ppf";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(743, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Jaar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(740, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Hoeveelheid per pak";
            // 
            // txtWijnCode
            // 
            this.txtWijnCode.Location = new System.Drawing.Point(621, 316);
            this.txtWijnCode.Name = "txtWijnCode";
            this.txtWijnCode.Size = new System.Drawing.Size(100, 20);
            this.txtWijnCode.TabIndex = 2;
            // 
            // txtWijnPpf
            // 
            this.txtWijnPpf.Location = new System.Drawing.Point(618, 367);
            this.txtWijnPpf.Name = "txtWijnPpf";
            this.txtWijnPpf.Size = new System.Drawing.Size(100, 20);
            this.txtWijnPpf.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(872, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Omschrijving";
            // 
            // txtWijnJaar
            // 
            this.txtWijnJaar.Location = new System.Drawing.Point(746, 316);
            this.txtWijnJaar.Name = "txtWijnJaar";
            this.txtWijnJaar.Size = new System.Drawing.Size(100, 20);
            this.txtWijnJaar.TabIndex = 2;
            // 
            // txtWijnHoeveelheidPerPak
            // 
            this.txtWijnHoeveelheidPerPak.Location = new System.Drawing.Point(743, 367);
            this.txtWijnHoeveelheidPerPak.Name = "txtWijnHoeveelheidPerPak";
            this.txtWijnHoeveelheidPerPak.Size = new System.Drawing.Size(100, 20);
            this.txtWijnHoeveelheidPerPak.TabIndex = 2;
            // 
            // txtWijnOmschrijving
            // 
            this.txtWijnOmschrijving.Location = new System.Drawing.Point(875, 316);
            this.txtWijnOmschrijving.Name = "txtWijnOmschrijving";
            this.txtWijnOmschrijving.Size = new System.Drawing.Size(100, 20);
            this.txtWijnOmschrijving.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(872, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Voorraad";
            // 
            // txtWijnVoorraad
            // 
            this.txtWijnVoorraad.Location = new System.Drawing.Point(875, 367);
            this.txtWijnVoorraad.Name = "txtWijnVoorraad";
            this.txtWijnVoorraad.Size = new System.Drawing.Size(100, 20);
            this.txtWijnVoorraad.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(506, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Inhoud";
            // 
            // txtWijnInhoud
            // 
            this.txtWijnInhoud.Location = new System.Drawing.Point(509, 367);
            this.txtWijnInhoud.Name = "txtWijnInhoud";
            this.txtWijnInhoud.Size = new System.Drawing.Size(100, 20);
            this.txtWijnInhoud.TabIndex = 2;
            // 
            // txtWijnWijzig
            // 
            this.txtWijnWijzig.Location = new System.Drawing.Point(618, 442);
            this.txtWijnWijzig.Name = "txtWijnWijzig";
            this.txtWijnWijzig.Size = new System.Drawing.Size(100, 23);
            this.txtWijnWijzig.TabIndex = 3;
            this.txtWijnWijzig.Text = "Wijzig";
            this.txtWijnWijzig.UseVisualStyleBackColor = true;
            // 
            // txtWijnAdd
            // 
            this.txtWijnAdd.Location = new System.Drawing.Point(743, 442);
            this.txtWijnAdd.Name = "txtWijnAdd";
            this.txtWijnAdd.Size = new System.Drawing.Size(100, 23);
            this.txtWijnAdd.TabIndex = 3;
            this.txtWijnAdd.Text = "Add";
            this.txtWijnAdd.UseVisualStyleBackColor = true;
            // 
            // txtWijnVerwijder
            // 
            this.txtWijnVerwijder.Location = new System.Drawing.Point(875, 442);
            this.txtWijnVerwijder.Name = "txtWijnVerwijder";
            this.txtWijnVerwijder.Size = new System.Drawing.Size(100, 23);
            this.txtWijnVerwijder.TabIndex = 3;
            this.txtWijnVerwijder.Text = "Verwijder";
            this.txtWijnVerwijder.UseVisualStyleBackColor = true;
            // 
            // frmApollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 477);
            this.Controls.Add(this.cboOrdenWijnen);
            this.Controls.Add(this.lsvWijnen);
            this.Controls.Add(this.txtWijnVerwijder);
            this.Controls.Add(this.btnLeverancierVerwijder);
            this.Controls.Add(this.txtWijnAdd);
            this.Controls.Add(this.btnLeverancierAdd);
            this.Controls.Add(this.txtWijnWijzig);
            this.Controls.Add(this.btnLeverancierWijzig);
            this.Controls.Add(this.txtWijnInhoud);
            this.Controls.Add(this.txtWijnVoorraad);
            this.Controls.Add(this.txtWijnOmschrijving);
            this.Controls.Add(this.txtLeverancierAdres);
            this.Controls.Add(this.txtWijnHoeveelheidPerPak);
            this.Controls.Add(this.txtLeverancierGemeente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtWijnJaar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLeverancierFirmanaam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWijnPpf);
            this.Controls.Add(this.txtLeverancierPostnr);
            this.Controls.Add(this.txtWijnCode);
            this.Controls.Add(this.txtLeverancierLVnr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvLeveranciers);
            this.Name = "frmApollo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvLeveranciers;
        private System.Windows.Forms.ColumnHeader LVnr;
        private System.Windows.Forms.ColumnHeader Firmanaam;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Postnr;
        private System.Windows.Forms.ColumnHeader Gemeente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeverancierLVnr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeverancierFirmanaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLeverancierAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLeverancierPostnr;
        private System.Windows.Forms.TextBox txtLeverancierGemeente;
        private System.Windows.Forms.Button btnLeverancierWijzig;
        private System.Windows.Forms.Button btnLeverancierAdd;
        private System.Windows.Forms.Button btnLeverancierVerwijder;
        private System.Windows.Forms.ListView lsvWijnen;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Jaar;
        private System.Windows.Forms.ColumnHeader Omschrijving;
        private System.Windows.Forms.ColumnHeader Inhoud;
        private System.Windows.Forms.ColumnHeader ppf;
        private System.Windows.Forms.ColumnHeader Hoeveelheid;
        private System.Windows.Forms.ColumnHeader Voorraad;
        private System.Windows.Forms.ComboBox cboOrdenWijnen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWijnCode;
        private System.Windows.Forms.TextBox txtWijnPpf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWijnJaar;
        private System.Windows.Forms.TextBox txtWijnHoeveelheidPerPak;
        private System.Windows.Forms.TextBox txtWijnOmschrijving;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWijnVoorraad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWijnInhoud;
        private System.Windows.Forms.Button txtWijnWijzig;
        private System.Windows.Forms.Button txtWijnAdd;
        private System.Windows.Forms.Button txtWijnVerwijder;
    }
}

