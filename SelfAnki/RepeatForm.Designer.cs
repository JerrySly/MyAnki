namespace SelfAnki
{
    partial class RepeatForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Quest = new System.Windows.Forms.RichTextBox();
            this.Answer = new System.Windows.Forms.RichTextBox();
            this.Bad = new System.Windows.Forms.Button();
            this.Good = new System.Windows.Forms.Button();
            this.VeryGood = new System.Windows.Forms.Button();
            this.ShowAns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Quest
            // 
            this.Quest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quest.Location = new System.Drawing.Point(27, 54);
            this.Quest.Name = "Quest";
            this.Quest.ReadOnly = true;
            this.Quest.Size = new System.Drawing.Size(700, 78);
            this.Quest.TabIndex = 1;
            this.Quest.Text = "";
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer.Location = new System.Drawing.Point(27, 165);
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Size = new System.Drawing.Size(700, 220);
            this.Answer.TabIndex = 2;
            this.Answer.Text = "";
            // 
            // Bad
            // 
            this.Bad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bad.Location = new System.Drawing.Point(157, 402);
            this.Bad.Name = "Bad";
            this.Bad.Size = new System.Drawing.Size(114, 36);
            this.Bad.TabIndex = 3;
            this.Bad.Text = "Bad";
            this.Bad.UseVisualStyleBackColor = true;
            this.Bad.Click += new System.EventHandler(this.Bad_Click);
            // 
            // Good
            // 
            this.Good.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Good.Location = new System.Drawing.Point(316, 402);
            this.Good.Name = "Good";
            this.Good.Size = new System.Drawing.Size(114, 36);
            this.Good.TabIndex = 4;
            this.Good.Text = "Good";
            this.Good.UseVisualStyleBackColor = true;
            this.Good.Click += new System.EventHandler(this.Good_Click);
            // 
            // VeryGood
            // 
            this.VeryGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VeryGood.Location = new System.Drawing.Point(466, 402);
            this.VeryGood.Name = "VeryGood";
            this.VeryGood.Size = new System.Drawing.Size(114, 36);
            this.VeryGood.TabIndex = 5;
            this.VeryGood.Text = "Very Good";
            this.VeryGood.UseVisualStyleBackColor = true;
            this.VeryGood.Click += new System.EventHandler(this.VeryGood_Click);
            // 
            // ShowAns
            // 
            this.ShowAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAns.Location = new System.Drawing.Point(316, 402);
            this.ShowAns.Name = "ShowAns";
            this.ShowAns.Size = new System.Drawing.Size(114, 36);
            this.ShowAns.TabIndex = 6;
            this.ShowAns.Text = "Check";
            this.ShowAns.UseVisualStyleBackColor = true;
            this.ShowAns.Click += new System.EventHandler(this.ShowAns_Click);
            // 
            // RepeatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowAns);
            this.Controls.Add(this.VeryGood);
            this.Controls.Add(this.Good);
            this.Controls.Add(this.Bad);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Quest);
            this.Controls.Add(this.label1);
            this.Name = "RepeatForm";
            this.Text = "RepeatForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RepeatForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Quest;
        private System.Windows.Forms.RichTextBox Answer;
        private System.Windows.Forms.Button Bad;
        private System.Windows.Forms.Button Good;
        private System.Windows.Forms.Button VeryGood;
        private System.Windows.Forms.Button ShowAns;
    }
}