using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmeldingApp.Codes
{   
    //det er sealed sidst nedarvning og semester derived class af school 
    internal sealed class Semester:School
    {
        
        public string? SemesterNavn { get;set; }
       //Det er en konstructor -inheritance af parent class
        public Semester(string? schoolnavn,string? semesterNavn):base(schoolnavn)
            
        {
            SemesterNavn = semesterNavn;
             
        }
        
        
     


    }
}
