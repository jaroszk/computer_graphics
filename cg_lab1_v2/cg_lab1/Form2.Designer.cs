namespace cg_lab1
{
    partial class Form2
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
            this.width = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.txt_offset = new System.Windows.Forms.Label();
            this.txt_divisor = new System.Windows.Forms.Label();
            this.txt_anchor = new System.Windows.Forms.Label();
            this.define = new System.Windows.Forms.Label();
            this.apply_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.textBox_offset = new System.Windows.Forms.TextBox();
            this.textBox_divisor = new System.Windows.Forms.TextBox();
            this.textBox_anchorX = new System.Windows.Forms.TextBox();
            this.textBox_anchorY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(25, 42);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(77, 13);
            this.width.TabIndex = 0;
            this.width.Text = "width of matrix:";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(25, 75);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(81, 13);
            this.height.TabIndex = 1;
            this.height.Text = "height of matrix:";
            this.height.Click += new System.EventHandler(this.height_Click);
            // 
            // txt_offset
            // 
            this.txt_offset.AutoSize = true;
            this.txt_offset.Location = new System.Drawing.Point(29, 105);
            this.txt_offset.Name = "txt_offset";
            this.txt_offset.Size = new System.Drawing.Size(36, 13);
            this.txt_offset.TabIndex = 2;
            this.txt_offset.Text = "offset:";
            // 
            // txt_divisor
            // 
            this.txt_divisor.AutoSize = true;
            this.txt_divisor.Location = new System.Drawing.Point(25, 134);
            this.txt_divisor.Name = "txt_divisor";
            this.txt_divisor.Size = new System.Drawing.Size(40, 13);
            this.txt_divisor.TabIndex = 3;
            this.txt_divisor.Text = "divisor:";
            // 
            // txt_anchor
            // 
            this.txt_anchor.AutoSize = true;
            this.txt_anchor.Location = new System.Drawing.Point(22, 161);
            this.txt_anchor.Name = "txt_anchor";
            this.txt_anchor.Size = new System.Drawing.Size(43, 13);
            this.txt_anchor.TabIndex = 4;
            this.txt_anchor.Text = "anchor:";
            // 
            // define
            // 
            this.define.AutoSize = true;
            this.define.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.define.Location = new System.Drawing.Point(122, 9);
            this.define.Name = "define";
            this.define.Size = new System.Drawing.Size(75, 16);
            this.define.TabIndex = 5;
            this.define.Text = "define filter:";
            // 
            // apply_button
            // 
            this.apply_button.Location = new System.Drawing.Point(113, 200);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(75, 23);
            this.apply_button.TabIndex = 6;
            this.apply_button.Text = "Apply";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(212, 200);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 7;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(113, 39);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(181, 20);
            this.textBox_width.TabIndex = 8;
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(113, 68);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(181, 20);
            this.textBox_height.TabIndex = 9;
            // 
            // textBox_offset
            // 
            this.textBox_offset.Location = new System.Drawing.Point(113, 98);
            this.textBox_offset.Name = "textBox_offset";
            this.textBox_offset.Size = new System.Drawing.Size(181, 20);
            this.textBox_offset.TabIndex = 10;
            // 
            // textBox_divisor
            // 
            this.textBox_divisor.Location = new System.Drawing.Point(113, 127);
            this.textBox_divisor.Name = "textBox_divisor";
            this.textBox_divisor.Size = new System.Drawing.Size(181, 20);
            this.textBox_divisor.TabIndex = 11;
            // 
            // textBox_anchorX
            // 
            this.textBox_anchorX.Location = new System.Drawing.Point(155, 158);
            this.textBox_anchorX.Name = "textBox_anchorX";
            this.textBox_anchorX.Size = new System.Drawing.Size(28, 20);
            this.textBox_anchorX.TabIndex = 12;
            // 
            // textBox_anchorY
            // 
            this.textBox_anchorY.Location = new System.Drawing.Point(262, 159);
            this.textBox_anchorY.Name = "textBox_anchorY";
            this.textBox_anchorY.Size = new System.Drawing.Size(32, 20);
            this.textBox_anchorY.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "X coordinate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y coordinate";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_anchorY);
            this.Controls.Add(this.textBox_anchorX);
            this.Controls.Add(this.textBox_divisor);
            this.Controls.Add(this.textBox_offset);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.apply_button);
            this.Controls.Add(this.define);
            this.Controls.Add(this.txt_anchor);
            this.Controls.Add(this.txt_divisor);
            this.Controls.Add(this.txt_offset);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label txt_offset;
        private System.Windows.Forms.Label txt_divisor;
        private System.Windows.Forms.Label txt_anchor;
        private System.Windows.Forms.Label define;
        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.TextBox textBox_offset;
        private System.Windows.Forms.TextBox textBox_divisor;
        private System.Windows.Forms.TextBox textBox_anchorX;
        private System.Windows.Forms.TextBox textBox_anchorY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}