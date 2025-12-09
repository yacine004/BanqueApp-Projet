using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BanqueApp.Models
{
    public enum TypeCompte
    {
        Epargne,
        Courant
    }

    public enum StatutCompte
    {
        Actif,
        Bloque
    }

    public class Compte
    {
        public int Id { get; set; }

        [Required]
        public string Numero { get; set; } = string.Empty;

        [Required]
        public string Titulaire { get; set; } = string.Empty;

        public TypeCompte TypeCompte { get; set; }

        public decimal SoldeActuel { get; set; }

        public DateTime DateCreation { get; set; }

        public DateTime? DateDeblocage { get; set; }

        public StatutCompte Statut { get; set; }

        // Navigation property
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
