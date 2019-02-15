namespace GuessingGameTemplate4U
{
    partial class resultsScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.guessesOutput = new System.Windows.Forms.Label();
            this.unsortedOutput = new System.Windows.Forms.Label();
            this.sortedOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(142, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(116, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "You Won";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.ForeColor = System.Drawing.Color.White;
            this.resultsLabel.Location = new System.Drawing.Point(35, 93);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(55, 17);
            this.resultsLabel.TabIndex = 1;
            this.resultsLabel.Text = "Results";
            // 
            // guessesOutput
            // 
            this.guessesOutput.ForeColor = System.Drawing.Color.White;
            this.guessesOutput.Location = new System.Drawing.Point(38, 135);
            this.guessesOutput.Name = "guessesOutput";
            this.guessesOutput.Size = new System.Drawing.Size(307, 23);
            this.guessesOutput.TabIndex = 2;
            // 
            // unsortedOutput
            // 
            this.unsortedOutput.ForeColor = System.Drawing.Color.White;
            this.unsortedOutput.Location = new System.Drawing.Point(38, 211);
            this.unsortedOutput.Name = "unsortedOutput";
            this.unsortedOutput.Size = new System.Drawing.Size(307, 23);
            this.unsortedOutput.TabIndex = 3;
            // 
            // sortedOutput
            // 
            this.sortedOutput.ForeColor = System.Drawing.Color.White;
            this.sortedOutput.Location = new System.Drawing.Point(38, 293);
            this.sortedOutput.Name = "sortedOutput";
            this.sortedOutput.Size = new System.Drawing.Size(307, 23);
            this.sortedOutput.TabIndex = 4;
            // 
            // resultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.sortedOutput);
            this.Controls.Add(this.unsortedOutput);
            this.Controls.Add(this.guessesOutput);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "resultsScreen";
            this.Size = new System.Drawing.Size(404, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label guessesOutput;
        private System.Windows.Forms.Label unsortedOutput;
        private System.Windows.Forms.Label sortedOutput;
    }
}
