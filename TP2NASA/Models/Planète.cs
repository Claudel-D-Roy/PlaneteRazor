using System.Collections.Generic;
using System.ComponentModel;

namespace TP2NASA.Models
{
    /// <summary>
    /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
    /// Description: Classe contenant les membres décrivant les planètes
    /// Date: 11-25-2022
    /// </summary>
    public class Planète
    {
        #region Propriétés
        public int ID { get; set; }
        public string? Nom { get; set; }
        public string? Description { get; set; }
        public int ImageID { get; set; }
        public int NbSatellites { get; set; }
        public int NoPlanète { get; set; }
        public string? Résumé { get; set; }
        public float Révolution { get; set; }
        public Image? Image { get; set; }
        public List<Caractéristique>? Caractéristique { get; set; }
        #endregion
    }
}
