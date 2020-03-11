namespace SelfAnki
{
    partial class MainMenu
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
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Rename = new System.Windows.Forms.Button();
            this.new_name = new System.Windows.Forms.TextBox();
            this.listOfThems = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.rename_box = new System.Windows.Forms.TextBox();
            this.ToCards = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(220, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Thems";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(544, 91);
            this.Add.Margin = new System.Windows.Forms.Padding(0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(127, 46);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add new";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(13, 91);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(126, 59);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete Selected";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Rename
            // 
            this.Rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rename.Location = new System.Drawing.Point(12, 166);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(126, 47);
            this.Rename.TabIndex = 4;
            this.Rename.Text = "Rename";
            this.Rename.UseVisualStyleBackColor = true;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // new_name
            // 
            this.new_name.Location = new System.Drawing.Point(507, 193);
            this.new_name.Name = "new_name";
            this.new_name.Size = new System.Drawing.Size(196, 20);
            this.new_name.TabIndex = 5;
            // 
            // listOfThems
            // 
            this.listOfThems.HideSelection = false;
            this.listOfThems.Location = new System.Drawing.Point(206, 91);
            this.listOfThems.Name = "listOfThems";
            this.listOfThems.Size = new System.Drawing.Size(280, 302);
            this.listOfThems.TabIndex = 6;
            this.listOfThems.UseCompatibleStateImageBehavior = false;
            this.listOfThems.View = System.Windows.Forms.View.List;
            this.listOfThems.SelectedIndexChanged += new System.EventHandler(this.listOfThems_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selected";
            // 
            // rename_box
            // 
            this.rename_box.Location = new System.Drawing.Point(12, 261);
            this.rename_box.Name = "rename_box";
            this.rename_box.Size = new System.Drawing.Size(126, 20);
            this.rename_box.TabIndex = 8;
            // 
            // ToCards
            // 
            this.ToCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToCards.Location = new System.Drawing.Point(544, 352);
            this.ToCards.Name = "ToCards";
            this.ToCards.Size = new System.Drawing.Size(127, 48);
            this.ToCards.TabIndex = 9;
            this.ToCards.Text = "ToCards";
            this.ToCards.UseVisualStyleBackColor = true;
            this.ToCards.Click += new System.EventHandler(this.button1_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(240)))), ((int)(((byte)(160)))));
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(13, 352);
            this.Save.Margin = new System.Windows.Forms.Padding(0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(127, 48);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(559, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(715, 439);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ToCards);
            this.Controls.Add(this.rename_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listOfThems);
            this.Controls.Add(this.new_name);
            this.Controls.Add(this.Rename);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Rename;
        private System.Windows.Forms.TextBox new_name;
        private System.Windows.Forms.ListView listOfThems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rename_box;
        private System.Windows.Forms.Button ToCards;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label3;
    }
}