namespace SharpAutoForm
{
    partial class SharpAutoForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BasePrice_label = new System.Windows.Forms.Label();
            this.AdditionalOptions_label = new System.Windows.Forms.Label();
            this.SubTotal_label = new System.Windows.Forms.Label();
            this.SalesTax_label = new System.Windows.Forms.Label();
            this.Total_label = new System.Windows.Forms.Label();
            this.TradeIn_label = new System.Windows.Forms.Label();
            this.AmountDue_label = new System.Windows.Forms.Label();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.BasePrice_textBox = new System.Windows.Forms.TextBox();
            this.AdditionalOptions_textBox = new System.Windows.Forms.TextBox();
            this.SalesTax_textBox = new System.Windows.Forms.TextBox();
            this.SubTotal_textBox = new System.Windows.Forms.TextBox();
            this.TradeIn_textBox = new System.Windows.Forms.TextBox();
            this.Total_textBox = new System.Windows.Forms.TextBox();
            this.AmountDue_textBox = new System.Windows.Forms.TextBox();
            this.AdditionalItems_groupBox = new System.Windows.Forms.GroupBox();
            this.ExteriorFinish_groupBox = new System.Windows.Forms.GroupBox();
            this.CustomizedDetailing_radioButton = new System.Windows.Forms.RadioButton();
            this.Pearlized_radioButton = new System.Windows.Forms.RadioButton();
            this.Standard_radioButton = new System.Windows.Forms.RadioButton();
            this.StereoSystem_checkBox = new System.Windows.Forms.CheckBox();
            this.LeatherInterior_checkBox = new System.Windows.Forms.CheckBox();
            this.ComputerNavigation_checkBox = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.AdditionalItems_groupBox.SuspendLayout();
            this.ExteriorFinish_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(758, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BasePrice_label
            // 
            this.BasePrice_label.AutoSize = true;
            this.BasePrice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BasePrice_label.Location = new System.Drawing.Point(86, 70);
            this.BasePrice_label.Name = "BasePrice_label";
            this.BasePrice_label.Size = new System.Drawing.Size(112, 25);
            this.BasePrice_label.TabIndex = 1;
            this.BasePrice_label.Text = "Base Price:";
            // 
            // AdditionalOptions_label
            // 
            this.AdditionalOptions_label.AutoSize = true;
            this.AdditionalOptions_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AdditionalOptions_label.Location = new System.Drawing.Point(21, 114);
            this.AdditionalOptions_label.Name = "AdditionalOptions_label";
            this.AdditionalOptions_label.Size = new System.Drawing.Size(177, 25);
            this.AdditionalOptions_label.TabIndex = 2;
            this.AdditionalOptions_label.Text = "Additional Options:";
            // 
            // SubTotal_label
            // 
            this.SubTotal_label.AutoSize = true;
            this.SubTotal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SubTotal_label.Location = new System.Drawing.Point(100, 160);
            this.SubTotal_label.Name = "SubTotal_label";
            this.SubTotal_label.Size = new System.Drawing.Size(98, 25);
            this.SubTotal_label.TabIndex = 3;
            this.SubTotal_label.Text = "SubTotal:";
            // 
            // SalesTax_label
            // 
            this.SalesTax_label.AutoSize = true;
            this.SalesTax_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SalesTax_label.Location = new System.Drawing.Point(32, 205);
            this.SalesTax_label.Name = "SalesTax_label";
            this.SalesTax_label.Size = new System.Drawing.Size(166, 25);
            this.SalesTax_label.TabIndex = 4;
            this.SalesTax_label.Text = "Sales Tax (13%):";
            // 
            // Total_label
            // 
            this.Total_label.AutoSize = true;
            this.Total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Total_label.Location = new System.Drawing.Point(136, 250);
            this.Total_label.Name = "Total_label";
            this.Total_label.Size = new System.Drawing.Size(62, 25);
            this.Total_label.TabIndex = 5;
            this.Total_label.Text = "Total:";
            // 
            // TradeIn_label
            // 
            this.TradeIn_label.AutoSize = true;
            this.TradeIn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TradeIn_label.Location = new System.Drawing.Point(10, 295);
            this.TradeIn_label.Name = "TradeIn_label";
            this.TradeIn_label.Size = new System.Drawing.Size(188, 25);
            this.TradeIn_label.TabIndex = 6;
            this.TradeIn_label.Text = "Trade-In Allowance:";
            // 
            // AmountDue_label
            // 
            this.AmountDue_label.AutoSize = true;
            this.AmountDue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AmountDue_label.Location = new System.Drawing.Point(71, 341);
            this.AmountDue_label.Name = "AmountDue_label";
            this.AmountDue_label.Size = new System.Drawing.Size(127, 25);
            this.AmountDue_label.TabIndex = 7;
            this.AmountDue_label.Text = "Amount Due:";
            // 
            // Calculate_button
            // 
            this.Calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Calculate_button.Location = new System.Drawing.Point(33, 440);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(103, 39);
            this.Calculate_button.TabIndex = 10;
            this.Calculate_button.Text = "Calculate";
            this.Calculate_button.UseVisualStyleBackColor = true;
            this.Calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Clear_button.Location = new System.Drawing.Point(329, 440);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(103, 39);
            this.Clear_button.TabIndex = 11;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Exit_button.Location = new System.Drawing.Point(628, 440);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(103, 39);
            this.Exit_button.TabIndex = 12;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // BasePrice_textBox
            // 
            this.BasePrice_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BasePrice_textBox.Location = new System.Drawing.Point(218, 71);
            this.BasePrice_textBox.Name = "BasePrice_textBox";
            this.BasePrice_textBox.Size = new System.Drawing.Size(214, 30);
            this.BasePrice_textBox.TabIndex = 8;
            this.BasePrice_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustDigits);
            // 
            // AdditionalOptions_textBox
            // 
            this.AdditionalOptions_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AdditionalOptions_textBox.Location = new System.Drawing.Point(218, 115);
            this.AdditionalOptions_textBox.Name = "AdditionalOptions_textBox";
            this.AdditionalOptions_textBox.ReadOnly = true;
            this.AdditionalOptions_textBox.Size = new System.Drawing.Size(214, 30);
            this.AdditionalOptions_textBox.TabIndex = 12;
            this.AdditionalOptions_textBox.TabStop = false;
            // 
            // SalesTax_textBox
            // 
            this.SalesTax_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SalesTax_textBox.Location = new System.Drawing.Point(218, 206);
            this.SalesTax_textBox.Name = "SalesTax_textBox";
            this.SalesTax_textBox.ReadOnly = true;
            this.SalesTax_textBox.Size = new System.Drawing.Size(214, 30);
            this.SalesTax_textBox.TabIndex = 14;
            this.SalesTax_textBox.TabStop = false;
            // 
            // SubTotal_textBox
            // 
            this.SubTotal_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SubTotal_textBox.Location = new System.Drawing.Point(218, 162);
            this.SubTotal_textBox.Name = "SubTotal_textBox";
            this.SubTotal_textBox.ReadOnly = true;
            this.SubTotal_textBox.Size = new System.Drawing.Size(214, 30);
            this.SubTotal_textBox.TabIndex = 13;
            this.SubTotal_textBox.TabStop = false;
            // 
            // TradeIn_textBox
            // 
            this.TradeIn_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TradeIn_textBox.Location = new System.Drawing.Point(218, 294);
            this.TradeIn_textBox.Name = "TradeIn_textBox";
            this.TradeIn_textBox.Size = new System.Drawing.Size(214, 30);
            this.TradeIn_textBox.TabIndex = 9;
            this.TradeIn_textBox.Text = "0";
            this.TradeIn_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustDigits);
            // 
            // Total_textBox
            // 
            this.Total_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Total_textBox.Location = new System.Drawing.Point(218, 250);
            this.Total_textBox.Name = "Total_textBox";
            this.Total_textBox.ReadOnly = true;
            this.Total_textBox.Size = new System.Drawing.Size(214, 30);
            this.Total_textBox.TabIndex = 15;
            this.Total_textBox.TabStop = false;
            // 
            // AmountDue_textBox
            // 
            this.AmountDue_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AmountDue_textBox.Location = new System.Drawing.Point(218, 341);
            this.AmountDue_textBox.Name = "AmountDue_textBox";
            this.AmountDue_textBox.ReadOnly = true;
            this.AmountDue_textBox.Size = new System.Drawing.Size(214, 30);
            this.AmountDue_textBox.TabIndex = 17;
            this.AmountDue_textBox.TabStop = false;
            // 
            // AdditionalItems_groupBox
            // 
            this.AdditionalItems_groupBox.Controls.Add(this.ComputerNavigation_checkBox);
            this.AdditionalItems_groupBox.Controls.Add(this.LeatherInterior_checkBox);
            this.AdditionalItems_groupBox.Controls.Add(this.StereoSystem_checkBox);
            this.AdditionalItems_groupBox.Location = new System.Drawing.Point(487, 70);
            this.AdditionalItems_groupBox.Name = "AdditionalItems_groupBox";
            this.AdditionalItems_groupBox.Size = new System.Drawing.Size(244, 160);
            this.AdditionalItems_groupBox.TabIndex = 18;
            this.AdditionalItems_groupBox.TabStop = false;
            this.AdditionalItems_groupBox.Text = "Additional Items";
            // 
            // ExteriorFinish_groupBox
            // 
            this.ExteriorFinish_groupBox.Controls.Add(this.CustomizedDetailing_radioButton);
            this.ExteriorFinish_groupBox.Controls.Add(this.Pearlized_radioButton);
            this.ExteriorFinish_groupBox.Controls.Add(this.Standard_radioButton);
            this.ExteriorFinish_groupBox.Location = new System.Drawing.Point(487, 250);
            this.ExteriorFinish_groupBox.Name = "ExteriorFinish_groupBox";
            this.ExteriorFinish_groupBox.Size = new System.Drawing.Size(244, 160);
            this.ExteriorFinish_groupBox.TabIndex = 19;
            this.ExteriorFinish_groupBox.TabStop = false;
            this.ExteriorFinish_groupBox.Text = "Exterior Finish";
            // 
            // CustomizedDetailing_radioButton
            // 
            this.CustomizedDetailing_radioButton.AutoSize = true;
            this.CustomizedDetailing_radioButton.Location = new System.Drawing.Point(16, 119);
            this.CustomizedDetailing_radioButton.Name = "CustomizedDetailing_radioButton";
            this.CustomizedDetailing_radioButton.Size = new System.Drawing.Size(184, 24);
            this.CustomizedDetailing_radioButton.TabIndex = 2;
            this.CustomizedDetailing_radioButton.Text = "Customized Detailing";
            this.CustomizedDetailing_radioButton.UseVisualStyleBackColor = true;
            // 
            // Pearlized_radioButton
            // 
            this.Pearlized_radioButton.AutoSize = true;
            this.Pearlized_radioButton.Location = new System.Drawing.Point(16, 77);
            this.Pearlized_radioButton.Name = "Pearlized_radioButton";
            this.Pearlized_radioButton.Size = new System.Drawing.Size(99, 24);
            this.Pearlized_radioButton.TabIndex = 1;
            this.Pearlized_radioButton.Text = "Pearlized";
            this.Pearlized_radioButton.UseVisualStyleBackColor = true;
            // 
            // Standard_radioButton
            // 
            this.Standard_radioButton.AutoSize = true;
            this.Standard_radioButton.Checked = true;
            this.Standard_radioButton.Location = new System.Drawing.Point(16, 35);
            this.Standard_radioButton.Name = "Standard_radioButton";
            this.Standard_radioButton.Size = new System.Drawing.Size(100, 24);
            this.Standard_radioButton.TabIndex = 0;
            this.Standard_radioButton.TabStop = true;
            this.Standard_radioButton.Text = "Standard";
            this.Standard_radioButton.UseVisualStyleBackColor = true;
            // 
            // StereoSystem_checkBox
            // 
            this.StereoSystem_checkBox.AutoSize = true;
            this.StereoSystem_checkBox.Location = new System.Drawing.Point(16, 34);
            this.StereoSystem_checkBox.Name = "StereoSystem_checkBox";
            this.StereoSystem_checkBox.Size = new System.Drawing.Size(140, 24);
            this.StereoSystem_checkBox.TabIndex = 0;
            this.StereoSystem_checkBox.Text = "Stereo System";
            this.StereoSystem_checkBox.UseVisualStyleBackColor = true;
            // 
            // LeatherInterior_checkBox
            // 
            this.LeatherInterior_checkBox.AutoSize = true;
            this.LeatherInterior_checkBox.Location = new System.Drawing.Point(16, 75);
            this.LeatherInterior_checkBox.Name = "LeatherInterior_checkBox";
            this.LeatherInterior_checkBox.Size = new System.Drawing.Size(144, 24);
            this.LeatherInterior_checkBox.TabIndex = 1;
            this.LeatherInterior_checkBox.Text = "Leather Interior";
            this.LeatherInterior_checkBox.UseVisualStyleBackColor = true;
            // 
            // ComputerNavigation_checkBox
            // 
            this.ComputerNavigation_checkBox.AutoSize = true;
            this.ComputerNavigation_checkBox.Location = new System.Drawing.Point(16, 116);
            this.ComputerNavigation_checkBox.Name = "ComputerNavigation_checkBox";
            this.ComputerNavigation_checkBox.Size = new System.Drawing.Size(183, 24);
            this.ComputerNavigation_checkBox.TabIndex = 2;
            this.ComputerNavigation_checkBox.Text = "Computer Navigation";
            this.ComputerNavigation_checkBox.UseVisualStyleBackColor = true;
            // 
            // SharpAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 502);
            this.Controls.Add(this.ExteriorFinish_groupBox);
            this.Controls.Add(this.AdditionalItems_groupBox);
            this.Controls.Add(this.AmountDue_textBox);
            this.Controls.Add(this.TradeIn_textBox);
            this.Controls.Add(this.Total_textBox);
            this.Controls.Add(this.SalesTax_textBox);
            this.Controls.Add(this.SubTotal_textBox);
            this.Controls.Add(this.AdditionalOptions_textBox);
            this.Controls.Add(this.BasePrice_textBox);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Calculate_button);
            this.Controls.Add(this.AmountDue_label);
            this.Controls.Add(this.TradeIn_label);
            this.Controls.Add(this.Total_label);
            this.Controls.Add(this.SalesTax_label);
            this.Controls.Add(this.SubTotal_label);
            this.Controls.Add(this.AdditionalOptions_label);
            this.Controls.Add(this.BasePrice_label);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 558);
            this.MinimumSize = new System.Drawing.Size(780, 558);
            this.Name = "SharpAutoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Auto Form";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.AdditionalItems_groupBox.ResumeLayout(false);
            this.AdditionalItems_groupBox.PerformLayout();
            this.ExteriorFinish_groupBox.ResumeLayout(false);
            this.ExteriorFinish_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label BasePrice_label;
        private System.Windows.Forms.Label AdditionalOptions_label;
        private System.Windows.Forms.Label SubTotal_label;
        private System.Windows.Forms.Label SalesTax_label;
        private System.Windows.Forms.Label Total_label;
        private System.Windows.Forms.Label TradeIn_label;
        private System.Windows.Forms.Label AmountDue_label;
        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.TextBox BasePrice_textBox;
        private System.Windows.Forms.TextBox AdditionalOptions_textBox;
        private System.Windows.Forms.TextBox SalesTax_textBox;
        private System.Windows.Forms.TextBox SubTotal_textBox;
        private System.Windows.Forms.TextBox TradeIn_textBox;
        private System.Windows.Forms.TextBox Total_textBox;
        private System.Windows.Forms.TextBox AmountDue_textBox;
        private System.Windows.Forms.GroupBox AdditionalItems_groupBox;
        private System.Windows.Forms.GroupBox ExteriorFinish_groupBox;
        private System.Windows.Forms.RadioButton CustomizedDetailing_radioButton;
        private System.Windows.Forms.RadioButton Pearlized_radioButton;
        private System.Windows.Forms.RadioButton Standard_radioButton;
        private System.Windows.Forms.CheckBox ComputerNavigation_checkBox;
        private System.Windows.Forms.CheckBox LeatherInterior_checkBox;
        private System.Windows.Forms.CheckBox StereoSystem_checkBox;
    }
}

