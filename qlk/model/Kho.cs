using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLK.model
{
    internal class Kho
    {
        private String ID;
        private String NAME;
        private String ADDRESS;
        public Kho() { }
        public Kho(String ID, String NAME, String ADDRESS)
        {
            this.ID = ID;
            this.NAME = NAME;
            this.ADDRESS = ADDRESS;
        }
        public String getID() { return ID; }
        public String getNAME() { return NAME; }
        public void setID(String ID) { this.ID = ID; }
        public void setNAME(String NAME) { this.NAME = NAME; }
        public String getADDRESS() { return ADDRESS; }
        public void setADDRESS(String ADDRESS) { this.ADDRESS = ADDRESS; }
        public String toString()
        {
            return ID + NAME;
        }

    }
}
