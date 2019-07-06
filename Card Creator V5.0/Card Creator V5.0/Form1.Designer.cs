namespace Card_Creator_V5._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbCard = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbTopLeft = new System.Windows.Forms.ComboBox();
            this.cbTopRight = new System.Windows.Forms.ComboBox();
            this.cbBottomLeft = new System.Windows.Forms.ComboBox();
            this.cbBottomRight = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.nudFood = new System.Windows.Forms.NumericUpDown();
            this.nudLumber = new System.Windows.Forms.NumericUpDown();
            this.nudMetal = new System.Windows.Forms.NumericUpDown();
            this.nudMagic = new System.Windows.Forms.NumericUpDown();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudAttack = new System.Windows.Forms.NumericUpDown();
            this.nudDefense = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCardType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefense)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCard
            // 
            this.pbCard.Image = ((System.Drawing.Image)(resources.GetObject("pbCard.Image")));
            this.pbCard.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCard.InitialImage")));
            this.pbCard.Location = new System.Drawing.Point(13, 13);
            this.pbCard.Name = "pbCard";
            this.pbCard.Size = new System.Drawing.Size(239, 335);
            this.pbCard.TabIndex = 0;
            this.pbCard.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(607, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(582, 333);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 20);
            this.txtFileName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "File Name";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(607, 239);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbTopLeft
            // 
            this.cbTopLeft.FormattingEnabled = true;
            this.cbTopLeft.Location = new System.Drawing.Point(318, 12);
            this.cbTopLeft.Name = "cbTopLeft";
            this.cbTopLeft.Size = new System.Drawing.Size(74, 21);
            this.cbTopLeft.TabIndex = 1;
            this.cbTopLeft.SelectedIndexChanged += new System.EventHandler(this.UpdateConnections);
            // 
            // cbTopRight
            // 
            this.cbTopRight.FormattingEnabled = true;
            this.cbTopRight.Location = new System.Drawing.Point(318, 39);
            this.cbTopRight.Name = "cbTopRight";
            this.cbTopRight.Size = new System.Drawing.Size(74, 21);
            this.cbTopRight.TabIndex = 3;
            this.cbTopRight.SelectedIndexChanged += new System.EventHandler(this.UpdateConnections);
            // 
            // cbBottomLeft
            // 
            this.cbBottomLeft.FormattingEnabled = true;
            this.cbBottomLeft.Location = new System.Drawing.Point(318, 66);
            this.cbBottomLeft.Name = "cbBottomLeft";
            this.cbBottomLeft.Size = new System.Drawing.Size(74, 21);
            this.cbBottomLeft.TabIndex = 5;
            this.cbBottomLeft.SelectedIndexChanged += new System.EventHandler(this.UpdateConnections);
            // 
            // cbBottomRight
            // 
            this.cbBottomRight.FormattingEnabled = true;
            this.cbBottomRight.Location = new System.Drawing.Point(318, 93);
            this.cbBottomRight.Name = "cbBottomRight";
            this.cbBottomRight.Size = new System.Drawing.Size(74, 21);
            this.cbBottomRight.TabIndex = 7;
            this.cbBottomRight.SelectedIndexChanged += new System.EventHandler(this.UpdateConnections);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "BL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "BR";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(439, 38);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(243, 178);
            this.rtbDescription.TabIndex = 21;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(439, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(243, 20);
            this.tbName.TabIndex = 20;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // nudFood
            // 
            this.nudFood.Location = new System.Drawing.Point(340, 120);
            this.nudFood.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudFood.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.nudFood.Name = "nudFood";
            this.nudFood.Size = new System.Drawing.Size(52, 20);
            this.nudFood.TabIndex = 9;
            this.nudFood.ValueChanged += new System.EventHandler(this.UpdateCosts);
            // 
            // nudLumber
            // 
            this.nudLumber.Location = new System.Drawing.Point(340, 146);
            this.nudLumber.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudLumber.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.nudLumber.Name = "nudLumber";
            this.nudLumber.Size = new System.Drawing.Size(52, 20);
            this.nudLumber.TabIndex = 11;
            this.nudLumber.ValueChanged += new System.EventHandler(this.UpdateCosts);
            // 
            // nudMetal
            // 
            this.nudMetal.Location = new System.Drawing.Point(340, 172);
            this.nudMetal.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudMetal.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.nudMetal.Name = "nudMetal";
            this.nudMetal.Size = new System.Drawing.Size(52, 20);
            this.nudMetal.TabIndex = 13;
            this.nudMetal.ValueChanged += new System.EventHandler(this.UpdateCosts);
            // 
            // nudMagic
            // 
            this.nudMagic.Location = new System.Drawing.Point(340, 198);
            this.nudMagic.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudMagic.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.nudMagic.Name = "nudMagic";
            this.nudMagic.Size = new System.Drawing.Size(52, 20);
            this.nudMagic.TabIndex = 15;
            this.nudMagic.ValueChanged += new System.EventHandler(this.UpdateCosts);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(607, 297);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 26;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Food";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lumber";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Metal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Magic";
            // 
            // nudAttack
            // 
            this.nudAttack.Location = new System.Drawing.Point(340, 225);
            this.nudAttack.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudAttack.Name = "nudAttack";
            this.nudAttack.Size = new System.Drawing.Size(52, 20);
            this.nudAttack.TabIndex = 17;
            this.nudAttack.ValueChanged += new System.EventHandler(this.UpdateCombatValues);
            // 
            // nudDefense
            // 
            this.nudDefense.Location = new System.Drawing.Point(340, 251);
            this.nudDefense.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudDefense.Name = "nudDefense";
            this.nudDefense.Size = new System.Drawing.Size(52, 20);
            this.nudDefense.TabIndex = 19;
            this.nudDefense.ValueChanged += new System.EventHandler(this.UpdateCombatValues);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Attack";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Armor";
            // 
            // txtCardType
            // 
            this.txtCardType.Location = new System.Drawing.Point(280, 287);
            this.txtCardType.Name = "txtCardType";
            this.txtCardType.Size = new System.Drawing.Size(112, 20);
            this.txtCardType.TabIndex = 27;
            this.txtCardType.TextChanged += new System.EventHandler(this.txtCardType_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 365);
            this.Controls.Add(this.txtCardType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudDefense);
            this.Controls.Add(this.nudAttack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.nudMagic);
            this.Controls.Add(this.nudMetal);
            this.Controls.Add(this.nudLumber);
            this.Controls.Add(this.nudFood);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBottomRight);
            this.Controls.Add(this.cbBottomLeft);
            this.Controls.Add(this.cbTopRight);
            this.Controls.Add(this.cbTopLeft);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbCard);
            this.Name = "Form1";
            this.Text = "Card Designer";
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbTopLeft;
        private System.Windows.Forms.ComboBox cbTopRight;
        private System.Windows.Forms.ComboBox cbBottomLeft;
        private System.Windows.Forms.ComboBox cbBottomRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown nudFood;
        private System.Windows.Forms.NumericUpDown nudLumber;
        private System.Windows.Forms.NumericUpDown nudMetal;
        private System.Windows.Forms.NumericUpDown nudMagic;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudAttack;
        private System.Windows.Forms.NumericUpDown nudDefense;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCardType;
    }
}

