namespace cg_lab1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.erase = new System.Windows.Forms.Button();
            this.define = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_reload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combobox_filters = new System.Windows.Forms.ComboBox();
            this.pictureBox_input = new System.Windows.Forms.PictureBox();
            this.pictureBox_output = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.erase);
            this.panel3.Controls.Add(this.define);
            this.panel3.Controls.Add(this.button_reset);
            this.panel3.Controls.Add(this.button_reload);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.combobox_filters);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(473, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 290);
            this.panel3.TabIndex = 3;
            // 
            // erase
            // 
            this.erase.Location = new System.Drawing.Point(6, 228);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(75, 23);
            this.erase.TabIndex = 5;
            this.erase.Text = "Erase";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // define
            // 
            this.define.Location = new System.Drawing.Point(5, 257);
            this.define.Name = "define";
            this.define.Size = new System.Drawing.Size(119, 25);
            this.define.TabIndex = 4;
            this.define.Text = "Define your own filter";
            this.define.UseVisualStyleBackColor = true;
            this.define.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(6, 199);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 3;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_reload
            // 
            this.button_reload.Location = new System.Drawing.Point(6, 169);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(75, 23);
            this.button_reload.TabIndex = 2;
            this.button_reload.Text = "Reload";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose filter:";
            // 
            // combobox_filters
            // 
            this.combobox_filters.FormattingEnabled = true;
            this.combobox_filters.Items.AddRange(new object[] {
            "inversion",
            "brightness correction",
            "contrast enhancement",
            "blur",
            "gaussian smoothing",
            "sharpen",
            "edge detection",
            "emboss",
            "custom"});
            this.combobox_filters.Location = new System.Drawing.Point(6, 34);
            this.combobox_filters.Name = "combobox_filters";
            this.combobox_filters.Size = new System.Drawing.Size(118, 21);
            this.combobox_filters.TabIndex = 0;
            this.combobox_filters.Text = "Choose...";
            this.combobox_filters.SelectedIndexChanged += new System.EventHandler(this.combobox_filters_SelectedIndexChanged);
            // 
            // pictureBox_input
            // 
            this.pictureBox_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_input.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_input.Name = "pictureBox_input";
            this.pictureBox_input.Size = new System.Drawing.Size(229, 290);
            this.pictureBox_input.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_input.TabIndex = 4;
            this.pictureBox_input.TabStop = false;
            // 
            // pictureBox_output
            // 
            this.pictureBox_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_output.Location = new System.Drawing.Point(238, 3);
            this.pictureBox_output.Name = "pictureBox_output";
            this.pictureBox_output.Size = new System.Drawing.Size(229, 290);
            this.pictureBox_output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_output.TabIndex = 5;
            this.pictureBox_output.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_input, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_output, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(618, 296);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 320);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox combobox_filters;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button define;
        private System.Windows.Forms.PictureBox pictureBox_input;
        private System.Windows.Forms.PictureBox pictureBox_output;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button erase;

    }
}

