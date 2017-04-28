using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Pesaresi.Luca._5i.XMLReadWrite.Models
{
    public class Persone : List<Persona>
    {
        public string FileName { get; }
        public XElement XML { get; set; }

        public Persone(string fileName)
        {
            FileName = fileName;
            XML = XElement.Load(FileName);
            AddRange(
                from item in XML.Elements("Persona")
                select new Persona(item)
            );
        }

        public void Salva()
        {
            Persona m = new Persona { nome = "Luca", cognome = "Pesaresi", telefono = "3459202169", indirizzo = "Via Dario Campana" };
            XML.Add(new XElement("Persona",
                         new XAttribute("nome", m.nome),
                         new XAttribute("cognome", m.cognome),
                         new XAttribute("indirizzo", m.indirizzo),
                         new XAttribute("telefono", m.telefono)
                    )
                );
            XML.Save(FileName);
        }
    }
}