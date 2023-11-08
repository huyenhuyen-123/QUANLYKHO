using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QLK.model
{
    internal class HangHoa
    {
        private String ID;
        private String NAME;
        private String UNIT;
        public HangHoa() { }
        public HangHoa(String ID, String NAME, String UNIT)
        {
            this.ID = ID;
            this.NAME = NAME;
            this.UNIT = UNIT;
        }
        public String getID() { return ID; }
        public String getNAME() { return NAME; }
        public void setID(String ID) { this.ID = ID; }
        public void setNAME(String NAME) { this.NAME = NAME; }
        public String getUNIT() { return UNIT; }
        public void setUNIT(String UNIT) { this.UNIT = UNIT; }
        public String toString()
        {
            return ID + NAME;
        }
    }
}

