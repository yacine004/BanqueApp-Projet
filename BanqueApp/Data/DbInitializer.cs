using BanqueApp.Models;
using System;
using System.Linq;

namespace BanqueApp.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            // Vérifier si la base de données contient déjà des données
            if (context.Comptes.Any())
            {
                return; // La base est déjà peuplée
            }

            // Créer 5 comptes
            var comptes = new Compte[]
            {
                new Compte
                {
                    Numero = "CPT001",
                    Titulaire = "Ahmed Benali",
                    TypeCompte = TypeCompte.Courant,
                    SoldeActuel = 15000,
                    DateCreation = DateTime.Now.AddYears(-3),
                    DateDeblocage = null,
                    Statut = StatutCompte.Actif
                },
                new Compte
                {
                    Numero = "CPT002",
                    Titulaire = "Fatima Zahra",
                    TypeCompte = TypeCompte.Epargne,
                    SoldeActuel = 45000,
                    DateCreation = DateTime.Now.AddYears(-5),
                    DateDeblocage = DateTime.Now.AddYears(1),
                    Statut = StatutCompte.Actif
                },
                new Compte
                {
                    Numero = "CPT003",
                    Titulaire = "Mohamed Alaoui",
                    TypeCompte = TypeCompte.Courant,
                    SoldeActuel = 8500,
                    DateCreation = DateTime.Now.AddYears(-2),
                    DateDeblocage = null,
                    Statut = StatutCompte.Bloque
                },
                new Compte
                {
                    Numero = "CPT004",
                    Titulaire = "Khadija Alami",
                    TypeCompte = TypeCompte.Epargne,
                    SoldeActuel = 72000,
                    DateCreation = DateTime.Now.AddYears(-7),
                    DateDeblocage = DateTime.Now.AddMonths(6),
                    Statut = StatutCompte.Actif
                },
                new Compte
                {
                    Numero = "CPT005",
                    Titulaire = "Youssef Tazi",
                    TypeCompte = TypeCompte.Courant,
                    SoldeActuel = 3200,
                    DateCreation = DateTime.Now.AddMonths(-6),
                    DateDeblocage = null,
                    Statut = StatutCompte.Actif
                }
            };

            context.Comptes.AddRange(comptes);
            context.SaveChanges();

            // Créer 15 transactions pour chaque compte
            var random = new Random();
            var descriptions = new string[]
            {
                "Virement salaire",
                "Retrait ATM",
                "Paiement facture électricité",
                "Achat en ligne",
                "Virement reçu",
                "Retrait espèces",
                "Paiement loyer",
                "Remboursement",
                "Achat supermarché",
                "Transfert bancaire",
                "Dépôt chèque",
                "Paiement assurance",
                "Achat carte bancaire",
                "Retrait bureau de change",
                "Dépôt espèces"
            };

            foreach (var compte in comptes)
            {
                var transactions = new Transaction[15];
                
                for (int i = 0; i < 15; i++)
                {
                    var type = random.Next(0, 2) == 0 ? TypeTransaction.Depot : TypeTransaction.Retrait;
                    var montant = random.Next(100, 10000);
                    var dateTransaction = DateTime.Now.AddDays(-random.Next(1, 365));

                    transactions[i] = new Transaction
                    {
                        CompteId = compte.Id,
                        Date = dateTransaction,
                        Type = type,
                        Montant = montant,
                        Description = descriptions[random.Next(descriptions.Length)]
                    };
                }

                context.Transactions.AddRange(transactions);
            }

            context.SaveChanges();
        }
    }
}
