using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Pesaresi.Luca._5i.XMLReadWrite
{
    public class Persona
    {
        public string cognome { get; set; }
        public string nome { get; set; }
        public string telefono { get; set; }
        public string indirizzo { get; set; }

        public Persona()
        {

        }
        public Persona(XElement e)
        {
            nome = e.Attribute("nome").Value;
            cognome = e.Attribute("cognome").Value;
            telefono = e.Attribute("telefono").Value;
            indirizzo = e.Attribute("indirizzo").Value;
        }

        public Persona(string Nome, string Cognome, string Telefono, string Indirizzo)
        {
            nome = Nome;
            cognome = Cognome;
            telefono = Telefono;
            indirizzo = Indirizzo;
        }
    }

}
