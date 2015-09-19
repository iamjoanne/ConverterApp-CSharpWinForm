namespace ConverterApp
{
    partial class ConverterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConverterForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEnterConvert = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.grpBxUnits = new System.Windows.Forms.GroupBox();
            this.rdBtnLbKg = new System.Windows.Forms.RadioButton();
            this.rdBtnKgLbs = new System.Windows.Forms.RadioButton();
            this.rdBtnFahrCel = new System.Windows.Forms.RadioButton();
            this.rdBtnCelFahr = new System.Windows.Forms.RadioButton();
            this.rdBtnKmphMph = new System.Windows.Forms.RadioButton();
            this.rdBtnMphKmph = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lnkLblToWebsite = new System.Windows.Forms.LinkLabel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkLblHow = new System.Windows.Forms.LinkLabel();
            this.grpBxUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(214, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Converter App";
            // 
            // lblEnterConvert
            // 
            this.lblEnterConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnterConvert.AutoSize = true;
            this.lblEnterConvert.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterConvert.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEnterConvert.Location = new System.Drawing.Point(194, 81);
            this.lblEnterConvert.Name = "lblEnterConvert";
            this.lblEnterConvert.Size = new System.Drawing.Size(106, 32);
            this.lblEnterConvert.TabIndex = 0;
            this.lblEnterConvert.Text = "Convert";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxInput.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.txtBoxInput.Location = new System.Drawing.Point(306, 79);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(214, 34);
            this.txtBoxInput.TabIndex = 0;
            // 
            // grpBxUnits
            // 
            this.grpBxUnits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBxUnits.Controls.Add(this.rdBtnMphKmph);
            this.grpBxUnits.Controls.Add(this.rdBtnKmphMph);
            this.grpBxUnits.Controls.Add(this.rdBtnCelFahr);
            this.grpBxUnits.Controls.Add(this.rdBtnFahrCel);
            this.grpBxUnits.Controls.Add(this.rdBtnKgLbs);
            this.grpBxUnits.Controls.Add(this.rdBtnLbKg);
            this.grpBxUnits.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxUnits.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.grpBxUnits.Location = new System.Drawing.Point(102, 120);
            this.grpBxUnits.Name = "grpBxUnits";
            this.grpBxUnits.Size = new System.Drawing.Size(510, 187);
            this.grpBxUnits.TabIndex = 0;
            this.grpBxUnits.TabStop = false;
            // 
            // rdBtnLbKg
            // 
            this.rdBtnLbKg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdBtnLbKg.AutoSize = true;
            this.rdBtnLbKg.Location = new System.Drawing.Point(7, 13);
            this.rdBtnLbKg.Name = "rdBtnLbKg";
            this.rdBtnLbKg.Size = new System.Drawing.Size(281, 27);
            this.rdBtnLbKg.TabIndex = 1;
            this.rdBtnLbKg.TabStop = true;
            this.rdBtnLbKg.Text = "Pounds (lbs) to Kilograms (kgs)";
            this.rdBtnLbKg.UseVisualStyleBackColor = true;
            // 
            // rdBtnKgLbs
            // 
            this.rdBtnKgLbs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdBtnKgLbs.AutoSize = true;
            this.rdBtnKgLbs.Location = new System.Drawing.Point(7, 41);
            this.rdBtnKgLbs.Name = "rdBtnKgLbs";
            this.rdBtnKgLbs.Size = new System.Drawing.Size(281, 27);
            this.rdBtnKgLbs.TabIndex = 2;
            this.rdBtnKgLbs.TabStop = true;
            this.rdBtnKgLbs.Text = "Kilograms (kgs) to Pounds (lbs)";
            this.rdBtnKgLbs.UseVisualStyleBackColor = true;
            // 
            // rdBtnFahrCel
            // 
            this.rdBtnFahrCel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdBtnFahrCel.AutoSize = true;
            this.rdBtnFahrCel.Location = new System.Drawing.Point(7, 69);
            this.rdBtnFahrCel.Name = "rdBtnFahrCel";
            this.rdBtnFahrCel.Size = new System.Drawing.Size(262, 27);
            this.rdBtnFahrCel.TabIndex = 3;
            this.rdBtnFahrCel.TabStop = true;
            this.rdBtnFahrCel.Text = "Fahrenheit (°F) to Celsius (°C)";
            this.rdBtnFahrCel.UseVisualStyleBackColor = true;
            // 
            // rdBtnCelFahr
            // 
            this.rdBtnCelFahr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdBtnCelFahr.AutoSize = true;
            this.rdBtnCelFahr.Location = new System.Drawing.Point(7, 97);
            this.rdBtnCelFahr.Name = "rdBtnCelFahr";
            this.rdBtnCelFahr.Size = new System.Drawing.Size(262, 27);
            this.rdBtnCelFahr.TabIndex = 4;
            this.rdBtnCelFahr.TabStop = true;
            this.rdBtnCelFahr.Text = "Celsius (°C) to Fahrenheit (°F)";
            this.rdBtnCelFahr.UseVisualStyleBackColor = true;
            // 
            // rdBtnKmphMph
            // 
            this.rdBtnKmphMph.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdBtnKmphMph.AutoSize = true;
            this.rdBtnKmphMph.Location = new System.Drawing.Point(7, 125);
            this.rdBtnKmphMph.Name = "rdBtnKmphMph";
            this.rdBtnKmphMph.Size = new System.Drawing.Size(449, 27);
            this.rdBtnKmphMph.TabIndex = 5;
            this.rdBtnKmphMph.TabStop = true;
            this.rdBtnKmphMph.Text = "Kilometers per hour (km/h) to Miles per hour (mph)";
            this.rdBtnKmphMph.UseVisualStyleBackColor = true;
            // 
            // rdBtnMphKmph
            // 
            this.rdBtnMphKmph.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdBtnMphKmph.AutoSize = true;
            this.rdBtnMphKmph.Location = new System.Drawing.Point(6, 152);
            this.rdBtnMphKmph.Name = "rdBtnMphKmph";
            this.rdBtnMphKmph.Size = new System.Drawing.Size(449, 27);
            this.rdBtnMphKmph.TabIndex = 0;
            this.rdBtnMphKmph.TabStop = true;
            this.rdBtnMphKmph.Text = "Miles per hour (mph) to Kilometers per hour (km/h)";
            this.rdBtnMphKmph.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConvert.AutoSize = true;
            this.btnConvert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(293, 325);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(129, 42);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lnkLblToWebsite
            // 
            this.lnkLblToWebsite.ActiveLinkColor = System.Drawing.Color.LightSeaGreen;
            this.lnkLblToWebsite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkLblToWebsite.AutoSize = true;
            this.lnkLblToWebsite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblToWebsite.LinkColor = System.Drawing.Color.MediumSpringGreen;
            this.lnkLblToWebsite.Location = new System.Drawing.Point(302, 503);
            this.lnkLblToWebsite.Name = "lnkLblToWebsite";
            this.lnkLblToWebsite.Size = new System.Drawing.Size(114, 20);
            this.lnkLblToWebsite.TabIndex = 2;
            this.lnkLblToWebsite.TabStop = true;
            this.lnkLblToWebsite.Text = "iamjoanne.info";
            this.lnkLblToWebsite.VisitedLinkColor = System.Drawing.Color.LightSeaGreen;
            this.lnkLblToWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblToWebsite_LinkClicked);
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOutput.BackColor = System.Drawing.Color.Black;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblOutput.Location = new System.Drawing.Point(102, 389);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(510, 55);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Calculated";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lnkLblHow
            // 
            this.lnkLblHow.ActiveLinkColor = System.Drawing.Color.MediumSpringGreen;
            this.lnkLblHow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkLblHow.AutoSize = true;
            this.lnkLblHow.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblHow.LinkColor = System.Drawing.Color.MediumSpringGreen;
            this.lnkLblHow.Location = new System.Drawing.Point(12, 9);
            this.lnkLblHow.Name = "lnkLblHow";
            this.lnkLblHow.Size = new System.Drawing.Size(44, 19);
            this.lnkLblHow.TabIndex = 5;
            this.lnkLblHow.TabStop = true;
            this.lnkLblHow.Text = "help?";
            this.lnkLblHow.VisitedLinkColor = System.Drawing.Color.MediumSpringGreen;
            this.lnkLblHow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblHow_LinkClicked);
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(714, 532);
            this.Controls.Add(this.lnkLblHow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lnkLblToWebsite);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.grpBxUnits);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.lblEnterConvert);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter App";
            this.grpBxUnits.ResumeLayout(false);
            this.grpBxUnits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEnterConvert;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.GroupBox grpBxUnits;
        private System.Windows.Forms.RadioButton rdBtnMphKmph;
        private System.Windows.Forms.RadioButton rdBtnKmphMph;
        private System.Windows.Forms.RadioButton rdBtnCelFahr;
        private System.Windows.Forms.RadioButton rdBtnFahrCel;
        private System.Windows.Forms.RadioButton rdBtnKgLbs;
        private System.Windows.Forms.RadioButton rdBtnLbKg;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.LinkLabel lnkLblToWebsite;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkLblHow;
    }
}

