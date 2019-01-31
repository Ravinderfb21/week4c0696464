using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4c0696464
{
    class program
    {
        public program()
        {
        }
    }

    class Village
{
    public static int numberOfVillages = 0;
    public Village nextVillage;
    public Village previousVillage;
    public string VillageNmae;
    public bool isAstrildeHere = false;
        private bool isAstrildHere;

        public Village()
    {
        Village.numberOfVillages++;
    }

        class Countryside
        {
            public Village Maple;
            public Village Toronto;
            public Village Ajax;

            
            public void MapInitializer()
            {
                Maple = new Village();
                Maple.VillageName = "Maple";
                Maple.previousVillage = null;
                Maple.nextVillage = Toronto;

                Toronto = new Village();
                Toronto.VillageName = "Toronto";
                Toronto.previousVillage = Maple;
                Toronto.nextVillage = Ajax;


                Ajax = new Village();
                Ajax.VillageName = "Ajax";
                Ajax.previousVillage = Toronto;
                Ajax.nextVillage = null;
                Ajax.isAstrildHere = true;


            }

            public void
        }

}
       
 }
 