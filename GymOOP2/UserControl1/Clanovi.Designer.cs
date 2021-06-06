namespace GymOOP2
{
    partial class Clanovi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAzuriraj = new FontAwesome.Sharp.IconButton();
            this.btnDodaj = new FontAwesome.Sharp.IconButton();
            this.cBClanarina = new System.Windows.Forms.ComboBox();
            this.dTPDatumUpisa = new System.Windows.Forms.DateTimePicker();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrisi = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rbDATrener = new System.Windows.Forms.RadioButton();
            this.tbNETrener = new System.Windows.Forms.RadioButton();
            this.daGrupa = new System.Windows.Forms.RadioButton();
            this.neGrupa = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAzuriraj.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnAzuriraj.IconColor = System.Drawing.Color.Black;
            this.btnAzuriraj.IconSize = 40;
            this.btnAzuriraj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzuriraj.Location = new System.Drawing.Point(353, 715);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Rotation = 0D;
            this.btnAzuriraj.Size = new System.Drawing.Size(177, 65);
            this.btnAzuriraj.TabIndex = 78;
            this.btnAzuriraj.Text = "Izmeni";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDodaj.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnDodaj.IconColor = System.Drawing.Color.Black;
            this.btnDodaj.IconSize = 40;
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.Location = new System.Drawing.Point(103, 715);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Rotation = 0D;
            this.btnDodaj.Size = new System.Drawing.Size(189, 65);
            this.btnDodaj.TabIndex = 77;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cBClanarina
            // 
            this.cBClanarina.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBClanarina.FormattingEnabled = true;
            this.cBClanarina.Items.AddRange(new object[] {
            "Mesecna ",
            "Dnevna"});
            this.cBClanarina.Location = new System.Drawing.Point(782, 608);
            this.cBClanarina.Name = "cBClanarina";
            this.cBClanarina.Size = new System.Drawing.Size(229, 25);
            this.cBClanarina.TabIndex = 76;
            // 
            // dTPDatumUpisa
            // 
            this.dTPDatumUpisa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPDatumUpisa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDatumUpisa.Location = new System.Drawing.Point(786, 428);
            this.dTPDatumUpisa.Name = "dTPDatumUpisa";
            this.dTPDatumUpisa.Size = new System.Drawing.Size(229, 25);
            this.dTPDatumUpisa.TabIndex = 74;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(259, 522);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(44, 21);
            this.rbMale.TabIndex = 73;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "M";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(353, 522);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(38, 21);
            this.rbFemale.TabIndex = 72;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Z";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(786, 364);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 25);
            this.txtEmail.TabIndex = 70;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJMBG.Location = new System.Drawing.Point(250, 602);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(201, 25);
            this.txtJMBG.TabIndex = 71;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(250, 364);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(201, 25);
            this.txtPrezime.TabIndex = 69;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(250, 298);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(201, 25);
            this.txtIme.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(583, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Clanarina";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(583, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Datum upisa\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(583, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 63;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 610);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 62;
            this.label7.Text = "JMBG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Pol\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Prezime\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Ime";
            // 
            // btnBrisi
            // 
            this.btnBrisi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBrisi.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnBrisi.IconColor = System.Drawing.Color.Black;
            this.btnBrisi.IconSize = 40;
            this.btnBrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrisi.Location = new System.Drawing.Point(594, 715);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Rotation = 0D;
            this.btnBrisi.Size = new System.Drawing.Size(177, 65);
            this.btnBrisi.TabIndex = 80;
            this.btnBrisi.Text = "Izbrisi";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(802, 715);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(177, 65);
            this.iconButton2.TabIndex = 81;
            this.iconButton2.Text = "Reset";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojTelefona.Location = new System.Drawing.Point(250, 425);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(201, 25);
            this.txtBrojTelefona.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "Broj telefona";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresa.Location = new System.Drawing.Point(786, 296);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(229, 25);
            this.txtAdresa.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 84;
            this.label5.Text = "Adresa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(583, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 86;
            this.label10.Text = "Trening";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(583, 551);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 17);
            this.label11.TabIndex = 87;
            this.label11.Text = "Da li zelite trenera?";
            // 
            // rbDATrener
            // 
            this.rbDATrener.AutoSize = true;
            this.rbDATrener.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDATrener.Location = new System.Drawing.Point(5, 9);
            this.rbDATrener.Name = "rbDATrener";
            this.rbDATrener.Size = new System.Drawing.Size(51, 21);
            this.rbDATrener.TabIndex = 88;
            this.rbDATrener.TabStop = true;
            this.rbDATrener.Text = "DA";
            this.rbDATrener.UseVisualStyleBackColor = true;
            // 
            // tbNETrener
            // 
            this.tbNETrener.AutoSize = true;
            this.tbNETrener.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNETrener.Location = new System.Drawing.Point(137, 9);
            this.tbNETrener.Name = "tbNETrener";
            this.tbNETrener.Size = new System.Drawing.Size(50, 21);
            this.tbNETrener.TabIndex = 89;
            this.tbNETrener.TabStop = true;
            this.tbNETrener.Text = "NE";
            this.tbNETrener.UseVisualStyleBackColor = true;
            // 
            // daGrupa
            // 
            this.daGrupa.AutoSize = true;
            this.daGrupa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daGrupa.Location = new System.Drawing.Point(3, 12);
            this.daGrupa.Name = "daGrupa";
            this.daGrupa.Size = new System.Drawing.Size(69, 21);
            this.daGrupa.TabIndex = 90;
            this.daGrupa.TabStop = true;
            this.daGrupa.Text = "Grupa";
            this.daGrupa.UseVisualStyleBackColor = true;
            // 
            // neGrupa
            // 
            this.neGrupa.AutoSize = true;
            this.neGrupa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neGrupa.Location = new System.Drawing.Point(116, 14);
            this.neGrupa.Name = "neGrupa";
            this.neGrupa.Size = new System.Drawing.Size(110, 21);
            this.neGrupa.TabIndex = 91;
            this.neGrupa.TabStop = true;
            this.neGrupa.Text = "Individualno";
            this.neGrupa.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.daGrupa);
            this.panel1.Controls.Add(this.neGrupa);
            this.panel1.Location = new System.Drawing.Point(779, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 47);
            this.panel1.TabIndex = 92;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbNETrener);
            this.panel2.Controls.Add(this.rbDATrener);
            this.panel2.Location = new System.Drawing.Point(779, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 33);
            this.panel2.TabIndex = 93;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackgroundColor = System.Drawing.Color.White;
            this.listBox1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.RowTemplate.Height = 24;
            this.listBox1.Size = new System.Drawing.Size(1132, 287);
            this.listBox1.TabIndex = 94;
            this.listBox1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listBox1_CellClick);
            this.listBox1.SelectionChanged += new System.EventHandler(this.listBox1_SelectionChanged);
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // Clanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cBClanarina);
            this.Controls.Add(this.dTPDatumUpisa);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clanovi";
            this.Size = new System.Drawing.Size(1138, 831);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAzuriraj;
        private FontAwesome.Sharp.IconButton btnDodaj;
        private System.Windows.Forms.ComboBox cBClanarina;
        private System.Windows.Forms.DateTimePicker dTPDatumUpisa;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnBrisi;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbDATrener;
        private System.Windows.Forms.RadioButton tbNETrener;
        private System.Windows.Forms.RadioButton daGrupa;
        private System.Windows.Forms.RadioButton neGrupa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView listBox1;
    }
}
