using Microsoft.EntityFrameworkCore;
using TP2NASA.Data;
using TP2NASA.Models;

namespace TP2NASA.Services
{
    /// <summary>
    /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
    /// Description: Classe qui permet de gérer les injections de services au site.
    /// Date: 11-25-2022
    /// </summary>
    public class PlanèteService : IPlanèteService
    {
        #region Champs
        private PlanètesContext? _context = null;
        private IPlanèteService.Mode _mode = IPlanèteService.Mode.BD;
        #endregion

        #region Constructeur
        /// <summary>
        /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
        /// Description: Constructeur qui prépares les services de Mode et Context
        /// Date: 11-25-2022
        /// </summary>
        public PlanèteService(IPlanèteService.Mode mode, PlanètesContext context)
        {
            _mode = mode;
            _context = context;
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
        /// Description: Méthode permettant de mettre en liste les noms des planètes de la base de données.
        /// Date: 11-25-2022
        /// </summary>
        public Planète[] Lister()
        {
                return _context!.Planètes.Include(planète => planète.Image).ToArray();
        }

        /// <summary>
        /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
        /// Description: Méthode permettant de trouver une planète dans la base de donnée
        /// Date: 11-25-2022
        /// </summary>
        public Planète Trouver(int iNoPlanète)
        {
          
                return _context!.Planètes.Include(planète => planète.Caractéristique).
                FirstOrDefault(planète => planète.NoPlanète == iNoPlanète)!;
           
        }

        /// <summary>
        /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
        /// Description: Méthode permettant d'envoyer les données saisies dans le sondage.
        /// Date: 11-25-2022
        /// </summary>
        public bool Envoyer(Sondage sondage)
        {
            return false;
        }
        #endregion
    }
}
