namespace AutoClient
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
            this.dtpRekisteriPVM = new System.Windows.Forms.DateTimePicker();
            this.lbVari = new System.Windows.Forms.Label();
            this.cbVari = new System.Windows.Forms.ComboBox();
            this.lbPolttoaine = new System.Windows.Forms.Label();
            this.cbPolttoaine = new System.Windows.Forms.ComboBox();
            this.lbMalli = new System.Windows.Forms.Label();
            this.lbMerkki = new System.Windows.Forms.Label();
            this.lbHinta = new System.Windows.Forms.Label();
            this.lbMoottorinTilavuus = new System.Windows.Forms.Label();
            this.lbMittarilukema = new System.Windows.Forms.Label();
            this.btnSeuraava = new System.Windows.Forms.Button();
            this.btnEdellinen = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.btnUusiTietue = new System.Windows.Forms.Button();
            this.cbMalli = new System.Windows.Forms.ComboBox();
            this.cbMerkki = new System.Windows.Forms.ComboBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbMoottorinTilavuus = new System.Windows.Forms.TextBox();
            this.tbMittarilukema = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpRekisteriPVM
            // 
            this.dtpRekisteriPVM.CustomFormat = "yyyy-MM-dd";
            this.dtpRekisteriPVM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRekisteriPVM.Location = new System.Drawing.Point(15, 107);
            this.dtpRekisteriPVM.Name = "dtpRekisteriPVM";
            this.dtpRekisteriPVM.Size = new System.Drawing.Size(95, 20);
            this.dtpRekisteriPVM.TabIndex = 41;
            // 
            // lbVari
            // 
            this.lbVari.AutoSize = true;
            this.lbVari.Location = new System.Drawing.Point(275, 39);
            this.lbVari.Name = "lbVari";
            this.lbVari.Size = new System.Drawing.Size(25, 13);
            this.lbVari.TabIndex = 40;
            this.lbVari.Text = "Väri";
            // 
            // cbVari
            // 
            this.cbVari.FormattingEnabled = true;
            this.cbVari.Location = new System.Drawing.Point(278, 58);
            this.cbVari.Name = "cbVari";
            this.cbVari.Size = new System.Drawing.Size(121, 21);
            this.cbVari.TabIndex = 39;
            // 
            // lbPolttoaine
            // 
            this.lbPolttoaine.AutoSize = true;
            this.lbPolttoaine.Location = new System.Drawing.Point(411, 41);
            this.lbPolttoaine.Name = "lbPolttoaine";
            this.lbPolttoaine.Size = new System.Drawing.Size(54, 13);
            this.lbPolttoaine.TabIndex = 38;
            this.lbPolttoaine.Text = "Polttoaine";
            // 
            // cbPolttoaine
            // 
            this.cbPolttoaine.FormattingEnabled = true;
            this.cbPolttoaine.Location = new System.Drawing.Point(414, 57);
            this.cbPolttoaine.Name = "cbPolttoaine";
            this.cbPolttoaine.Size = new System.Drawing.Size(121, 21);
            this.cbPolttoaine.TabIndex = 37;
            // 
            // lbMalli
            // 
            this.lbMalli.AutoSize = true;
            this.lbMalli.Location = new System.Drawing.Point(141, 39);
            this.lbMalli.Name = "lbMalli";
            this.lbMalli.Size = new System.Drawing.Size(28, 13);
            this.lbMalli.TabIndex = 36;
            this.lbMalli.Text = "Malli";
            // 
            // lbMerkki
            // 
            this.lbMerkki.AutoSize = true;
            this.lbMerkki.Location = new System.Drawing.Point(12, 38);
            this.lbMerkki.Name = "lbMerkki";
            this.lbMerkki.Size = new System.Drawing.Size(39, 13);
            this.lbMerkki.TabIndex = 35;
            this.lbMerkki.Text = "Merkki";
            // 
            // lbHinta
            // 
            this.lbHinta.AutoSize = true;
            this.lbHinta.Location = new System.Drawing.Point(666, 39);
            this.lbHinta.Name = "lbHinta";
            this.lbHinta.Size = new System.Drawing.Size(32, 13);
            this.lbHinta.TabIndex = 34;
            this.lbHinta.Text = "Hinta";
            // 
            // lbMoottorinTilavuus
            // 
            this.lbMoottorinTilavuus.AutoSize = true;
            this.lbMoottorinTilavuus.Location = new System.Drawing.Point(544, 39);
            this.lbMoottorinTilavuus.Name = "lbMoottorinTilavuus";
            this.lbMoottorinTilavuus.Size = new System.Drawing.Size(90, 13);
            this.lbMoottorinTilavuus.TabIndex = 33;
            this.lbMoottorinTilavuus.Text = "Moottorin tilavuus";
            // 
            // lbMittarilukema
            // 
            this.lbMittarilukema.AutoSize = true;
            this.lbMittarilukema.Location = new System.Drawing.Point(783, 41);
            this.lbMittarilukema.Name = "lbMittarilukema";
            this.lbMittarilukema.Size = new System.Drawing.Size(69, 13);
            this.lbMittarilukema.TabIndex = 32;
            this.lbMittarilukema.Text = "Mittarilukema";
            // 
            // btnSeuraava
            // 
            this.btnSeuraava.Location = new System.Drawing.Point(414, 150);
            this.btnSeuraava.Name = "btnSeuraava";
            this.btnSeuraava.Size = new System.Drawing.Size(75, 23);
            this.btnSeuraava.TabIndex = 31;
            this.btnSeuraava.Text = "Seuraava";
            this.btnSeuraava.UseVisualStyleBackColor = true;
            this.btnSeuraava.Click += new System.EventHandler(this.btnSeuraava_Click);
            // 
            // btnEdellinen
            // 
            this.btnEdellinen.Location = new System.Drawing.Point(312, 150);
            this.btnEdellinen.Name = "btnEdellinen";
            this.btnEdellinen.Size = new System.Drawing.Size(75, 23);
            this.btnEdellinen.TabIndex = 30;
            this.btnEdellinen.Text = "Edellinen";
            this.btnEdellinen.UseVisualStyleBackColor = true;
            this.btnEdellinen.Click += new System.EventHandler(this.btnEdellinen_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(207, 150);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 29;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(109, 150);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(75, 23);
            this.btnTallenna.TabIndex = 28;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // btnUusiTietue
            // 
            this.btnUusiTietue.Location = new System.Drawing.Point(12, 150);
            this.btnUusiTietue.Name = "btnUusiTietue";
            this.btnUusiTietue.Size = new System.Drawing.Size(75, 23);
            this.btnUusiTietue.TabIndex = 27;
            this.btnUusiTietue.Text = "Uusi tietue";
            this.btnUusiTietue.UseVisualStyleBackColor = true;
            this.btnUusiTietue.Click += new System.EventHandler(this.btnUusiTietue_Click);
            // 
            // cbMalli
            // 
            this.cbMalli.FormattingEnabled = true;
            this.cbMalli.Location = new System.Drawing.Point(144, 57);
            this.cbMalli.Name = "cbMalli";
            this.cbMalli.Size = new System.Drawing.Size(121, 21);
            this.cbMalli.TabIndex = 26;
            // 
            // cbMerkki
            // 
            this.cbMerkki.FormattingEnabled = true;
            this.cbMerkki.Location = new System.Drawing.Point(15, 57);
            this.cbMerkki.Name = "cbMerkki";
            this.cbMerkki.Size = new System.Drawing.Size(121, 21);
            this.cbMerkki.TabIndex = 25;
            this.cbMerkki.SelectedValueChanged += new System.EventHandler(this.LisaaMallit);
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(669, 57);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(100, 20);
            this.tbHinta.TabIndex = 24;
            // 
            // tbMoottorinTilavuus
            // 
            this.tbMoottorinTilavuus.Location = new System.Drawing.Point(547, 57);
            this.tbMoottorinTilavuus.Name = "tbMoottorinTilavuus";
            this.tbMoottorinTilavuus.Size = new System.Drawing.Size(100, 20);
            this.tbMoottorinTilavuus.TabIndex = 23;
            // 
            // tbMittarilukema
            // 
            this.tbMittarilukema.Location = new System.Drawing.Point(786, 57);
            this.tbMittarilukema.Name = "tbMittarilukema";
            this.tbMittarilukema.Size = new System.Drawing.Size(100, 20);
            this.tbMittarilukema.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            this.testaaTietokantayhteyttäToolStripMenuItem.Click += new System.EventHandler(this.testaaTietokantayhteyttäToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Rekisteri päivämäärä";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpRekisteriPVM);
            this.Controls.Add(this.lbVari);
            this.Controls.Add(this.cbVari);
            this.Controls.Add(this.lbPolttoaine);
            this.Controls.Add(this.cbPolttoaine);
            this.Controls.Add(this.lbMalli);
            this.Controls.Add(this.lbMerkki);
            this.Controls.Add(this.lbHinta);
            this.Controls.Add(this.lbMoottorinTilavuus);
            this.Controls.Add(this.lbMittarilukema);
            this.Controls.Add(this.btnSeuraava);
            this.Controls.Add(this.btnEdellinen);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.btnUusiTietue);
            this.Controls.Add(this.cbMalli);
            this.Controls.Add(this.cbMerkki);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.tbMoottorinTilavuus);
            this.Controls.Add(this.tbMittarilukema);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpRekisteriPVM;
        private System.Windows.Forms.Label lbVari;
        private System.Windows.Forms.ComboBox cbVari;
        private System.Windows.Forms.Label lbPolttoaine;
        private System.Windows.Forms.ComboBox cbPolttoaine;
        private System.Windows.Forms.Label lbMalli;
        private System.Windows.Forms.Label lbMerkki;
        private System.Windows.Forms.Label lbHinta;
        private System.Windows.Forms.Label lbMoottorinTilavuus;
        private System.Windows.Forms.Label lbMittarilukema;
        private System.Windows.Forms.Button btnSeuraava;
        private System.Windows.Forms.Button btnEdellinen;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Button btnUusiTietue;
        private System.Windows.Forms.ComboBox cbMalli;
        private System.Windows.Forms.ComboBox cbMerkki;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbMoottorinTilavuus;
        private System.Windows.Forms.TextBox tbMittarilukema;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

