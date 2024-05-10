namespace CafeApp
{
    partial class MainForm
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
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.headingLbl = new System.Windows.Forms.Label();
            this.AddItembtn = new System.Windows.Forms.Button();
            this.DisplayRecieptbtn = new System.Windows.Forms.Button();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.Quantitylbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Items.AddRange(new object[] {
            "Coffee",
            "Tea",
            "Sandwich",
            "Cake"});
            this.ItemComboBox.Location = new System.Drawing.Point(210, 156);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(344, 21);
            this.ItemComboBox.TabIndex = 0;
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // headingLbl
            // 
            this.headingLbl.AutoSize = true;
            this.headingLbl.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLbl.Location = new System.Drawing.Point(315, 25);
            this.headingLbl.Name = "headingLbl";
            this.headingLbl.Size = new System.Drawing.Size(131, 39);
            this.headingLbl.TabIndex = 1;
            this.headingLbl.Text = "Cafe App";
            this.headingLbl.Click += new System.EventHandler(this.headingLbl_Click);
            // 
            // AddItembtn
            // 
            this.AddItembtn.Location = new System.Drawing.Point(295, 285);
            this.AddItembtn.Name = "AddItembtn";
            this.AddItembtn.Size = new System.Drawing.Size(151, 29);
            this.AddItembtn.TabIndex = 2;
            this.AddItembtn.Text = "Add Item";
            this.AddItembtn.UseVisualStyleBackColor = true;
            this.AddItembtn.Click += new System.EventHandler(this.AddItembtn_Click);
            // 
            // DisplayRecieptbtn
            // 
            this.DisplayRecieptbtn.Location = new System.Drawing.Point(295, 361);
            this.DisplayRecieptbtn.Name = "DisplayRecieptbtn";
            this.DisplayRecieptbtn.Size = new System.Drawing.Size(151, 29);
            this.DisplayRecieptbtn.TabIndex = 3;
            this.DisplayRecieptbtn.Text = "Display Receipt";
            this.DisplayRecieptbtn.UseVisualStyleBackColor = true;
            this.DisplayRecieptbtn.Click += new System.EventHandler(this.DisplayRecieptbtn_Click);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(619, 294);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantity.TabIndex = 4;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            // 
            // Quantitylbl
            // 
            this.Quantitylbl.AutoSize = true;
            this.Quantitylbl.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitylbl.Location = new System.Drawing.Point(616, 274);
            this.Quantitylbl.Name = "Quantitylbl";
            this.Quantitylbl.Size = new System.Drawing.Size(130, 17);
            this.Quantitylbl.TabIndex = 5;
            this.Quantitylbl.Text = "Select the quantity";
            this.Quantitylbl.Click += new System.EventHandler(this.Quantitylbl_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quantitylbl);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.DisplayRecieptbtn);
            this.Controls.Add(this.AddItembtn);
            this.Controls.Add(this.headingLbl);
            this.Controls.Add(this.ItemComboBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.Label headingLbl;
        private System.Windows.Forms.Button AddItembtn;
        private System.Windows.Forms.Button DisplayRecieptbtn;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label Quantitylbl;
    }
}

