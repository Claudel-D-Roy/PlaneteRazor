namespace TP2NASA.Models
{
    /// <summary>
    /// Auteur: Claudel D. Roy, William Jubinville, Mathieu Duval
    /// Description: Classe contenant les membres pour les caractéristiques des planètes
    /// Date: 11-25-2022
    /// </summary>
    public class Caractéristique
	{
		#region Propriété
		public int ID { get; set; }
		public string? Catégorie { get; set; }
		public string? Nom { get; set; }
		public decimal Valeur { get; set; }
		public string? MesureHtml { get; set; }
		public int PlanèteID { get; set; }
		#endregion
	}
}
