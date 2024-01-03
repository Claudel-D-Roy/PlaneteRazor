using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace TP2NASA.Models.Sondages
{
    /// <summary>
    /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
    /// Description: Classe contenant les éléments pour la validation des champs du sondage maison
    /// Date: 11-25-2022
    /// </summary>
    public class SondageViewModel : Sondage, IValidatableObject
    {
        #region Propriétés
        [Required(ErrorMessage = "Votre prénom est manquant!")]
        new public string? Prénom { get => base.Prénom; set => base.Prénom = value; }
        [Required(ErrorMessage = "Votre nom est manquant!")]
        new public string? Nom { get => base.Nom; set => base.Nom = value; }
        [RegularExpression("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2,5}$", ErrorMessage = "Mauvais format de courriel!")]
        new public string? Courriel { get => base.Courriel; set => base.Courriel = value; } // faire la validation avec Informé dans le JS 
        [Required(ErrorMessage = "Vous devez cocher votre niveau de connaissance!")]
        new public int Niveau { get => base.Niveau; set => base.Niveau = value; }
        [DataType(DataType.Date)]
        new public DateTime? DernièreVisite { get => base.DernièreVisite; set => base.DernièreVisite = value; }
        [RegularExpression(@"^[A-Z]\d{3}[-][A-Z]{4}[-]\d[A-Z]$", ErrorMessage = "Veuillez respecter le format demandé.")]
        new public string? CodePromo { get => base.CodePromo; set => base.CodePromo = value; }
        #endregion

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Informé && Courriel == null || Courriel == "")
                yield return new ValidationResult("Le courriel doit être spécifié pour recevoir les nouvelles!");
            else
            {
                yield return new ValidationResult("Votre sondage a éte envoyé!");
            }
        }
    }
}
