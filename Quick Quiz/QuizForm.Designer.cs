namespace Quick_Quiz
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.buttonBack = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.checkQuestion1 = new System.Windows.Forms.CheckBox();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.labelAnswer3 = new System.Windows.Forms.Label();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.labelQuestionNumber = new System.Windows.Forms.Label();
            this.labelAnswer4 = new System.Windows.Forms.Label();
            this.checkQuestion2 = new System.Windows.Forms.CheckBox();
            this.checkQuestion4 = new System.Windows.Forms.CheckBox();
            this.checkQuestion3 = new System.Windows.Forms.CheckBox();
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBack.Enabled = false;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(85, 438);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 51);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Previous";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.ForeColor = System.Drawing.Color.White;
            this.ButtonNext.Location = new System.Drawing.Point(607, 438);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(121, 51);
            this.ButtonNext.TabIndex = 1;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // checkQuestion1
            // 
            this.checkQuestion1.AutoSize = true;
            this.checkQuestion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkQuestion1.Location = new System.Drawing.Point(661, 180);
            this.checkQuestion1.Name = "checkQuestion1";
            this.checkQuestion1.Size = new System.Drawing.Size(15, 14);
            this.checkQuestion1.TabIndex = 2;
            this.checkQuestion1.UseVisualStyleBackColor = true;
            this.checkQuestion1.Click += new System.EventHandler(this.checkQuestion1_Click);
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.AutoSize = true;
            this.labelAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer1.Location = new System.Drawing.Point(96, 174);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(71, 20);
            this.labelAnswer1.TabIndex = 6;
            this.labelAnswer1.Text = "Answer1";
            // 
            // labelAnswer3
            // 
            this.labelAnswer3.AutoSize = true;
            this.labelAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer3.Location = new System.Drawing.Point(96, 293);
            this.labelAnswer3.Name = "labelAnswer3";
            this.labelAnswer3.Size = new System.Drawing.Size(75, 20);
            this.labelAnswer3.TabIndex = 7;
            this.labelAnswer3.Text = "Answer 3";
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.AutoSize = true;
            this.labelAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer2.Location = new System.Drawing.Point(96, 237);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(75, 20);
            this.labelAnswer2.TabIndex = 8;
            this.labelAnswer2.Text = "Answer 2";
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.AutoSize = true;
            this.labelQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionNumber.Location = new System.Drawing.Point(79, 24);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(225, 33);
            this.labelQuestionNumber.TabIndex = 9;
            this.labelQuestionNumber.Text = "Quesion X of Y";
            this.labelQuestionNumber.Click += new System.EventHandler(this.labelQuestionNumber_Click);
            // 
            // labelAnswer4
            // 
            this.labelAnswer4.AutoSize = true;
            this.labelAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer4.Location = new System.Drawing.Point(96, 356);
            this.labelAnswer4.Name = "labelAnswer4";
            this.labelAnswer4.Size = new System.Drawing.Size(75, 20);
            this.labelAnswer4.TabIndex = 10;
            this.labelAnswer4.Text = "Answer 4";
            // 
            // checkQuestion2
            // 
            this.checkQuestion2.AutoSize = true;
            this.checkQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkQuestion2.Location = new System.Drawing.Point(661, 243);
            this.checkQuestion2.Name = "checkQuestion2";
            this.checkQuestion2.Size = new System.Drawing.Size(15, 14);
            this.checkQuestion2.TabIndex = 11;
            this.checkQuestion2.UseVisualStyleBackColor = true;
            this.checkQuestion2.Click += new System.EventHandler(this.checkQuestion2_Click);
            // 
            // checkQuestion4
            // 
            this.checkQuestion4.AutoSize = true;
            this.checkQuestion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkQuestion4.Location = new System.Drawing.Point(661, 360);
            this.checkQuestion4.Name = "checkQuestion4";
            this.checkQuestion4.Size = new System.Drawing.Size(15, 14);
            this.checkQuestion4.TabIndex = 12;
            this.checkQuestion4.UseVisualStyleBackColor = true;
            this.checkQuestion4.Click += new System.EventHandler(this.checkQuestion4_Click);
            // 
            // checkQuestion3
            // 
            this.checkQuestion3.AutoSize = true;
            this.checkQuestion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkQuestion3.Location = new System.Drawing.Point(661, 299);
            this.checkQuestion3.Name = "checkQuestion3";
            this.checkQuestion3.Size = new System.Drawing.Size(15, 14);
            this.checkQuestion3.TabIndex = 13;
            this.checkQuestion3.UseVisualStyleBackColor = true;
            this.checkQuestion3.Click += new System.EventHandler(this.checkQuestion3_Click);
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionText.Location = new System.Drawing.Point(85, 71);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(86, 24);
            this.labelQuestionText.TabIndex = 14;
            this.labelQuestionText.Text = "Question";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(773, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelQuestionText);
            this.Controls.Add(this.checkQuestion3);
            this.Controls.Add(this.checkQuestion4);
            this.Controls.Add(this.checkQuestion2);
            this.Controls.Add(this.labelAnswer4);
            this.Controls.Add(this.labelQuestionNumber);
            this.Controls.Add(this.labelAnswer2);
            this.Controls.Add(this.labelAnswer3);
            this.Controls.Add(this.labelAnswer1);
            this.Controls.Add(this.checkQuestion1);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.CheckBox checkQuestion1;
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.Label labelAnswer3;
        private System.Windows.Forms.Label labelAnswer2;
        private System.Windows.Forms.Label labelQuestionNumber;
        private System.Windows.Forms.Label labelAnswer4;
        private System.Windows.Forms.CheckBox checkQuestion2;
        private System.Windows.Forms.CheckBox checkQuestion4;
        private System.Windows.Forms.CheckBox checkQuestion3;
        private System.Windows.Forms.Label labelQuestionText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}