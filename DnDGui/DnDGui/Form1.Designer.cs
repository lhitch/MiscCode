namespace DnDGui
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
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.PCNameNotification = new System.Windows.Forms.Label();
            this.LongswordRadio = new System.Windows.Forms.RadioButton();
            this.GreataxeRadio = new System.Windows.Forms.RadioButton();
            this.DaggerRadio = new System.Windows.Forms.RadioButton();
            this.WeaponSelectPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Statslabel = new System.Windows.Forms.Label();
            this.StatsPanel = new System.Windows.Forms.Panel();
            this.StrLabel = new System.Windows.Forms.Label();
            this.DexLabel = new System.Windows.Forms.Label();
            this.ConLabel = new System.Windows.Forms.Label();
            this.HPLabel = new System.Windows.Forms.Label();
            this.CurrHPLabel = new System.Windows.Forms.Label();
            this.EquippedWeaponLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EnemyEquippedWeaponLabel = new System.Windows.Forms.Label();
            this.EnemyCurrHPLabel = new System.Windows.Forms.Label();
            this.EnemyHPLabel = new System.Windows.Forms.Label();
            this.EnemyConLabel = new System.Windows.Forms.Label();
            this.EnemyDexLabel = new System.Windows.Forms.Label();
            this.EnemyStrLabel = new System.Windows.Forms.Label();
            this.EnemyStatsLabel = new System.Windows.Forms.Label();
            this.EnemyNameLabel = new System.Windows.Forms.Label();
            this.EnemyNameBox = new System.Windows.Forms.TextBox();
            this.CombatLog5 = new System.Windows.Forms.Label();
            this.CombatLog4 = new System.Windows.Forms.Label();
            this.CombatLog3 = new System.Windows.Forms.Label();
            this.CombatLog2 = new System.Windows.Forms.Label();
            this.CombatLog1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WeaponSelectPanel.SuspendLayout();
            this.StatsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerNameBox
            // 
            this.playerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameBox.Location = new System.Drawing.Point(15, 44);
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(174, 22);
            this.playerNameBox.TabIndex = 0;
            this.playerNameBox.TextChanged += new System.EventHandler(this.playerNameBox_TextChanged);
            // 
            // playButton
            // 
            this.playButton.Enabled = false;
            this.playButton.Location = new System.Drawing.Point(195, 150);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(97, 41);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Create PC";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // PCNameNotification
            // 
            this.PCNameNotification.AutoSize = true;
            this.PCNameNotification.Location = new System.Drawing.Point(12, 28);
            this.PCNameNotification.Name = "PCNameNotification";
            this.PCNameNotification.Size = new System.Drawing.Size(176, 13);
            this.PCNameNotification.TabIndex = 2;
            this.PCNameNotification.Text = "Enter your character\'s name to play.";
            // 
            // LongswordRadio
            // 
            this.LongswordRadio.AutoSize = true;
            this.LongswordRadio.Location = new System.Drawing.Point(6, 25);
            this.LongswordRadio.Name = "LongswordRadio";
            this.LongswordRadio.Size = new System.Drawing.Size(77, 17);
            this.LongswordRadio.TabIndex = 3;
            this.LongswordRadio.TabStop = true;
            this.LongswordRadio.Text = "Longsword";
            this.LongswordRadio.UseVisualStyleBackColor = true;
            this.LongswordRadio.CheckedChanged += new System.EventHandler(this.Weapon_CheckedChanged);
            // 
            // GreataxeRadio
            // 
            this.GreataxeRadio.AutoSize = true;
            this.GreataxeRadio.Location = new System.Drawing.Point(6, 48);
            this.GreataxeRadio.Name = "GreataxeRadio";
            this.GreataxeRadio.Size = new System.Drawing.Size(68, 17);
            this.GreataxeRadio.TabIndex = 4;
            this.GreataxeRadio.TabStop = true;
            this.GreataxeRadio.Text = "Greataxe";
            this.GreataxeRadio.UseVisualStyleBackColor = true;
            this.GreataxeRadio.CheckedChanged += new System.EventHandler(this.Weapon_CheckedChanged);
            // 
            // DaggerRadio
            // 
            this.DaggerRadio.AutoSize = true;
            this.DaggerRadio.Location = new System.Drawing.Point(6, 71);
            this.DaggerRadio.Name = "DaggerRadio";
            this.DaggerRadio.Size = new System.Drawing.Size(60, 17);
            this.DaggerRadio.TabIndex = 5;
            this.DaggerRadio.TabStop = true;
            this.DaggerRadio.Text = "Dagger";
            this.DaggerRadio.UseVisualStyleBackColor = true;
            this.DaggerRadio.CheckedChanged += new System.EventHandler(this.Weapon_CheckedChanged);
            // 
            // WeaponSelectPanel
            // 
            this.WeaponSelectPanel.Controls.Add(this.label1);
            this.WeaponSelectPanel.Controls.Add(this.LongswordRadio);
            this.WeaponSelectPanel.Controls.Add(this.DaggerRadio);
            this.WeaponSelectPanel.Controls.Add(this.GreataxeRadio);
            this.WeaponSelectPanel.Location = new System.Drawing.Point(195, 44);
            this.WeaponSelectPanel.Name = "WeaponSelectPanel";
            this.WeaponSelectPanel.Size = new System.Drawing.Size(97, 100);
            this.WeaponSelectPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a weapon";
            // 
            // Statslabel
            // 
            this.Statslabel.AutoSize = true;
            this.Statslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statslabel.Location = new System.Drawing.Point(3, 0);
            this.Statslabel.Name = "Statslabel";
            this.Statslabel.Size = new System.Drawing.Size(37, 15);
            this.Statslabel.TabIndex = 7;
            this.Statslabel.Text = "Stats:";
            // 
            // StatsPanel
            // 
            this.StatsPanel.Controls.Add(this.EquippedWeaponLabel);
            this.StatsPanel.Controls.Add(this.CurrHPLabel);
            this.StatsPanel.Controls.Add(this.HPLabel);
            this.StatsPanel.Controls.Add(this.ConLabel);
            this.StatsPanel.Controls.Add(this.DexLabel);
            this.StatsPanel.Controls.Add(this.StrLabel);
            this.StatsPanel.Controls.Add(this.Statslabel);
            this.StatsPanel.Location = new System.Drawing.Point(15, 72);
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.Size = new System.Drawing.Size(174, 142);
            this.StatsPanel.TabIndex = 8;
            // 
            // StrLabel
            // 
            this.StrLabel.AutoSize = true;
            this.StrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrLabel.Location = new System.Drawing.Point(3, 40);
            this.StrLabel.Name = "StrLabel";
            this.StrLabel.Size = new System.Drawing.Size(28, 15);
            this.StrLabel.TabIndex = 8;
            this.StrLabel.Text = "Str: ";
            // 
            // DexLabel
            // 
            this.DexLabel.AutoSize = true;
            this.DexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexLabel.Location = new System.Drawing.Point(3, 55);
            this.DexLabel.Name = "DexLabel";
            this.DexLabel.Size = new System.Drawing.Size(32, 15);
            this.DexLabel.TabIndex = 9;
            this.DexLabel.Text = "Dex:";
            // 
            // ConLabel
            // 
            this.ConLabel.AutoSize = true;
            this.ConLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConLabel.Location = new System.Drawing.Point(3, 70);
            this.ConLabel.Name = "ConLabel";
            this.ConLabel.Size = new System.Drawing.Size(35, 15);
            this.ConLabel.TabIndex = 10;
            this.ConLabel.Text = "Con: ";
            // 
            // HPLabel
            // 
            this.HPLabel.AutoSize = true;
            this.HPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPLabel.Location = new System.Drawing.Point(3, 15);
            this.HPLabel.Name = "HPLabel";
            this.HPLabel.Size = new System.Drawing.Size(27, 15);
            this.HPLabel.TabIndex = 11;
            this.HPLabel.Text = "HP:";
            // 
            // CurrHPLabel
            // 
            this.CurrHPLabel.AutoSize = true;
            this.CurrHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrHPLabel.Location = new System.Drawing.Point(27, 15);
            this.CurrHPLabel.Name = "CurrHPLabel";
            this.CurrHPLabel.Size = new System.Drawing.Size(14, 15);
            this.CurrHPLabel.TabIndex = 12;
            this.CurrHPLabel.Text = "0";
            // 
            // EquippedWeaponLabel
            // 
            this.EquippedWeaponLabel.AutoSize = true;
            this.EquippedWeaponLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquippedWeaponLabel.Location = new System.Drawing.Point(3, 94);
            this.EquippedWeaponLabel.Name = "EquippedWeaponLabel";
            this.EquippedWeaponLabel.Size = new System.Drawing.Size(59, 15);
            this.EquippedWeaponLabel.TabIndex = 13;
            this.EquippedWeaponLabel.Text = "Weapon: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EnemyEquippedWeaponLabel);
            this.panel1.Controls.Add(this.EnemyCurrHPLabel);
            this.panel1.Controls.Add(this.EnemyHPLabel);
            this.panel1.Controls.Add(this.EnemyConLabel);
            this.panel1.Controls.Add(this.EnemyDexLabel);
            this.panel1.Controls.Add(this.EnemyStrLabel);
            this.panel1.Controls.Add(this.EnemyStatsLabel);
            this.panel1.Location = new System.Drawing.Point(298, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 142);
            this.panel1.TabIndex = 9;
            // 
            // EnemyEquippedWeaponLabel
            // 
            this.EnemyEquippedWeaponLabel.AutoSize = true;
            this.EnemyEquippedWeaponLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyEquippedWeaponLabel.Location = new System.Drawing.Point(3, 94);
            this.EnemyEquippedWeaponLabel.Name = "EnemyEquippedWeaponLabel";
            this.EnemyEquippedWeaponLabel.Size = new System.Drawing.Size(59, 15);
            this.EnemyEquippedWeaponLabel.TabIndex = 13;
            this.EnemyEquippedWeaponLabel.Text = "Weapon: ";
            // 
            // EnemyCurrHPLabel
            // 
            this.EnemyCurrHPLabel.AutoSize = true;
            this.EnemyCurrHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyCurrHPLabel.Location = new System.Drawing.Point(27, 15);
            this.EnemyCurrHPLabel.Name = "EnemyCurrHPLabel";
            this.EnemyCurrHPLabel.Size = new System.Drawing.Size(14, 15);
            this.EnemyCurrHPLabel.TabIndex = 12;
            this.EnemyCurrHPLabel.Text = "0";
            // 
            // EnemyHPLabel
            // 
            this.EnemyHPLabel.AutoSize = true;
            this.EnemyHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyHPLabel.Location = new System.Drawing.Point(3, 15);
            this.EnemyHPLabel.Name = "EnemyHPLabel";
            this.EnemyHPLabel.Size = new System.Drawing.Size(27, 15);
            this.EnemyHPLabel.TabIndex = 11;
            this.EnemyHPLabel.Text = "HP:";
            // 
            // EnemyConLabel
            // 
            this.EnemyConLabel.AutoSize = true;
            this.EnemyConLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyConLabel.Location = new System.Drawing.Point(3, 70);
            this.EnemyConLabel.Name = "EnemyConLabel";
            this.EnemyConLabel.Size = new System.Drawing.Size(35, 15);
            this.EnemyConLabel.TabIndex = 10;
            this.EnemyConLabel.Text = "Con: ";
            // 
            // EnemyDexLabel
            // 
            this.EnemyDexLabel.AutoSize = true;
            this.EnemyDexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyDexLabel.Location = new System.Drawing.Point(3, 55);
            this.EnemyDexLabel.Name = "EnemyDexLabel";
            this.EnemyDexLabel.Size = new System.Drawing.Size(32, 15);
            this.EnemyDexLabel.TabIndex = 9;
            this.EnemyDexLabel.Text = "Dex:";
            // 
            // EnemyStrLabel
            // 
            this.EnemyStrLabel.AutoSize = true;
            this.EnemyStrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyStrLabel.Location = new System.Drawing.Point(3, 40);
            this.EnemyStrLabel.Name = "EnemyStrLabel";
            this.EnemyStrLabel.Size = new System.Drawing.Size(28, 15);
            this.EnemyStrLabel.TabIndex = 8;
            this.EnemyStrLabel.Text = "Str: ";
            // 
            // EnemyStatsLabel
            // 
            this.EnemyStatsLabel.AutoSize = true;
            this.EnemyStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyStatsLabel.Location = new System.Drawing.Point(3, 0);
            this.EnemyStatsLabel.Name = "EnemyStatsLabel";
            this.EnemyStatsLabel.Size = new System.Drawing.Size(37, 15);
            this.EnemyStatsLabel.TabIndex = 7;
            this.EnemyStatsLabel.Text = "Stats:";
            // 
            // EnemyNameLabel
            // 
            this.EnemyNameLabel.AutoSize = true;
            this.EnemyNameLabel.Location = new System.Drawing.Point(301, 28);
            this.EnemyNameLabel.Name = "EnemyNameLabel";
            this.EnemyNameLabel.Size = new System.Drawing.Size(0, 13);
            this.EnemyNameLabel.TabIndex = 11;
            // 
            // EnemyNameBox
            // 
            this.EnemyNameBox.Enabled = false;
            this.EnemyNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyNameBox.Location = new System.Drawing.Point(298, 44);
            this.EnemyNameBox.Name = "EnemyNameBox";
            this.EnemyNameBox.Size = new System.Drawing.Size(174, 22);
            this.EnemyNameBox.TabIndex = 10;
            // 
            // CombatLog5
            // 
            this.CombatLog5.AutoSize = true;
            this.CombatLog5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombatLog5.Location = new System.Drawing.Point(6, 22);
            this.CombatLog5.Name = "CombatLog5";
            this.CombatLog5.Size = new System.Drawing.Size(0, 15);
            this.CombatLog5.TabIndex = 14;
            // 
            // CombatLog4
            // 
            this.CombatLog4.AutoSize = true;
            this.CombatLog4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombatLog4.Location = new System.Drawing.Point(6, 37);
            this.CombatLog4.Name = "CombatLog4";
            this.CombatLog4.Size = new System.Drawing.Size(0, 15);
            this.CombatLog4.TabIndex = 15;
            // 
            // CombatLog3
            // 
            this.CombatLog3.AutoSize = true;
            this.CombatLog3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombatLog3.Location = new System.Drawing.Point(6, 52);
            this.CombatLog3.Name = "CombatLog3";
            this.CombatLog3.Size = new System.Drawing.Size(0, 15);
            this.CombatLog3.TabIndex = 16;
            // 
            // CombatLog2
            // 
            this.CombatLog2.AutoSize = true;
            this.CombatLog2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombatLog2.Location = new System.Drawing.Point(6, 67);
            this.CombatLog2.Name = "CombatLog2";
            this.CombatLog2.Size = new System.Drawing.Size(0, 15);
            this.CombatLog2.TabIndex = 17;
            // 
            // CombatLog1
            // 
            this.CombatLog1.AutoSize = true;
            this.CombatLog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombatLog1.Location = new System.Drawing.Point(6, 82);
            this.CombatLog1.Name = "CombatLog1";
            this.CombatLog1.Size = new System.Drawing.Size(0, 15);
            this.CombatLog1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CombatLog5);
            this.groupBox1.Controls.Add(this.CombatLog4);
            this.groupBox1.Controls.Add(this.CombatLog3);
            this.groupBox1.Controls.Add(this.CombatLog2);
            this.groupBox1.Controls.Add(this.CombatLog1);
            this.groupBox1.Location = new System.Drawing.Point(92, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Combat Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EnemyNameLabel);
            this.Controls.Add(this.EnemyNameBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatsPanel);
            this.Controls.Add(this.WeaponSelectPanel);
            this.Controls.Add(this.PCNameNotification);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.playerNameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WeaponSelectPanel.ResumeLayout(false);
            this.WeaponSelectPanel.PerformLayout();
            this.StatsPanel.ResumeLayout(false);
            this.StatsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerNameBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label PCNameNotification;
        private System.Windows.Forms.RadioButton LongswordRadio;
        private System.Windows.Forms.RadioButton GreataxeRadio;
        private System.Windows.Forms.RadioButton DaggerRadio;
        private System.Windows.Forms.Panel WeaponSelectPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Statslabel;
        private System.Windows.Forms.Panel StatsPanel;
        private System.Windows.Forms.Label ConLabel;
        private System.Windows.Forms.Label DexLabel;
        private System.Windows.Forms.Label StrLabel;
        private System.Windows.Forms.Label EquippedWeaponLabel;
        private System.Windows.Forms.Label CurrHPLabel;
        private System.Windows.Forms.Label HPLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EnemyEquippedWeaponLabel;
        private System.Windows.Forms.Label EnemyCurrHPLabel;
        private System.Windows.Forms.Label EnemyHPLabel;
        private System.Windows.Forms.Label EnemyConLabel;
        private System.Windows.Forms.Label EnemyDexLabel;
        private System.Windows.Forms.Label EnemyStrLabel;
        private System.Windows.Forms.Label EnemyStatsLabel;
        private System.Windows.Forms.Label EnemyNameLabel;
        private System.Windows.Forms.TextBox EnemyNameBox;
        private System.Windows.Forms.Label CombatLog5;
        private System.Windows.Forms.Label CombatLog3;
        private System.Windows.Forms.Label CombatLog4;
        private System.Windows.Forms.Label CombatLog1;
        private System.Windows.Forms.Label CombatLog2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

