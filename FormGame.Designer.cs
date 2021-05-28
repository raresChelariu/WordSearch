
namespace WordSearch
{
    partial class FormGame
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
            this.groupBoxRebus = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxWordsLeft = new System.Windows.Forms.ListBox();
            this.listBoxWordsFound = new System.Windows.Forms.ListBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.timerGameTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxGameTime = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTimePassed = new System.Windows.Forms.Label();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxGameTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRebus
            // 
            this.groupBoxRebus.Location = new System.Drawing.Point(12, 27);
            this.groupBoxRebus.Name = "groupBoxRebus";
            this.groupBoxRebus.Size = new System.Drawing.Size(846, 660);
            this.groupBoxRebus.TabIndex = 0;
            this.groupBoxRebus.TabStop = false;
            this.groupBoxRebus.Text = "Rebus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(870, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuvinte ramase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1134, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuvinte gasite";
            // 
            // listBoxWordsLeft
            // 
            this.listBoxWordsLeft.FormattingEnabled = true;
            this.listBoxWordsLeft.ItemHeight = 16;
            this.listBoxWordsLeft.Location = new System.Drawing.Point(875, 232);
            this.listBoxWordsLeft.Name = "listBoxWordsLeft";
            this.listBoxWordsLeft.Size = new System.Drawing.Size(167, 244);
            this.listBoxWordsLeft.TabIndex = 3;
            // 
            // listBoxWordsFound
            // 
            this.listBoxWordsFound.FormattingEnabled = true;
            this.listBoxWordsFound.ItemHeight = 16;
            this.listBoxWordsFound.Location = new System.Drawing.Point(1134, 232);
            this.listBoxWordsFound.Name = "listBoxWordsFound";
            this.listBoxWordsFound.Size = new System.Drawing.Size(239, 244);
            this.listBoxWordsFound.TabIndex = 4;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGame.Location = new System.Drawing.Point(875, 600);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(246, 87);
            this.buttonStartGame.TabIndex = 10;
            this.buttonStartGame.Text = "Joaca";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // timerGameTime
            // 
            this.timerGameTime.Tick += new System.EventHandler(this.timerGameTime_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPrenume);
            this.groupBox1.Controls.Add(this.textBoxNume);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(875, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 173);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introdu numele tau pentru a aparea in top 10!";
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(135, 106);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(269, 30);
            this.textBoxPrenume.TabIndex = 13;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(135, 49);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(269, 30);
            this.textBoxNume.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nume";
            // 
            // groupBoxGameTime
            // 
            this.groupBoxGameTime.Controls.Add(this.label8);
            this.groupBoxGameTime.Controls.Add(this.label7);
            this.groupBoxGameTime.Controls.Add(this.labelTimePassed);
            this.groupBoxGameTime.Controls.Add(this.labelTimeLeft);
            this.groupBoxGameTime.Controls.Add(this.label6);
            this.groupBoxGameTime.Controls.Add(this.label5);
            this.groupBoxGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGameTime.Location = new System.Drawing.Point(875, 483);
            this.groupBoxGameTime.Name = "groupBoxGameTime";
            this.groupBoxGameTime.Size = new System.Drawing.Size(419, 111);
            this.groupBoxGameTime.TabIndex = 12;
            this.groupBoxGameTime.TabStop = false;
            this.groupBoxGameTime.Text = "Timpul jocului";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "secunde";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "secunde";
            // 
            // labelTimePassed
            // 
            this.labelTimePassed.AutoSize = true;
            this.labelTimePassed.Location = new System.Drawing.Point(163, 54);
            this.labelTimePassed.Name = "labelTimePassed";
            this.labelTimePassed.Size = new System.Drawing.Size(20, 24);
            this.labelTimePassed.TabIndex = 3;
            this.labelTimePassed.Text = "0";
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.Location = new System.Drawing.Point(163, 22);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(60, 24);
            this.labelTimeLeft.TabIndex = 2;
            this.labelTimeLeft.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Timp trecut :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Timp ramas : ";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(1134, 600);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(246, 87);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 717);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxGameTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.listBoxWordsFound);
            this.Controls.Add(this.listBoxWordsLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxRebus);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxGameTime.ResumeLayout(false);
            this.groupBoxGameTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRebus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxWordsLeft;
        private System.Windows.Forms.ListBox listBoxWordsFound;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Timer timerGameTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxGameTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTimePassed;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonExit;
    }
}