namespace inlämning2._2.Classes
{


    public class Player : Moves
    {
        public override int Shellcount { get; set; }
        public override Movez Movez { get; set; }

        public override Moves Shoot(Moves moves)
        {
            moves.Shellcount--;
            moves.Movez = Movez.Shoot;
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
            if ((MessageBox.Show("Play Again? ", "Player Won!", MessageBoxButtons.YesNo)) ==
                DialogResult.Yes)
            {
                Application.Restart();
            }
            else Application.Exit();
            
            return moves;
        }
    }
}
