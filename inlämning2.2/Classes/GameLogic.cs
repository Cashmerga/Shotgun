namespace inlämning2._2.Classes
{

    public class GameLogic
    {


        public void MovesRules(Player player, Npc npc)
        {

            if (player.Movez == Movez.Shoot && npc.Movez == Movez.Shoot)
            {
                return;
            }



            if (player.Movez == Movez.Shoot && npc.Movez != Movez.Block)
            {
                player.Shotgun(npc);
            }
            else if (player.Movez == Movez.Shoot && npc.Movez == Movez.Block)
            {
                npc.Block(npc);
            }
            


            if (npc.Movez == Movez.Shoot && player.Movez != Movez.Block)
            {
                npc.Shotgun(player);
            }
            else if (npc.Movez == Movez.Shoot && player.Movez == Movez.Block)
            {
                player.Block(player);
            }
            

        }

        public void WinCondition(Player player, Npc npc)
        {
            if (player.Shellcount == 3)
            {
                player.Shotgun(npc);
            }
            else if (npc.Shellcount == 3)
            {
                npc.Shotgun(player);
            }



        }
    }
}
