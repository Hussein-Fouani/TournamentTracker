
namespace ProjectTrackerUI
{
    partial class TournamentDashBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashBoardForm));
            this.Tournament_DashBorad_Label = new System.Windows.Forms.Label();
            this.Load_Existing_Tournament_drpbdwn = new System.Windows.Forms.ComboBox();
            this.LoadExisting_label = new System.Windows.Forms.Label();
            this.Load_Tournament_btn = new System.Windows.Forms.Button();
            this.create_tournament_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tournament_DashBorad_Label
            // 
            this.Tournament_DashBorad_Label.AutoSize = true;
            this.Tournament_DashBorad_Label.BackColor = System.Drawing.Color.Transparent;
            this.Tournament_DashBorad_Label.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tournament_DashBorad_Label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Tournament_DashBorad_Label.Location = new System.Drawing.Point(207, 47);
            this.Tournament_DashBorad_Label.Name = "Tournament_DashBorad_Label";
            this.Tournament_DashBorad_Label.Size = new System.Drawing.Size(383, 39);
            this.Tournament_DashBorad_Label.TabIndex = 15;
            this.Tournament_DashBorad_Label.Text = "Tournament DashBoard";
            this.Tournament_DashBorad_Label.Click += new System.EventHandler(this.create_Prize_label_Click);
            // 
            // Load_Existing_Tournament_drpbdwn
            // 
            this.Load_Existing_Tournament_drpbdwn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Load_Existing_Tournament_drpbdwn.ForeColor = System.Drawing.Color.DimGray;
            this.Load_Existing_Tournament_drpbdwn.FormattingEnabled = true;
            this.Load_Existing_Tournament_drpbdwn.Location = new System.Drawing.Point(218, 191);
            this.Load_Existing_Tournament_drpbdwn.Name = "Load_Existing_Tournament_drpbdwn";
            this.Load_Existing_Tournament_drpbdwn.Size = new System.Drawing.Size(359, 33);
            this.Load_Existing_Tournament_drpbdwn.TabIndex = 17;
            // 
            // LoadExisting_label
            // 
            this.LoadExisting_label.AutoSize = true;
            this.LoadExisting_label.BackColor = System.Drawing.Color.Transparent;
            this.LoadExisting_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadExisting_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LoadExisting_label.Location = new System.Drawing.Point(244, 135);
            this.LoadExisting_label.Name = "LoadExisting_label";
            this.LoadExisting_label.Size = new System.Drawing.Size(315, 30);
            this.LoadExisting_label.TabIndex = 16;
            this.LoadExisting_label.Text = "Load Existing Tournament";
            this.LoadExisting_label.Click += new System.EventHandler(this.LoadExisting_label_Click);
            // 
            // Load_Tournament_btn
            // 
            this.Load_Tournament_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Load_Tournament_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Load_Tournament_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Load_Tournament_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_Tournament_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Load_Tournament_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Load_Tournament_btn.Location = new System.Drawing.Point(296, 246);
            this.Load_Tournament_btn.Name = "Load_Tournament_btn";
            this.Load_Tournament_btn.Size = new System.Drawing.Size(203, 48);
            this.Load_Tournament_btn.TabIndex = 18;
            this.Load_Tournament_btn.Text = "Load Tournament";
            this.Load_Tournament_btn.UseVisualStyleBackColor = true;
            this.Load_Tournament_btn.Click += new System.EventHandler(this.Load_Tournament_btn_Click);
            // 
            // create_tournament_btn
            // 
            this.create_tournament_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.create_tournament_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.create_tournament_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.create_tournament_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_tournament_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_tournament_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.create_tournament_btn.Location = new System.Drawing.Point(279, 340);
            this.create_tournament_btn.Name = "create_tournament_btn";
            this.create_tournament_btn.Size = new System.Drawing.Size(239, 67);
            this.create_tournament_btn.TabIndex = 19;
            this.create_tournament_btn.Text = "Create Tournament";
            this.create_tournament_btn.UseVisualStyleBackColor = true;
            // 
            // TournamentDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.create_tournament_btn);
            this.Controls.Add(this.Load_Tournament_btn);
            this.Controls.Add(this.Load_Existing_Tournament_drpbdwn);
            this.Controls.Add(this.LoadExisting_label);
            this.Controls.Add(this.Tournament_DashBorad_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentDashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TournamentDashBoard";
            this.Load += new System.EventHandler(this.TournamentDashBoardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tournament_DashBorad_Label;
        private System.Windows.Forms.ComboBox Load_Existing_Tournament_drpbdwn;
        private System.Windows.Forms.Label LoadExisting_label;
        private System.Windows.Forms.Button Load_Tournament_btn;
        private System.Windows.Forms.Button create_tournament_btn;
    }
}