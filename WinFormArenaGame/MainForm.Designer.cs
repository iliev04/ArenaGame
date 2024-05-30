namespace WinFormArenaGame
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.tbKnight = new System.Windows.Forms.TextBox();
            this.tbAssassin = new System.Windows.Forms.TextBox();
            this.imgFight = new System.Windows.Forms.PictureBox();
            this.lbWinner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(675, 63);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(94, 29);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // tbKnight
            // 
            this.tbKnight.Location = new System.Drawing.Point(23, 35);
            this.tbKnight.Multiline = true;
            this.tbKnight.Name = "tbKnight";
            this.tbKnight.Size = new System.Drawing.Size(560, 437);
            this.tbKnight.TabIndex = 1;
            // 
            // tbAssassin
            // 
            this.tbAssassin.Location = new System.Drawing.Point(879, 44);
            this.tbAssassin.Multiline = true;
            this.tbAssassin.Name = "tbAssassin";
            this.tbAssassin.Size = new System.Drawing.Size(560, 437);
            this.tbAssassin.TabIndex = 2;
            // 
            // imgFight
            // 
            this.imgFight.Enabled = false;
            this.imgFight.Image = ((System.Drawing.Image)(resources.GetObject("imgFight.Image")));
            this.imgFight.Location = new System.Drawing.Point(631, 252);
            this.imgFight.Name = "imgFight";
            this.imgFight.Size = new System.Drawing.Size(206, 134);
            this.imgFight.TabIndex = 3;
            this.imgFight.TabStop = false;
            // 
            // lbWinner
            // 
            this.lbWinner.Location = new System.Drawing.Point(631, 121);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(206, 89);
            this.lbWinner.TabIndex = 4;
            this.lbWinner.Visible = false;
            this.lbWinner.Click += new System.EventHandler(this.lbWinner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(879, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wizzard:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Goblin:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.imgFight);
            this.Controls.Add(this.tbAssassin);
            this.Controls.Add(this.tbKnight);
            this.Controls.Add(this.btnNewGame);
            this.Name = "MainForm";
            this.Text = "Arena Game";
            ((System.ComponentModel.ISupportInitialize)(this.imgFight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNewGame;
        private TextBox tbKnight;
        private TextBox tbAssassin;
        private PictureBox imgFight;
        private Label lbWinner;
        private Label label1;
        private Label label2;
    }
}