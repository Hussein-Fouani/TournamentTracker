
namespace ProjectTrackerUI
{
    partial class Tournamentviewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tournamentviewer));
            this.Tournament_Label = new System.Windows.Forms.Label();
            this.Tor_Name_label = new System.Windows.Forms.Label();
            this.Round_label = new System.Windows.Forms.Label();
            this.Round_dropdown = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Tournament_Label
            // 
            this.Tournament_Label.AutoSize = true;
            this.Tournament_Label.BackColor = System.Drawing.Color.Transparent;
            this.Tournament_Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tournament_Label.ForeColor = System.Drawing.Color.Transparent;
            this.Tournament_Label.Location = new System.Drawing.Point(31, 28);
            this.Tournament_Label.Name = "Tournament_Label";
            this.Tournament_Label.Size = new System.Drawing.Size(163, 30);
            this.Tournament_Label.TabIndex = 0;
            this.Tournament_Label.Text = "Tournament ";
            // 
            // Tor_Name_label
            // 
            this.Tor_Name_label.AutoSize = true;
            this.Tor_Name_label.BackColor = System.Drawing.Color.Transparent;
            this.Tor_Name_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tor_Name_label.ForeColor = System.Drawing.Color.Transparent;
            this.Tor_Name_label.Location = new System.Drawing.Point(186, 28);
            this.Tor_Name_label.Name = "Tor_Name_label";
            this.Tor_Name_label.Size = new System.Drawing.Size(105, 30);
            this.Tor_Name_label.TabIndex = 1;
            this.Tor_Name_label.Text = "<none>";
            // 
            // Round_label
            // 
            this.Round_label.AutoSize = true;
            this.Round_label.BackColor = System.Drawing.Color.Transparent;
            this.Round_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Round_label.ForeColor = System.Drawing.Color.Transparent;
            this.Round_label.Location = new System.Drawing.Point(31, 85);
            this.Round_label.Name = "Round_label";
            this.Round_label.Size = new System.Drawing.Size(163, 30);
            this.Round_label.TabIndex = 2;
            this.Round_label.Text = "Tournament ";
            // 
            // Round_dropdown
            // 
            this.Round_dropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Round_dropdown.FormattingEnabled = true;
            this.Round_dropdown.Location = new System.Drawing.Point(186, 85);
            this.Round_dropdown.Name = "Round_dropdown";
            this.Round_dropdown.Size = new System.Drawing.Size(235, 29);
            this.Round_dropdown.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(193, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "UnPlayed Only";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Tournamentviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Round_dropdown);
            this.Controls.Add(this.Round_label);
            this.Controls.Add(this.Tor_Name_label);
            this.Controls.Add(this.Tournament_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tournamentviewer";
            this.Text = "TournamentViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tournament_Label;
        private System.Windows.Forms.Label Tor_Name_label;
        private System.Windows.Forms.Label Round_label;
        private System.Windows.Forms.ComboBox Round_dropdown;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

