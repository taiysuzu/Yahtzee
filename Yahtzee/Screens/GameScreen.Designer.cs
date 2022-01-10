
namespace Yahtzee
{
    partial class GameScreen
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
            this.scoreCard = new System.Windows.Forms.PictureBox();
            this.diceBox1 = new System.Windows.Forms.PictureBox();
            this.diceBox4 = new System.Windows.Forms.PictureBox();
            this.diceBox5 = new System.Windows.Forms.PictureBox();
            this.diceBox6 = new System.Windows.Forms.PictureBox();
            this.diceBox3 = new System.Windows.Forms.PictureBox();
            this.diceBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scoreCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreCard
            // 
            this.scoreCard.Location = new System.Drawing.Point(3, 3);
            this.scoreCard.Name = "scoreCard";
            this.scoreCard.Size = new System.Drawing.Size(481, 594);
            this.scoreCard.TabIndex = 0;
            this.scoreCard.TabStop = false;
            // 
            // diceBox1
            // 
            this.diceBox1.Location = new System.Drawing.Point(646, 246);
            this.diceBox1.Name = "diceBox1";
            this.diceBox1.Size = new System.Drawing.Size(74, 70);
            this.diceBox1.TabIndex = 1;
            this.diceBox1.TabStop = false;
            // 
            // diceBox4
            // 
            this.diceBox4.Location = new System.Drawing.Point(646, 358);
            this.diceBox4.Name = "diceBox4";
            this.diceBox4.Size = new System.Drawing.Size(74, 70);
            this.diceBox4.TabIndex = 2;
            this.diceBox4.TabStop = false;
            // 
            // diceBox5
            // 
            this.diceBox5.Location = new System.Drawing.Point(791, 358);
            this.diceBox5.Name = "diceBox5";
            this.diceBox5.Size = new System.Drawing.Size(74, 70);
            this.diceBox5.TabIndex = 3;
            this.diceBox5.TabStop = false;
            // 
            // diceBox6
            // 
            this.diceBox6.Location = new System.Drawing.Point(935, 358);
            this.diceBox6.Name = "diceBox6";
            this.diceBox6.Size = new System.Drawing.Size(74, 70);
            this.diceBox6.TabIndex = 4;
            this.diceBox6.TabStop = false;
            // 
            // diceBox3
            // 
            this.diceBox3.Location = new System.Drawing.Point(935, 246);
            this.diceBox3.Name = "diceBox3";
            this.diceBox3.Size = new System.Drawing.Size(74, 70);
            this.diceBox3.TabIndex = 5;
            this.diceBox3.TabStop = false;
            // 
            // diceBox2
            // 
            this.diceBox2.Location = new System.Drawing.Point(791, 246);
            this.diceBox2.Name = "diceBox2";
            this.diceBox2.Size = new System.Drawing.Size(74, 70);
            this.diceBox2.TabIndex = 6;
            this.diceBox2.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.diceBox2);
            this.Controls.Add(this.diceBox3);
            this.Controls.Add(this.diceBox6);
            this.Controls.Add(this.diceBox5);
            this.Controls.Add(this.diceBox4);
            this.Controls.Add(this.diceBox1);
            this.Controls.Add(this.scoreCard);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1200, 600);
            ((System.ComponentModel.ISupportInitialize)(this.scoreCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox scoreCard;
        private System.Windows.Forms.PictureBox diceBox1;
        private System.Windows.Forms.PictureBox diceBox4;
        private System.Windows.Forms.PictureBox diceBox5;
        private System.Windows.Forms.PictureBox diceBox6;
        private System.Windows.Forms.PictureBox diceBox3;
        private System.Windows.Forms.PictureBox diceBox2;
    }
}
