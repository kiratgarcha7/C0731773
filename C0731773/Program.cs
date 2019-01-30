using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731773
{
    class Program
    {

    }
    class Village
    {
        public Village nextVillage;
        public String VillageName;
        public bool isAstrildeHere = false;
    }
    class Countryside
    {
        Village Maple = new Village();      
        Village Toronto = new Village();
        Village Ajax = new Village();
        Village First;
        Village Last;
        

        public void Launch()
        {
            Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.previousVillage = Maple;
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = Toronto;
        }
    }
    
}
