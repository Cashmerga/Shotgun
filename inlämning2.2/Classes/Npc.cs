namespace inlämning2._2.Classes
{
    public class Npc : Moves
    {
        public override int Shellcount { get; set; }
        public override Movez Movez { get; set; }

        public override Moves Shoot(Moves moves)
        {
            moves.Movez = Movez.Shoot;
            moves.Shellcount--;
            return moves;
        }
        public override Moves Reload(Moves moves)
        {
            moves.Movez = Movez.Reload;
            moves.Shellcount++;
            return moves;
        }
        public override Moves Block(Moves moves)
        {
            moves.Movez = Movez.Block;
            return moves;
        }
        public override Moves Shotgun(Moves moves)
        {
            moves.Movez = Movez.Shotgun;
            if ((MessageBox.Show("Play Again? ", "NPC Won!", MessageBoxButtons.YesNo)) ==
                DialogResult.Yes)
            {
                Application.Restart();
            }
            else Application.Exit();
           

            return moves;
        }

        public static void Choice(Moves moves, ref string npcHistory)
        {

            Random random = new Random();
            int rmoves = random.Next(0, 3);
            if (moves.Shellcount == 0)
            {
                rmoves = random.Next(1, 3);
            }

            switch (rmoves)
            {
                case 0:
                    moves.Shoot(moves);
                    npcHistory = "Npc Shoots";
                    break;


                case 1:
                    moves.Block(moves);
                    npcHistory = "Npc Blocked";
                    break;
                case 2:
                    moves.Reload(moves);
                    npcHistory = "Npc Reloaded";
                    break;


            }



        }


    }
}
