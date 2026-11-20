namespace electro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            left = new ListBox();
            right = new ListBox();
            SuspendLayout();
            // 
            // left
            // 
            left.FormattingEnabled = true;
            left.Location = new Point(99, 89);
            left.Name = "left";
            left.Size = new Size(380, 349);
            left.TabIndex = 0;
            left.SelectedIndexChanged += left_SelectedIndexChanged;
            // 
            // right
            // 
            right.FormattingEnabled = true;
            right.Location = new Point(676, 89);
            right.Name = "right";
            right.Size = new Size(380, 349);
            right.TabIndex = 1;
            right.SelectedIndexChanged += right_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 711);
            Controls.Add(right);
            Controls.Add(left);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox left;
        private ListBox right;
    }
}
