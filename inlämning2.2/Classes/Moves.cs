namespace inlämning2._2.Classes
{
    public enum Movez
    {
        Shoot,
        Reload,
        Block,
        Shotgun,

    }
    public abstract class Moves
    {
        public abstract int Shellcount { get; set; }
        public abstract Movez Movez { get; set; }
        public virtual Moves Shoot(Moves moves)
        {
            moves.Movez = Movez.Shoot;
            moves.Shellcount--;
            return moves;
        }
        public virtual Moves Reload(Moves moves)
        {
            moves.Movez = Movez.Reload;
            moves.Shellcount++;
            return moves;
            
        }
        public virtual Moves Block(Moves moves)
        {
            moves.Movez = Movez.Block;
            return moves;
            
        }
        public virtual Moves Shotgun(Moves moves)
        {
            moves.Movez = Movez.Shotgun;
            return moves;
        }

    } 
}
