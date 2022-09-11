namespace POE_PART_ONE
{
    partial class Form1
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
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblHeroStats = new System.Windows.Forms.Label();
            this.lblEnemyStats = new System.Windows.Forms.Label();
            this.cmbAttack = new System.Windows.Forms.ComboBox();
            this.rtbxMap = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(482, 341);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(98, 29);
            this.btnUp.TabIndex = 17;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(525, 376);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(98, 29);
            this.btnRight.TabIndex = 16;
            this.btnRight.Text = "RIGHT";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(482, 411);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(98, 29);
            this.btnDown.TabIndex = 15;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(425, 376);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(98, 29);
            this.btnLeft.TabIndex = 14;
            this.btnLeft.Text = "LEFT";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // lblHeroStats
            // 
            this.lblHeroStats.AutoSize = true;
            this.lblHeroStats.Location = new System.Drawing.Point(432, 51);
            this.lblHeroStats.Name = "lblHeroStats";
            this.lblHeroStats.Size = new System.Drawing.Size(73, 20);
            this.lblHeroStats.TabIndex = 13;
            this.lblHeroStats.Text = "hero stats";
            // 
            // lblEnemyStats
            // 
            this.lblEnemyStats.AutoSize = true;
            this.lblEnemyStats.Location = new System.Drawing.Point(432, 11);
            this.lblEnemyStats.Name = "lblEnemyStats";
            this.lblEnemyStats.Size = new System.Drawing.Size(87, 20);
            this.lblEnemyStats.TabIndex = 12;
            this.lblEnemyStats.Text = "enemy stats";
            // 
            // cmbAttack
            // 
            this.cmbAttack.FormattingEnabled = true;
            this.cmbAttack.Location = new System.Drawing.Point(433, 179);
            this.cmbAttack.Name = "cmbAttack";
            this.cmbAttack.Size = new System.Drawing.Size(190, 28);
            this.cmbAttack.TabIndex = 11;
            // 
            // rtbxMap
            // 
            this.rtbxMap.Location = new System.Drawing.Point(10, 14);
            this.rtbxMap.Name = "rtbxMap";
            this.rtbxMap.Size = new System.Drawing.Size(395, 366);
            this.rtbxMap.TabIndex = 10;
            this.rtbxMap.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(692, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 29);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.lblHeroStats);
            this.Controls.Add(this.lblEnemyStats);
            this.Controls.Add(this.cmbAttack);
            this.Controls.Add(this.rtbxMap);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUp;
        private Button btnRight;
        private Button btnDown;
        private Button btnLeft;
        private Label lblHeroStats;
        private Label lblEnemyStats;
        private ComboBox cmbAttack;
        private RichTextBox rtbxMap;
        private Button btnExit;
    }
}