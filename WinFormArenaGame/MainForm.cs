using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace WinFormArenaGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void gameNotification(GameEngine.NotificationArgs args)
        {
            TextBox tbAttacker;
            if (args.Attacker is Knight || args.Attacker is Goblin)
                tbAttacker = tbKnight;
            else
                tbAttacker = tbAssassin;

            tbAttacker.AppendText(
                $"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.\r\n");

            DateTime dt = DateTime.Now;
            
            while (DateTime.Now - dt < TimeSpan.FromMilliseconds(300))
            {
                Application.DoEvents();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lbWinner.Text = "";
            tbAssassin.Text = "";
            tbKnight.Text = "";
            lbWinner.Visible = false;

            GameEngine gameEngine = new GameEngine()
            {
                HeroA = new Wizard("Wizzy", 10, 20, new MagicWand("magicwand")),
                HeroB = new Goblin("Goby", 10, 5, new TomaHawk("tomahawk")),
                NotificationsCallBack = gameNotification
            };

            imgFight.Enabled = true;
            gameEngine.Fight();
            imgFight.Enabled = false;

            lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
            lbWinner.Visible = true;
        }

        private void lbWinner_Click(object sender, EventArgs e)
        {

        }
    }
}