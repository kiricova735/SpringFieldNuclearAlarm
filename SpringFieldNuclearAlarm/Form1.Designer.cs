namespace SpringFieldNuclearAlarm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reactor2Label = new System.Windows.Forms.Label();
            this.reactor1State = new System.Windows.Forms.Label();
            this.reactor2State = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(304, 74);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(296, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "NuclearReactorControl";
            // 
            // reactor1Label
            // 
            this.reactor1Label.AutoSize = true;
            this.reactor1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Label.Location = new System.Drawing.Point(187, 149);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(73, 16);
            this.reactor1Label.TabIndex = 1;
            this.reactor1Label.Text = "Reactor #1";
            this.reactor1Label.Click += new System.EventHandler(this.Reactor1Label_Click);
            // 
            // reactor2Label
            // 
            this.reactor2Label.AutoSize = true;
            this.reactor2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Label.Location = new System.Drawing.Point(594, 149);
            this.reactor2Label.Name = "reactor2Label";
            this.reactor2Label.Size = new System.Drawing.Size(78, 17);
            this.reactor2Label.TabIndex = 2;
            this.reactor2Label.Text = "Reactor #2";
            this.reactor2Label.Click += new System.EventHandler(this.Reactor2Label_Click);
            // 
            // reactor1State
            // 
            this.reactor1State.BackColor = System.Drawing.Color.ForestGreen;
            this.reactor1State.Location = new System.Drawing.Point(123, 188);
            this.reactor1State.Name = "reactor1State";
            this.reactor1State.Size = new System.Drawing.Size(195, 149);
            this.reactor1State.TabIndex = 3;
            // 
            // reactor2State
            // 
            this.reactor2State.BackColor = System.Drawing.Color.ForestGreen;
            this.reactor2State.Location = new System.Drawing.Point(538, 188);
            this.reactor2State.Name = "reactor2State";
            this.reactor2State.Size = new System.Drawing.Size(195, 149);
            this.reactor2State.TabIndex = 5;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.outputLabel.Font = new System.Drawing.Font("Millenium BdEx BT", 15F);
            this.outputLabel.Location = new System.Drawing.Point(268, 371);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(332, 30);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Reactors Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(401, 314);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactor2State);
            this.Controls.Add(this.reactor1State);
            this.Controls.Add(this.reactor2Label);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Springfield PowerPlant Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reactor2Label;
        private System.Windows.Forms.Label reactor1State;
        private System.Windows.Forms.Label reactor2State;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button buttonStart;
    }
}

