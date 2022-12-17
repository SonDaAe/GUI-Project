namespace WindowsFormsApp3
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox_dog = new System.Windows.Forms.PictureBox();
            this.pictureBox_pm = new System.Windows.Forms.PictureBox();
            this.pictureBox_choco = new System.Windows.Forms.PictureBox();
            this.label1_gameclear = new System.Windows.Forms.Label();
            this.label1_gameover = new System.Windows.Forms.Label();
            this.pictureBox_action = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2_score = new System.Windows.Forms.Label();
            this.pictureBox4_heart = new System.Windows.Forms.PictureBox();
            this.pictureBox3_heart = new System.Windows.Forms.PictureBox();
            this.pictureBox2_heart = new System.Windows.Forms.PictureBox();
            this.label1_stage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_choco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_action)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_heart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_dog
            // 
            this.pictureBox_dog.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_dog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_dog.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_dog.Image")));
            this.pictureBox_dog.Location = new System.Drawing.Point(438, 172);
            this.pictureBox_dog.Name = "pictureBox_dog";
            this.pictureBox_dog.Size = new System.Drawing.Size(64, 63);
            this.pictureBox_dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_dog.TabIndex = 17;
            this.pictureBox_dog.TabStop = false;
            // 
            // pictureBox_pm
            // 
            this.pictureBox_pm.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_pm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_pm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_pm.Image")));
            this.pictureBox_pm.Location = new System.Drawing.Point(166, 193);
            this.pictureBox_pm.Name = "pictureBox_pm";
            this.pictureBox_pm.Size = new System.Drawing.Size(68, 68);
            this.pictureBox_pm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pm.TabIndex = 16;
            this.pictureBox_pm.TabStop = false;
            // 
            // pictureBox_choco
            // 
            this.pictureBox_choco.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_choco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_choco.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_choco.Image")));
            this.pictureBox_choco.Location = new System.Drawing.Point(283, 48);
            this.pictureBox_choco.Name = "pictureBox_choco";
            this.pictureBox_choco.Size = new System.Drawing.Size(59, 83);
            this.pictureBox_choco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_choco.TabIndex = 15;
            this.pictureBox_choco.TabStop = false;
            // 
            // label1_gameclear
            // 
            this.label1_gameclear.AutoSize = true;
            this.label1_gameclear.BackColor = System.Drawing.Color.Black;
            this.label1_gameclear.Font = new System.Drawing.Font("휴먼둥근헤드라인", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1_gameclear.ForeColor = System.Drawing.Color.Yellow;
            this.label1_gameclear.Location = new System.Drawing.Point(20, 283);
            this.label1_gameclear.Name = "label1_gameclear";
            this.label1_gameclear.Size = new System.Drawing.Size(502, 63);
            this.label1_gameclear.TabIndex = 21;
            this.label1_gameclear.Text = "Stage1 Clear";
            this.label1_gameclear.Visible = false;
            // 
            // label1_gameover
            // 
            this.label1_gameover.AutoSize = true;
            this.label1_gameover.BackColor = System.Drawing.Color.Black;
            this.label1_gameover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1_gameover.Font = new System.Drawing.Font("휴먼둥근헤드라인", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1_gameover.ForeColor = System.Drawing.Color.Red;
            this.label1_gameover.Location = new System.Drawing.Point(67, 283);
            this.label1_gameover.Name = "label1_gameover";
            this.label1_gameover.Size = new System.Drawing.Size(434, 65);
            this.label1_gameover.TabIndex = 20;
            this.label1_gameover.Text = "Game Over";
            this.label1_gameover.Visible = false;
            // 
            // pictureBox_action
            // 
            this.pictureBox_action.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_action.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_action.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_action.Image")));
            this.pictureBox_action.Location = new System.Drawing.Point(41, 271);
            this.pictureBox_action.Name = "pictureBox_action";
            this.pictureBox_action.Size = new System.Drawing.Size(58, 77);
            this.pictureBox_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_action.TabIndex = 19;
            this.pictureBox_action.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 537);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(384, 5);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(138, 28);
            this.progressBar1.TabIndex = 23;
            // 
            // label2_score
            // 
            this.label2_score.AutoSize = true;
            this.label2_score.BackColor = System.Drawing.Color.Transparent;
            this.label2_score.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2_score.Location = new System.Drawing.Point(331, 9);
            this.label2_score.Name = "label2_score";
            this.label2_score.Size = new System.Drawing.Size(23, 25);
            this.label2_score.TabIndex = 22;
            this.label2_score.Text = "0";
            // 
            // pictureBox4_heart
            // 
            this.pictureBox4_heart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4_heart.BackgroundImage")));
            this.pictureBox4_heart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4_heart.Image")));
            this.pictureBox4_heart.Location = new System.Drawing.Point(84, 5);
            this.pictureBox4_heart.Name = "pictureBox4_heart";
            this.pictureBox4_heart.Size = new System.Drawing.Size(35, 33);
            this.pictureBox4_heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4_heart.TabIndex = 26;
            this.pictureBox4_heart.TabStop = false;
            // 
            // pictureBox3_heart
            // 
            this.pictureBox3_heart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3_heart.BackgroundImage")));
            this.pictureBox3_heart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3_heart.Image")));
            this.pictureBox3_heart.Location = new System.Drawing.Point(43, 5);
            this.pictureBox3_heart.Name = "pictureBox3_heart";
            this.pictureBox3_heart.Size = new System.Drawing.Size(35, 33);
            this.pictureBox3_heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3_heart.TabIndex = 25;
            this.pictureBox3_heart.TabStop = false;
            // 
            // pictureBox2_heart
            // 
            this.pictureBox2_heart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2_heart.BackgroundImage")));
            this.pictureBox2_heart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2_heart.Image")));
            this.pictureBox2_heart.Location = new System.Drawing.Point(2, 5);
            this.pictureBox2_heart.Name = "pictureBox2_heart";
            this.pictureBox2_heart.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2_heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2_heart.TabIndex = 24;
            this.pictureBox2_heart.TabStop = false;
            // 
            // label1_stage
            // 
            this.label1_stage.AutoSize = true;
            this.label1_stage.BackColor = System.Drawing.Color.Black;
            this.label1_stage.Font = new System.Drawing.Font("휴먼둥근헤드라인", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1_stage.ForeColor = System.Drawing.Color.Yellow;
            this.label1_stage.Location = new System.Drawing.Point(160, 357);
            this.label1_stage.Name = "label1_stage";
            this.label1_stage.Size = new System.Drawing.Size(230, 34);
            this.label1_stage.TabIndex = 27;
            this.label1_stage.Text = "다음 스테이지";
            this.label1_stage.Visible = false;
            this.label1_stage.Click += new System.EventHandler(this.label1_stage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(140, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Stage1 : 1000";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1_stage);
            this.Controls.Add(this.pictureBox4_heart);
            this.Controls.Add(this.pictureBox3_heart);
            this.Controls.Add(this.pictureBox2_heart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2_score);
            this.Controls.Add(this.label1_gameclear);
            this.Controls.Add(this.label1_gameover);
            this.Controls.Add(this.pictureBox_action);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_dog);
            this.Controls.Add(this.pictureBox_pm);
            this.Controls.Add(this.pictureBox_choco);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stage1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_choco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_action)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_heart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_dog;
        private System.Windows.Forms.PictureBox pictureBox_pm;
        private System.Windows.Forms.PictureBox pictureBox_choco;
        private System.Windows.Forms.Label label1_gameclear;
        private System.Windows.Forms.Label label1_gameover;
        private System.Windows.Forms.PictureBox pictureBox_action;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2_score;
        private System.Windows.Forms.PictureBox pictureBox4_heart;
        private System.Windows.Forms.PictureBox pictureBox3_heart;
        private System.Windows.Forms.PictureBox pictureBox2_heart;
        private System.Windows.Forms.Label label1_stage;
        private System.Windows.Forms.Label label1;
    }
}