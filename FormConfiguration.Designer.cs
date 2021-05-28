
namespace WordSearch
{
    partial class FormConfiguration
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
            this.groupBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.radioButtonAvansat = new System.Windows.Forms.RadioButton();
            this.radioButtonMediu = new System.Windows.Forms.RadioButton();
            this.radioButtonIncepator = new System.Windows.Forms.RadioButton();
            this.buttonApplyConfiguration = new System.Windows.Forms.Button();
            this.groupBoxDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDifficulty
            // 
            this.groupBoxDifficulty.Controls.Add(this.radioButtonAvansat);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonMediu);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonIncepator);
            this.groupBoxDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDifficulty.Location = new System.Drawing.Point(26, 34);
            this.groupBoxDifficulty.Name = "groupBoxDifficulty";
            this.groupBoxDifficulty.Size = new System.Drawing.Size(303, 209);
            this.groupBoxDifficulty.TabIndex = 0;
            this.groupBoxDifficulty.TabStop = false;
            this.groupBoxDifficulty.Text = "Dificultate";
            // 
            // radioButtonAvansat
            // 
            this.radioButtonAvansat.AutoSize = true;
            this.radioButtonAvansat.Location = new System.Drawing.Point(28, 136);
            this.radioButtonAvansat.Name = "radioButtonAvansat";
            this.radioButtonAvansat.Size = new System.Drawing.Size(117, 33);
            this.radioButtonAvansat.TabIndex = 2;
            this.radioButtonAvansat.Text = "Avansat";
            this.radioButtonAvansat.UseVisualStyleBackColor = true;
            //this.radioButtonAvansat.CheckedChanged += new System.EventHandler(this.radioButtonAvansat_CheckedChanged);
            // 
            // radioButtonMediu
            // 
            this.radioButtonMediu.AutoSize = true;
            this.radioButtonMediu.Location = new System.Drawing.Point(28, 86);
            this.radioButtonMediu.Name = "radioButtonMediu";
            this.radioButtonMediu.Size = new System.Drawing.Size(101, 33);
            this.radioButtonMediu.TabIndex = 1;
            this.radioButtonMediu.Text = "Mediu";
            this.radioButtonMediu.UseVisualStyleBackColor = true;
            //this.radioButtonMediu.CheckedChanged += new System.EventHandler(this.radioButtonMediu_CheckedChanged);
            // 
            // radioButtonIncepator
            // 
            this.radioButtonIncepator.AutoSize = true;
            this.radioButtonIncepator.Checked = true;
            this.radioButtonIncepator.Location = new System.Drawing.Point(28, 34);
            this.radioButtonIncepator.Name = "radioButtonIncepator";
            this.radioButtonIncepator.Size = new System.Drawing.Size(134, 33);
            this.radioButtonIncepator.TabIndex = 0;
            this.radioButtonIncepator.TabStop = true;
            this.radioButtonIncepator.Text = "Incepator";
            this.radioButtonIncepator.UseVisualStyleBackColor = true;
            //this.radioButtonIncepator.CheckedChanged += new System.EventHandler(this.radioButtonIncepator_CheckedChanged);
            // 
            // buttonApplyConfiguration
            // 
            this.buttonApplyConfiguration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonApplyConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyConfiguration.Location = new System.Drawing.Point(0, 420);
            this.buttonApplyConfiguration.Name = "buttonApplyConfiguration";
            this.buttonApplyConfiguration.Size = new System.Drawing.Size(803, 86);
            this.buttonApplyConfiguration.TabIndex = 1;
            this.buttonApplyConfiguration.Text = "Aplica configurarea";
            this.buttonApplyConfiguration.UseVisualStyleBackColor = true;
            this.buttonApplyConfiguration.Click += new System.EventHandler(this.buttonApplyConfiguration_Click);
            // 
            // FormGameConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 506);
            this.Controls.Add(this.buttonApplyConfiguration);
            this.Controls.Add(this.groupBoxDifficulty);
            this.Name = "FormGameConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configare Word Search";
            this.groupBoxDifficulty.ResumeLayout(false);
            this.groupBoxDifficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDifficulty;
        private System.Windows.Forms.Button buttonApplyConfiguration;
        private System.Windows.Forms.RadioButton radioButtonIncepator;
        private System.Windows.Forms.RadioButton radioButtonAvansat;
        private System.Windows.Forms.RadioButton radioButtonMediu;
    }
}