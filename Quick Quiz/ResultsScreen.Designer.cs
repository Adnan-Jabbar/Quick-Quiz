namespace Quick_Quiz
{
    partial class ResultsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsScreen));
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelCorrectly = new System.Windows.Forms.Label();
            this.labelIncorrectly = new System.Windows.Forms.Label();
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalA = new System.Windows.Forms.Label();
            this.labelCorrectA = new System.Windows.Forms.Label();
            this.labelIncorrect = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFinish
            // 
            this.buttonFinish.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinish.ForeColor = System.Drawing.Color.White;
            this.buttonFinish.Location = new System.Drawing.Point(378, 326);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(136, 59);
            this.buttonFinish.TabIndex = 0;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = false;
            this.buttonFinish.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCorrectly
            // 
            this.labelCorrectly.AutoSize = true;
            this.labelCorrectly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectly.Location = new System.Drawing.Point(160, 163);
            this.labelCorrectly.Name = "labelCorrectly";
            this.labelCorrectly.Size = new System.Drawing.Size(226, 20);
            this.labelCorrectly.TabIndex = 1;
            this.labelCorrectly.Text = "Questions Answered Correctly:";
            // 
            // labelIncorrectly
            // 
            this.labelIncorrectly.AutoSize = true;
            this.labelIncorrectly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrectly.Location = new System.Drawing.Point(149, 213);
            this.labelIncorrectly.Name = "labelIncorrectly";
            this.labelIncorrectly.Size = new System.Drawing.Size(237, 20);
            this.labelIncorrectly.TabIndex = 2;
            this.labelIncorrectly.Text = "Questions Answered Incorrectly:";
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.Location = new System.Drawing.Point(327, 258);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(59, 20);
            this.labelSummary.TabIndex = 3;
            this.labelSummary.Text = "Score: ";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(187, 111);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(199, 20);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total Questions Answered:";
            // 
            // labelTotalA
            // 
            this.labelTotalA.AutoSize = true;
            this.labelTotalA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalA.ForeColor = System.Drawing.Color.Black;
            this.labelTotalA.Location = new System.Drawing.Point(515, 111);
            this.labelTotalA.Name = "labelTotalA";
            this.labelTotalA.Size = new System.Drawing.Size(44, 20);
            this.labelTotalA.TabIndex = 5;
            this.labelTotalA.Text = "Total";
            // 
            // labelCorrectA
            // 
            this.labelCorrectA.AutoSize = true;
            this.labelCorrectA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectA.ForeColor = System.Drawing.Color.Green;
            this.labelCorrectA.Location = new System.Drawing.Point(515, 163);
            this.labelCorrectA.Name = "labelCorrectA";
            this.labelCorrectA.Size = new System.Drawing.Size(61, 20);
            this.labelCorrectA.TabIndex = 6;
            this.labelCorrectA.Text = "Correct";
            // 
            // labelIncorrect
            // 
            this.labelIncorrect.AutoSize = true;
            this.labelIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrect.ForeColor = System.Drawing.Color.Crimson;
            this.labelIncorrect.Location = new System.Drawing.Point(515, 213);
            this.labelIncorrect.Name = "labelIncorrect";
            this.labelIncorrect.Size = new System.Drawing.Size(72, 20);
            this.labelIncorrect.TabIndex = 7;
            this.labelIncorrect.Text = "Incorrect";
            this.labelIncorrect.Click += new System.EventHandler(this.labelIncorrect_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Black;
            this.labelScore.Location = new System.Drawing.Point(515, 258);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(51, 20);
            this.labelScore.TabIndex = 8;
            this.labelScore.Text = "Score";
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 492);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelIncorrect);
            this.Controls.Add(this.labelCorrectA);
            this.Controls.Add(this.labelTotalA);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.labelIncorrectly);
            this.Controls.Add(this.labelCorrectly);
            this.Controls.Add(this.buttonFinish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.ResultsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label labelCorrectly;
        private System.Windows.Forms.Label labelIncorrectly;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalA;
        private System.Windows.Forms.Label labelCorrectA;
        private System.Windows.Forms.Label labelIncorrect;
        private System.Windows.Forms.Label labelScore;
    }
}