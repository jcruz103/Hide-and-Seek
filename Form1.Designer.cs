namespace HouseGame
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
            this.description = new System.Windows.Forms.TextBox();
            this.goHere = new System.Windows.Forms.Button();
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.check = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.picHolder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(13, 13);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(326, 105);
            this.description.TabIndex = 0;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(13, 376);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(75, 23);
            this.goHere.TabIndex = 1;
            this.goHere.Text = "Go Here: ";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.Location = new System.Drawing.Point(13, 405);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(323, 23);
            this.goThroughTheDoor.TabIndex = 2;
            this.goThroughTheDoor.Text = "Go through the door";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // exits
            // 
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(95, 377);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(241, 21);
            this.exits.TabIndex = 3;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(13, 435);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(323, 23);
            this.check.TabIndex = 4;
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(13, 465);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(323, 23);
            this.hide.TabIndex = 5;
            this.hide.Text = "Hide!";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // picHolder
            // 
            this.picHolder.Image = global::HouseGame.Properties.Resources.Welcome;
            this.picHolder.Location = new System.Drawing.Point(13, 125);
            this.picHolder.Name = "picHolder";
            this.picHolder.Size = new System.Drawing.Size(326, 247);
            this.picHolder.TabIndex = 6;
            this.picHolder.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 500);
            this.Controls.Add(this.picHolder);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.check);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goThroughTheDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.description);
            this.Name = "Form1";
            this.Text = "Hide and Seek";
            ((System.ComponentModel.ISupportInitialize)(this.picHolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.Button goThroughTheDoor;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.PictureBox picHolder;

    }
}

