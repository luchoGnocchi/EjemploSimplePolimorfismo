using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Uva
    {
        public int diasNecesariosCosecha { get; set; }
        public string origen { get; set; }
        public int porcentajeAzucar { get; set; }
        public string epoca { get; set; }
        public int diasSol { get; set; }
        public virtual string calidad()
        {
            return "";
        }
    }
    public class Tannat : Uva
    {
        public bool polilla_vid { get; set; }

        override
        public string calidad()
        {
            if (!polilla_vid && diasSol > 250)
                return "Optima";
            if ((polilla_vid && diasSol > 250) || !polilla_vid)
                return "Media";
            else
                return "Mala calidad";
        }


    }
    public class Moscatel : Uva
    {
        public bool saltaMontes { get; set; }
        override
public string calidad()
        {
            if (!saltaMontes && diasSol > 200)
                return "Optima";
            if ((saltaMontes && diasSol > 200) || !saltaMontes)
                return "Media";
            else
                return "Mala calidad";
        }

    }
    public class Chinche : Uva
    {
        public bool polilla_vid { get; set; }
        public bool saltaMontes { get; set; }
        override
        public string calidad()
        {
            if (!saltaMontes && diasSol > 300 &&!polilla_vid)
                return "Optima";
            if ((saltaMontes && diasSol > 300 && !polilla_vid) || (!saltaMontes && diasSol > 300 && polilla_vid )|| (!saltaMontes && !polilla_vid))
                return "Media";
            else
                return "Mala calidad";
        }

    }
    public class NuevoTipo : Uva
    {
        override
        public string calidad()
        {
            if (diasSol>100)
                return "Optima";
            else
                return "Mala calidad";
        }

    }
    public class Cosecha
    {
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int cantidad { get; set; }
        public string Calidad { get; set; }
    }


}
