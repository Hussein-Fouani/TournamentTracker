
namespace ProjectTrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.Tor_Name_label = new System.Windows.Forms.Label();
            this.Tournament_Label = new System.Windows.Forms.Label();
            this.Tournament_Name_label = new System.Windows.Forms.Label();
            this.Tr_Name_txtbx = new System.Windows.Forms.TextBox();
            this.Entry_Fee_txtbx = new System.Windows.Forms.TextBox();
            this.Entry_fee_label = new System.Windows.Forms.Label();
            this.create_tour_select_label = new System.Windows.Forms.Label();
            this.select_team_dropdown = new System.Windows.Forms.ComboBox();
            this.create_new_team_link = new System.Windows.Forms.LinkLabel();
            this.Add_Team_btn = new System.Windows.Forms.Button();
            this.create_prize_btn = new System.Windows.Forms.Button();
            this.Tour_Player_listBox = new System.Windows.Forms.ListBox();
            this.Player = new System.Windows.Forms.Label();
            this.delete_selected_plyr_btn = new System.Windows.Forms.Button();
            this.deleted_selected_prize_btn = new System.Windows.Forms.Button();
            this.Prizes_label = new System.Windows.Forms.Label();
            this.Prizes_listbx = new System.Windows.Forms.ListBox();
            this.Create_Tour_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tor_Name_label
            // 
            this.Tor_Name_label.AutoSize = true;
            this.Tor_Name_label.BackColor = System.Drawing.Color.Transparent;
            this.Tor_Name_label.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tor_Name_label.ForeColor = System.Drawing.Color.DimGray;
            this.Tor_Name_label.Location = new System.Drawing.Point(16, 26);
            this.Tor_Name_label.Name = "Tor_Name_label";
            this.Tor_Name_label.Size = new System.Drawing.Size(124, 36);
            this.Tor_Name_label.TabIndex = 2;
            this.Tor_Name_label.Text = "Create ";
            // 
            // Tournament_Label
            // 
            this.Tournament_Label.AutoSize = true;
            this.Tournament_Label.BackColor = System.Drawing.Color.Transparent;
            this.Tournament_Label.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tournament_Label.ForeColor = System.Drawing.Color.DimGray;
            this.Tournament_Label.Location = new System.Drawing.Point(120, 26);
            this.Tournament_Label.Name = "Tournament_Label";
            this.Tournament_Label.Size = new System.Drawing.Size(195, 36);
            this.Tournament_Label.TabIndex = 3;
            this.Tournament_Label.Text = "Tournament ";
            this.Tournament_Label.Click += new System.EventHandler(this.Tournament_Label_Click);
            // 
            // Tournament_Name_label
            // 
            this.Tournament_Name_label.AutoSize = true;
            this.Tournament_Name_label.BackColor = System.Drawing.Color.Transparent;
            this.Tournament_Name_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tournament_Name_label.ForeColor = System.Drawing.Color.DimGray;
            this.Tournament_Name_label.Location = new System.Drawing.Point(22, 74);
            this.Tournament_Name_label.Name = "Tournament_Name_label";
            this.Tournament_Name_label.Size = new System.Drawing.Size(237, 30);
            this.Tournament_Name_label.TabIndex = 4;
            this.Tournament_Name_label.Text = "Tournament Name";
            // 
            // Tr_Name_txtbx
            // 
            this.Tr_Name_txtbx.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tr_Name_txtbx.Location = new System.Drawing.Point(22, 107);
            this.Tr_Name_txtbx.Name = "Tr_Name_txtbx";
            this.Tr_Name_txtbx.Size = new System.Drawing.Size(266, 35);
            this.Tr_Name_txtbx.TabIndex = 9;
            // 
            // Entry_Fee_txtbx
            // 
            this.Entry_Fee_txtbx.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Entry_Fee_txtbx.ForeColor = System.Drawing.Color.DimGray;
            this.Entry_Fee_txtbx.Location = new System.Drawing.Point(130, 168);
            this.Entry_Fee_txtbx.Name = "Entry_Fee_txtbx";
            this.Entry_Fee_txtbx.Size = new System.Drawing.Size(62, 35);
            this.Entry_Fee_txtbx.TabIndex = 13;
            this.Entry_Fee_txtbx.Text = "0";
            this.Entry_Fee_txtbx.TextChanged += new System.EventHandler(this.Entry_Fee_txtbx_TextChanged);
            // 
            // Entry_fee_label
            // 
            this.Entry_fee_label.AutoSize = true;
            this.Entry_fee_label.BackColor = System.Drawing.Color.Transparent;
            this.Entry_fee_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Entry_fee_label.ForeColor = System.Drawing.Color.DimGray;
            this.Entry_fee_label.Location = new System.Drawing.Point(22, 175);
            this.Entry_fee_label.Name = "Entry_fee_label";
            this.Entry_fee_label.Size = new System.Drawing.Size(102, 24);
            this.Entry_fee_label.TabIndex = 12;
            this.Entry_fee_label.Text = "Entry Fee";
            // 
            // create_tour_select_label
            // 
            this.create_tour_select_label.AutoSize = true;
            this.create_tour_select_label.BackColor = System.Drawing.Color.Transparent;
            this.create_tour_select_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_tour_select_label.ForeColor = System.Drawing.Color.DimGray;
            this.create_tour_select_label.Location = new System.Drawing.Point(22, 234);
            this.create_tour_select_label.Name = "create_tour_select_label";
            this.create_tour_select_label.Size = new System.Drawing.Size(137, 24);
            this.create_tour_select_label.TabIndex = 14;
            this.create_tour_select_label.Text = "Select Team";
            // 
            // select_team_dropdown
            // 
            this.select_team_dropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_team_dropdown.ForeColor = System.Drawing.Color.DimGray;
            this.select_team_dropdown.FormattingEnabled = true;
            this.select_team_dropdown.Location = new System.Drawing.Point(22, 267);
            this.select_team_dropdown.Name = "select_team_dropdown";
            this.select_team_dropdown.Size = new System.Drawing.Size(266, 29);
            this.select_team_dropdown.TabIndex = 15;
            this.select_team_dropdown.SelectedIndexChanged += new System.EventHandler(this.Round_dropdown_SelectedIndexChanged);
            // 
            // create_new_team_link
            // 
            this.create_new_team_link.AutoSize = true;
            this.create_new_team_link.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_new_team_link.LinkColor = System.Drawing.Color.Black;
            this.create_new_team_link.Location = new System.Drawing.Point(189, 240);
            this.create_new_team_link.Name = "create_new_team_link";
            this.create_new_team_link.Size = new System.Drawing.Size(100, 20);
            this.create_new_team_link.TabIndex = 16;
            this.create_new_team_link.TabStop = true;
            this.create_new_team_link.Text = "Create New";
            // 
            // Add_Team_btn
            // 
            this.Add_Team_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Add_Team_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Add_Team_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Add_Team_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Team_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_Team_btn.Location = new System.Drawing.Point(77, 312);
            this.Add_Team_btn.Name = "Add_Team_btn";
            this.Add_Team_btn.Size = new System.Drawing.Size(168, 44);
            this.Add_Team_btn.TabIndex = 17;
            this.Add_Team_btn.Text = "Add Team";
            this.Add_Team_btn.UseVisualStyleBackColor = true;
            // 
            // create_prize_btn
            // 
            this.create_prize_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.create_prize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.create_prize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.create_prize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_prize_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_prize_btn.Location = new System.Drawing.Point(77, 374);
            this.create_prize_btn.Name = "create_prize_btn";
            this.create_prize_btn.Size = new System.Drawing.Size(168, 43);
            this.create_prize_btn.TabIndex = 18;
            this.create_prize_btn.Text = "Create Prize";
            this.create_prize_btn.UseVisualStyleBackColor = true;
            // 
            // Tour_Player_listBox
            // 
            this.Tour_Player_listBox.BackColor = System.Drawing.Color.Gainsboro;
            this.Tour_Player_listBox.FormattingEnabled = true;
            this.Tour_Player_listBox.ItemHeight = 24;
            this.Tour_Player_listBox.Location = new System.Drawing.Point(400, 39);
            this.Tour_Player_listBox.Name = "Tour_Player_listBox";
            this.Tour_Player_listBox.Size = new System.Drawing.Size(279, 148);
            this.Tour_Player_listBox.TabIndex = 19;
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player.ForeColor = System.Drawing.Color.Black;
            this.Player.Location = new System.Drawing.Point(400, 11);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(158, 24);
            this.Player.TabIndex = 20;
            this.Player.Text = "Teams / Player";
            // 
            // delete_selected_plyr_btn
            // 
            this.delete_selected_plyr_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.delete_selected_plyr_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.delete_selected_plyr_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.delete_selected_plyr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_selected_plyr_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete_selected_plyr_btn.Location = new System.Drawing.Point(685, 74);
            this.delete_selected_plyr_btn.Name = "delete_selected_plyr_btn";
            this.delete_selected_plyr_btn.Size = new System.Drawing.Size(122, 68);
            this.delete_selected_plyr_btn.TabIndex = 21;
            this.delete_selected_plyr_btn.Text = "Delete Selected";
            this.delete_selected_plyr_btn.UseVisualStyleBackColor = true;
            // 
            // deleted_selected_prize_btn
            // 
            this.deleted_selected_prize_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleted_selected_prize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.deleted_selected_prize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.deleted_selected_prize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleted_selected_prize_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleted_selected_prize_btn.Location = new System.Drawing.Point(685, 280);
            this.deleted_selected_prize_btn.Name = "deleted_selected_prize_btn";
            this.deleted_selected_prize_btn.Size = new System.Drawing.Size(130, 65);
            this.deleted_selected_prize_btn.TabIndex = 24;
            this.deleted_selected_prize_btn.Text = "Delete Selected";
            this.deleted_selected_prize_btn.UseVisualStyleBackColor = true;
            // 
            // Prizes_label
            // 
            this.Prizes_label.AutoSize = true;
            this.Prizes_label.BackColor = System.Drawing.Color.Transparent;
            this.Prizes_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prizes_label.ForeColor = System.Drawing.Color.Black;
            this.Prizes_label.Location = new System.Drawing.Point(400, 212);
            this.Prizes_label.Name = "Prizes_label";
            this.Prizes_label.Size = new System.Drawing.Size(158, 24);
            this.Prizes_label.TabIndex = 23;
            this.Prizes_label.Text = "Teams / Player";
            // 
            // Prizes_listbx
            // 
            this.Prizes_listbx.BackColor = System.Drawing.Color.Gainsboro;
            this.Prizes_listbx.FormattingEnabled = true;
            this.Prizes_listbx.ItemHeight = 24;
            this.Prizes_listbx.Location = new System.Drawing.Point(400, 240);
            this.Prizes_listbx.Name = "Prizes_listbx";
            this.Prizes_listbx.Size = new System.Drawing.Size(279, 148);
            this.Prizes_listbx.TabIndex = 22;
            // 
            // Create_Tour_Btn
            // 
            this.Create_Tour_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Create_Tour_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Create_Tour_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Create_Tour_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Tour_Btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Create_Tour_Btn.Location = new System.Drawing.Point(291, 422);
            this.Create_Tour_Btn.Name = "Create_Tour_Btn";
            this.Create_Tour_Btn.Size = new System.Drawing.Size(228, 46);
            this.Create_Tour_Btn.TabIndex = 25;
            this.Create_Tour_Btn.Text = "Create Tournament";
            this.Create_Tour_Btn.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(827, 473);
            this.Controls.Add(this.Create_Tour_Btn);
            this.Controls.Add(this.deleted_selected_prize_btn);
            this.Controls.Add(this.Prizes_label);
            this.Controls.Add(this.Prizes_listbx);
            this.Controls.Add(this.delete_selected_plyr_btn);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Tour_Player_listBox);
            this.Controls.Add(this.create_prize_btn);
            this.Controls.Add(this.Add_Team_btn);
            this.Controls.Add(this.create_new_team_link);
            this.Controls.Add(this.select_team_dropdown);
            this.Controls.Add(this.create_tour_select_label);
            this.Controls.Add(this.Entry_Fee_txtbx);
            this.Controls.Add(this.Entry_fee_label);
            this.Controls.Add(this.Tr_Name_txtbx);
            this.Controls.Add(this.Tournament_Name_label);
            this.Controls.Add(this.Tournament_Label);
            this.Controls.Add(this.Tor_Name_label);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateTournamentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tor_Name_label;
        private System.Windows.Forms.Label Tournament_Label;
        private System.Windows.Forms.Label Tournament_Name_label;
        private System.Windows.Forms.TextBox Tr_Name_txtbx;
        private System.Windows.Forms.TextBox Entry_Fee_txtbx;
        private System.Windows.Forms.Label Entry_fee_label;
        private System.Windows.Forms.Label create_tour_select_label;
        private System.Windows.Forms.ComboBox select_team_dropdown;
        private System.Windows.Forms.LinkLabel create_new_team_link;
        private System.Windows.Forms.Button Add_Team_btn;
        private System.Windows.Forms.Button create_prize_btn;
        private System.Windows.Forms.ListBox Tour_Player_listBox;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Button delete_selected_plyr_btn;
        private System.Windows.Forms.Button deleted_selected_prize_btn;
        private System.Windows.Forms.Label Prizes_label;
        private System.Windows.Forms.ListBox Prizes_listbx;
        private System.Windows.Forms.Button Create_Tour_Btn;
    }
}