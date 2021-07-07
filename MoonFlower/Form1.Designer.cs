
namespace MoonFlower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.yellowText = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.credditLabel = new System.Windows.Forms.Label();
            this.breakPCButton = new System.Windows.Forms.Button();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.imageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(340, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(251, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "MoonFlower";
            // 
            // yellowText
            // 
            this.yellowText.AutoSize = true;
            this.yellowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowText.ForeColor = System.Drawing.Color.Yellow;
            this.yellowText.Location = new System.Drawing.Point(551, 55);
            this.yellowText.Name = "yellowText";
            this.yellowText.Size = new System.Drawing.Size(51, 20);
            this.yellowText.TabIndex = 1;
            this.yellowText.Text = "label1";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(12, 747);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(56, 20);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "V. 1.1";
            // 
            // credditLabel
            // 
            this.credditLabel.AutoSize = true;
            this.credditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credditLabel.Location = new System.Drawing.Point(804, 747);
            this.credditLabel.Name = "credditLabel";
            this.credditLabel.Size = new System.Drawing.Size(126, 20);
            this.credditLabel.TabIndex = 4;
            this.credditLabel.Text = "Made by Lewis";
            // 
            // breakPCButton
            // 
            this.breakPCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakPCButton.Location = new System.Drawing.Point(410, 286);
            this.breakPCButton.Name = "breakPCButton";
            this.breakPCButton.Size = new System.Drawing.Size(111, 37);
            this.breakPCButton.TabIndex = 5;
            this.breakPCButton.Text = "Break My PC!";
            this.breakPCButton.UseVisualStyleBackColor = true;
            this.breakPCButton.Click += new System.EventHandler(this.breakPCButton_Click);
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceLabel.Location = new System.Drawing.Point(335, 185);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(267, 25);
            this.choiceLabel.TabIndex = 6;
            this.choiceLabel.Text = "Choose something to do";
            // 
            // imageButton
            // 
            this.imageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageButton.Location = new System.Drawing.Point(381, 329);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(173, 37);
            this.imageButton.TabIndex = 7;
            this.imageButton.Text = "Display a random image";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 776);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.breakPCButton);
            this.Controls.Add(this.credditLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.yellowText);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MoonFlower";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.Label yellowText;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label credditLabel;
        private System.Windows.Forms.Button breakPCButton;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.Button imageButton;
    }
}

