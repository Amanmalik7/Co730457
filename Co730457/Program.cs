using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co730457
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Village
    {
        //Node is an ADT
        // what KIND of DATA do we Need in a Node?
        public Village nextVillage;
        public Village previousVillage;
        public string Villagename;
        public bool isAstrildeHere = false;

    }
    class countryside
    {
        Village Maple = new Village();
        Village Toronto = new Village();
        Village Ajax = new Village();

        Village First;
        Village Last;

        public void launch()
        {
            Maple.Villagename = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
            Toronto.Villagename = "Toronto:";
            Toronto.nextVillage = Maple;
            Toronto.previousVillage = Maple;
            Ajax.Villagename = " Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = Toronto;
            



        }
    }
}
