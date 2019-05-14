using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDGui
{
    enum GameState
    {
        PCGen,
        OppGen,
        Combat,
        End,
    };
    
    public partial class Form1 : Form
    {
        GameState state = GameState.PCGen;
        Character player = new Character();
        Character enemy = new Character("Kobold");
        Boolean weaponSelected = false;
        int weaponselection = 0;
        Character attacker;
        Character defender;
        Character temp;
        public Form1()
        {
            InitializeComponent();
        }

        public void Push_Message(string mess)
        {
            CombatLog5.Text = CombatLog4.Text;
            CombatLog4.Text = CombatLog3.Text;
            CombatLog3.Text = CombatLog2.Text;
            CombatLog2.Text = CombatLog1.Text;
            CombatLog1.Text = mess;
        }

        private void playerNameBox_TextChanged(object sender, EventArgs e)
        {
            if (playerNameBox.Text != "" && weaponSelected == true)
                playButton.Enabled = true;
            else
                playButton.Enabled = false;
        }

        private void UpdateStats(Character creature, Label strlab, Label dexlab, Label conlab, Label hplab, Label weaplab)
        {
            //update the stats labels for creature
            strlab.Text = "Str: " + creature.STR.ToString();
            dexlab.Text = "Dex: " + creature.DEX.ToString();
            conlab.Text = "Con: " + creature.CON.ToString();
            hplab.Text = creature.HP.ToString();
            weaplab.Text = "Weapon: " + creature.Weapon.Name.ToString();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //if there is no PC name and they somehow managed to click this, exit
            if(state == GameState.PCGen)
                if (playerNameBox.Text == "" || weaponSelected == false)
                    return;
            if (state == GameState.End)
                Application.Exit();

            switch(state)
            {
                case GameState.PCGen:
                    player.Name = playerNameBox.Text;
                    player.SetStats();
                    player.SetWeapon(weaponselection);
                    PCNameNotification.Text = "Character:";
                    playerNameBox.Enabled = false;
                    UpdateStats(player,StrLabel,DexLabel,ConLabel,CurrHPLabel,EquippedWeaponLabel);
                    playButton.Text = "Create Enemy";
                    LongswordRadio.Enabled = false;
                    DaggerRadio.Enabled = false;
                    GreataxeRadio.Enabled = false;
                    state = GameState.OppGen;
                    break;
                case GameState.OppGen:
                    enemy.SetStats();
                    enemy.SetWeapon(Random.RandomNumberGenerator(1, 3));
                    EnemyNameLabel.Text = "Enemy:";
                    EnemyNameBox.Text = enemy.Name;
                    UpdateStats(enemy, EnemyStrLabel, EnemyDexLabel, EnemyConLabel, EnemyCurrHPLabel, EnemyEquippedWeaponLabel);
                    playButton.Text = "Fight!";
                    state = GameState.Combat;
                    attacker = player;
                    defender = enemy;
                    break;
                case GameState.Combat:
                    Combat.Attack(attacker, defender, this);
                    UpdateStats(player, StrLabel, DexLabel, ConLabel, CurrHPLabel, EquippedWeaponLabel);
                    UpdateStats(enemy, EnemyStrLabel, EnemyDexLabel, EnemyConLabel, EnemyCurrHPLabel, EnemyEquippedWeaponLabel);
                    temp = defender;
                    defender = attacker;
                    attacker = temp;
                    if (player.HP <= 0)
                    {
                        Push_Message("You Died.");
                        state = GameState.End;
                        playButton.Text = "Exit";
                    }
                    else if (enemy.HP <= 0)
                    {
                        Push_Message("You win!");
                        state = GameState.End;
                        playButton.Text = "Exit";
                    }
                    break;
            }
        }

        private void Weapon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton send = (RadioButton)sender;
            if (send.Text == "Dagger")
                weaponselection = 3;
            else if (send.Text == "Greataxe")
                weaponselection = 2;
            else
                weaponselection = 1;
            weaponSelected = true;
            if (playerNameBox.Text != "" && weaponSelected == true)
                playButton.Enabled = true;
            else
                playButton.Enabled = false;
        }
    }
}
