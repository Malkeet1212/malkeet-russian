namespace malkeet_russian
{
    partial class game
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
            this.gamescreen = new System.Windows.Forms.PictureBox();
            this.buttonload = new System.Windows.Forms.Button();
            this.buttonshootaway = new System.Windows.Forms.Button();
            this.buttonshoot = new System.Windows.Forms.Button();
            this.buttonspin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gamescreen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Russian Roullete";
            // 
            // gamescreen
            // 
            this.gamescreen.Location = new System.Drawing.Point(41, 92);
            this.gamescreen.Name = "gamescreen";
            this.gamescreen.Size = new System.Drawing.Size(620, 291);
            this.gamescreen.TabIndex = 1;
            this.gamescreen.TabStop = false;
            // 
            // buttonload
            // 
            this.buttonload.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonload.Location = new System.Drawing.Point(41, 422);
            this.buttonload.Name = "buttonload";
            this.buttonload.Size = new System.Drawing.Size(135, 51);
            this.buttonload.TabIndex = 2;
            this.buttonload.Text = "Load";
            this.buttonload.UseVisualStyleBackColor = true;
            this.buttonload.Click += new System.EventHandler(this.buttonload_Click);
            // 
            // buttonshootaway
            // 
            this.buttonshootaway.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshootaway.Location = new System.Drawing.Point(697, 300);
            this.buttonshootaway.Name = "buttonshootaway";
            this.buttonshootaway.Size = new System.Drawing.Size(135, 93);
            this.buttonshootaway.TabIndex = 3;
            this.buttonshootaway.Text = "Shoot Away";
            this.buttonshootaway.UseVisualStyleBackColor = true;
            this.buttonshootaway.Click += new System.EventHandler(this.buttonshootaway_Click);
            // 
            // buttonshoot
            // 
            this.buttonshoot.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshoot.Location = new System.Drawing.Point(697, 173);
            this.buttonshoot.Name = "buttonshoot";
            this.buttonshoot.Size = new System.Drawing.Size(135, 51);
            this.buttonshoot.TabIndex = 4;
            this.buttonshoot.Text = "Shoot";
            this.buttonshoot.UseVisualStyleBackColor = true;
            this.buttonshoot.Click += new System.EventHandler(this.buttonshoot_Click);
            // 
            // buttonspin
            // 
            this.buttonspin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonspin.Location = new System.Drawing.Point(384, 422);
            this.buttonspin.Name = "buttonspin";
            this.buttonspin.Size = new System.Drawing.Size(135, 51);
            this.buttonspin.TabIndex = 5;
            this.buttonspin.Text = "Spin";
            this.buttonspin.UseVisualStyleBackColor = true;
            this.buttonspin.Click += new System.EventHandler(this.buttonspin_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(606, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "play again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(844, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonspin);
            this.Controls.Add(this.buttonshoot);
            this.Controls.Add(this.buttonshootaway);
            this.Controls.Add(this.buttonload);
            this.Controls.Add(this.gamescreen);
            this.Controls.Add(this.label1);
            this.Name = "game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamescreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox gamescreen;
        private System.Windows.Forms.Button buttonload;
        private System.Windows.Forms.Button buttonshootaway;
        private System.Windows.Forms.Button buttonshoot;
        private System.Windows.Forms.Button buttonspin;
        private System.Windows.Forms.Button button1;
    }
}