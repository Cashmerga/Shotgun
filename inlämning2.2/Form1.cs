using inlämning2._2.Classes;

namespace inlämning2._2
{
    public partial class FormShotgun : Form
    {
        Player player = new Player();
        Npc npc = new Npc();
        GameLogic gameLogic = new GameLogic();
        public FormShotgun()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SCPlayer.Text = "0";
            SCNpc.Text = "0";
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            if (player.Shellcount > 0)
            {
                player.Shoot(player);
                SCPlayer.Text = player.Shellcount.ToString();
                History.Items.Add("Player Shoots");

                string npcHistory = "";
                Npc.Choice(npc, ref npcHistory);
                History.Items.Add(npcHistory);
                SCNpc.Text = npc.Shellcount.ToString();

                gameLogic.MovesRules(player, npc);
                gameLogic.WinCondition(player, npc);
            }
            else
            {
                MessageBox.Show("You dont have any shells :(");
            }
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            player.Block(player);
            History.Items.Add("Player Blocks");


            string npcHistory = "";
            Npc.Choice(npc, ref npcHistory);
            History.Items.Add(npcHistory);
            SCNpc.Text = npc.Shellcount.ToString();

            gameLogic.MovesRules(player, npc);
            gameLogic.WinCondition(player, npc);

        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            player.Reload(player);
            SCPlayer.Text = player.Shellcount.ToString();
            History.Items.Add("Player Reloads");

            string npcHistory = "";
            Npc.Choice(npc, ref npcHistory);
            History.Items.Add(npcHistory);
            SCNpc.Text = npc.Shellcount.ToString();

            gameLogic.MovesRules(player, npc);
            gameLogic.WinCondition(player, npc);

        }


    }


}
