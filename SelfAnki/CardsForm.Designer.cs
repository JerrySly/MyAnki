namespace SelfAnki
{
    partial class CardsForm
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
            this.cards_list = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.question_card = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_card = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.days_card = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mark_card = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.answer_card = new System.Windows.Forms.RichTextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Repeat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cards_list
            // 
            this.cards_list.HideSelection = false;
            this.cards_list.Location = new System.Drawing.Point(13, 13);
            this.cards_list.Name = "cards_list";
            this.cards_list.Size = new System.Drawing.Size(284, 479);
            this.cards_list.TabIndex = 0;
            this.cards_list.UseCompatibleStateImageBehavior = false;
            this.cards_list.View = System.Windows.Forms.View.List;
            this.cards_list.SelectedIndexChanged += new System.EventHandler(this.cards_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(325, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // question_card
            // 
            this.question_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question_card.Location = new System.Drawing.Point(330, 122);
            this.question_card.Name = "question_card";
            this.question_card.Size = new System.Drawing.Size(458, 96);
            this.question_card.TabIndex = 2;
            this.question_card.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(325, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // name_card
            // 
            this.name_card.Location = new System.Drawing.Point(330, 50);
            this.name_card.Name = "name_card";
            this.name_card.Size = new System.Drawing.Size(458, 20);
            this.name_card.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(325, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Days to Repeat";
            // 
            // days_card
            // 
            this.days_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.days_card.Location = new System.Drawing.Point(378, 405);
            this.days_card.Name = "days_card";
            this.days_card.Size = new System.Drawing.Size(24, 23);
            this.days_card.TabIndex = 6;
            this.days_card.Text = "1";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(649, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Mark";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // mark_card
            // 
            this.mark_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mark_card.Location = new System.Drawing.Point(627, 405);
            this.mark_card.Name = "mark_card";
            this.mark_card.Size = new System.Drawing.Size(143, 23);
            this.mark_card.TabIndex = 8;
            this.mark_card.Text = "Good";
            this.mark_card.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mark_card.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(325, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Answer";
            // 
            // answer_card
            // 
            this.answer_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_card.Location = new System.Drawing.Point(330, 265);
            this.answer_card.Name = "answer_card";
            this.answer_card.Size = new System.Drawing.Size(458, 96);
            this.answer_card.TabIndex = 10;
            this.answer_card.Text = "";
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refresh.Location = new System.Drawing.Point(654, 459);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(94, 45);
            this.Refresh.TabIndex = 11;
            this.Refresh.Text = "Save";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(542, 459);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 45);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(427, 459);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 45);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Repeat
            // 
            this.Repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Repeat.Location = new System.Drawing.Point(317, 459);
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(94, 45);
            this.Repeat.TabIndex = 14;
            this.Repeat.Text = "Repeat";
            this.Repeat.UseVisualStyleBackColor = true;
            this.Repeat.Click += new System.EventHandler(this.Repeat_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(502, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Repeat);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.answer_card);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mark_card);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.days_card);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_card);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.question_card);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cards_list);
            this.Name = "CardsForm";
            this.Text = "CardsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CardsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView cards_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox question_card;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_card;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label days_card;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mark_card;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox answer_card;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Repeat;
        private System.Windows.Forms.Button button1;
    }
}