namespace IteratorPattern
{
    partial class ClientForm
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
            this.InorderListBox = new System.Windows.Forms.ListBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.InorderTraverseButton = new System.Windows.Forms.Button();
            this.InorderLabel = new System.Windows.Forms.Label();
            this.CreateTreeButton = new System.Windows.Forms.Button();
            this.InputTreeUpDown = new System.Windows.Forms.NumericUpDown();
            this.PreorderLabel = new System.Windows.Forms.Label();
            this.PreorderTraverseButton = new System.Windows.Forms.Button();
            this.PreorderListBox = new System.Windows.Forms.ListBox();
            this.PostorderLabel = new System.Windows.Forms.Label();
            this.PostorderTraversalButton = new System.Windows.Forms.Button();
            this.PostorderListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputTreeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // InorderListBox
            // 
            this.InorderListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InorderListBox.FormattingEnabled = true;
            this.InorderListBox.Location = new System.Drawing.Point(15, 94);
            this.InorderListBox.Name = "InorderListBox";
            this.InorderListBox.Size = new System.Drawing.Size(194, 212);
            this.InorderListBox.TabIndex = 3;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(12, 9);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(145, 13);
            this.InputLabel.TabIndex = 4;
            this.InputLabel.Text = "Input number of nodes in tree";
            // 
            // InorderTraverseButton
            // 
            this.InorderTraverseButton.Location = new System.Drawing.Point(131, 65);
            this.InorderTraverseButton.Name = "InorderTraverseButton";
            this.InorderTraverseButton.Size = new System.Drawing.Size(75, 23);
            this.InorderTraverseButton.TabIndex = 2;
            this.InorderTraverseButton.Text = "Traverse";
            this.InorderTraverseButton.UseVisualStyleBackColor = true;
            this.InorderTraverseButton.Click += new System.EventHandler(this.InorderTraverseButton_Click);
            // 
            // InorderLabel
            // 
            this.InorderLabel.AutoSize = true;
            this.InorderLabel.Location = new System.Drawing.Point(12, 70);
            this.InorderLabel.Name = "InorderLabel";
            this.InorderLabel.Size = new System.Drawing.Size(83, 13);
            this.InorderLabel.TabIndex = 5;
            this.InorderLabel.Text = "Inorder traversal";
            // 
            // CreateTreeButton
            // 
            this.CreateTreeButton.Location = new System.Drawing.Point(131, 23);
            this.CreateTreeButton.Name = "CreateTreeButton";
            this.CreateTreeButton.Size = new System.Drawing.Size(75, 23);
            this.CreateTreeButton.TabIndex = 1;
            this.CreateTreeButton.Text = "CreateTree";
            this.CreateTreeButton.UseVisualStyleBackColor = true;
            this.CreateTreeButton.Click += new System.EventHandler(this.CreateTreeButton_Click);
            // 
            // InputTreeUpDown
            // 
            this.InputTreeUpDown.Location = new System.Drawing.Point(12, 26);
            this.InputTreeUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.InputTreeUpDown.Name = "InputTreeUpDown";
            this.InputTreeUpDown.Size = new System.Drawing.Size(113, 20);
            this.InputTreeUpDown.TabIndex = 0;
            // 
            // PreorderLabel
            // 
            this.PreorderLabel.AutoSize = true;
            this.PreorderLabel.Location = new System.Drawing.Point(221, 70);
            this.PreorderLabel.Name = "PreorderLabel";
            this.PreorderLabel.Size = new System.Drawing.Size(90, 13);
            this.PreorderLabel.TabIndex = 8;
            this.PreorderLabel.Text = "Preorder traversal";
            // 
            // PreorderTraverseButton
            // 
            this.PreorderTraverseButton.Location = new System.Drawing.Point(340, 65);
            this.PreorderTraverseButton.Name = "PreorderTraverseButton";
            this.PreorderTraverseButton.Size = new System.Drawing.Size(75, 23);
            this.PreorderTraverseButton.TabIndex = 6;
            this.PreorderTraverseButton.Text = "Traverse";
            this.PreorderTraverseButton.UseVisualStyleBackColor = true;
            this.PreorderTraverseButton.Click += new System.EventHandler(this.PreorderTraverseButton_Click);
            // 
            // PreorderListBox
            // 
            this.PreorderListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PreorderListBox.FormattingEnabled = true;
            this.PreorderListBox.Location = new System.Drawing.Point(224, 94);
            this.PreorderListBox.Name = "PreorderListBox";
            this.PreorderListBox.Size = new System.Drawing.Size(194, 212);
            this.PreorderListBox.TabIndex = 7;
            // 
            // PostorderLabel
            // 
            this.PostorderLabel.AutoSize = true;
            this.PostorderLabel.Location = new System.Drawing.Point(430, 70);
            this.PostorderLabel.Name = "PostorderLabel";
            this.PostorderLabel.Size = new System.Drawing.Size(95, 13);
            this.PostorderLabel.TabIndex = 11;
            this.PostorderLabel.Text = "Postorder traversal";
            // 
            // PostorderTraversalButton
            // 
            this.PostorderTraversalButton.Location = new System.Drawing.Point(549, 65);
            this.PostorderTraversalButton.Name = "PostorderTraversalButton";
            this.PostorderTraversalButton.Size = new System.Drawing.Size(75, 23);
            this.PostorderTraversalButton.TabIndex = 9;
            this.PostorderTraversalButton.Text = "Traverse";
            this.PostorderTraversalButton.UseVisualStyleBackColor = true;
            this.PostorderTraversalButton.Click += new System.EventHandler(this.PostorderTraversalButton_Click);
            // 
            // PostorderListBox
            // 
            this.PostorderListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PostorderListBox.FormattingEnabled = true;
            this.PostorderListBox.Location = new System.Drawing.Point(433, 94);
            this.PostorderListBox.Name = "PostorderListBox";
            this.PostorderListBox.Size = new System.Drawing.Size(194, 212);
            this.PostorderListBox.TabIndex = 10;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 319);
            this.Controls.Add(this.PostorderLabel);
            this.Controls.Add(this.PostorderTraversalButton);
            this.Controls.Add(this.PostorderListBox);
            this.Controls.Add(this.PreorderLabel);
            this.Controls.Add(this.PreorderTraverseButton);
            this.Controls.Add(this.PreorderListBox);
            this.Controls.Add(this.InputTreeUpDown);
            this.Controls.Add(this.CreateTreeButton);
            this.Controls.Add(this.InorderLabel);
            this.Controls.Add(this.InorderTraverseButton);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InorderListBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(652, 1000);
            this.MinimumSize = new System.Drawing.Size(652, 358);
            this.Name = "ClientForm";
            this.ShowIcon = false;
            this.Text = "Iterator Pattern";
            ((System.ComponentModel.ISupportInitialize)(this.InputTreeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InorderListBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Button InorderTraverseButton;
        private System.Windows.Forms.Label InorderLabel;
        private System.Windows.Forms.Button CreateTreeButton;
        private System.Windows.Forms.NumericUpDown InputTreeUpDown;
        private System.Windows.Forms.Label PreorderLabel;
        private System.Windows.Forms.Button PreorderTraverseButton;
        private System.Windows.Forms.ListBox PreorderListBox;
        private System.Windows.Forms.Label PostorderLabel;
        private System.Windows.Forms.Button PostorderTraversalButton;
        private System.Windows.Forms.ListBox PostorderListBox;
    }
}

