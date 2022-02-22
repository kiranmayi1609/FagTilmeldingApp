using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmeldingApp.Codes
{
    //abstrakt indkapsler school-Det kan være base klass(parent class)
    internal abstract class School
    {
        public string schoolnavn { get; set; }

        protected School(string schoolnavn)
        {
            this.schoolnavn = schoolnavn;
        }
    }
}
