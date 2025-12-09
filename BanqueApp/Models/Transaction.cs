using System;
using System.ComponentModel.DataAnnotations;

namespace BanqueApp.Models
{
    public enum TypeTransaction
    {
        Depot,
        Retrait
    }

    public class Transaction
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public TypeTransaction Type { get; set; }

        public decimal Montant { get; set; }

        public string Description { get; set; } = string.Empty;

        // Foreign Key
        public int CompteId { get; set; }

        // Navigation property
        public Compte? Compte { get; set; }
    }
}
