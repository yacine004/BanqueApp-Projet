using Microsoft.AspNetCore.Mvc;
using BanqueApp.Data;
using BanqueApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BanqueApp.Controllers
{
    public class CompteController : Controller
    {
        private readonly AppDbContext _context;

        public CompteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Compte/Details
        // Affiche uniquement le formulaire de recherche
        public IActionResult Details()
        {
            return View();
        }

        // GET: /Compte/Rechercher?numero=XXX&page=1&typeFiltre=
        public IActionResult Rechercher(string numero, int page = 1, string typeFiltre = "")
        {
            if (string.IsNullOrWhiteSpace(numero))
            {
                return RedirectToAction("Details");
            }

            // Rechercher le compte par numéro
            var compte = _context.Comptes
                .Include(c => c.Transactions)
                .FirstOrDefault(c => c.Numero == numero);

            if (compte == null)
            {
                return View("NonTrouve");
            }

            // Calculer les statistiques
            var transactions = compte.Transactions;
            
            var totalDepots = transactions
                .Where(t => t.Type == TypeTransaction.Depot)
                .Sum(t => t.Montant);

            var totalRetraits = transactions
                .Where(t => t.Type == TypeTransaction.Retrait)
                .Sum(t => t.Montant);

            var nombreTransactions = transactions.Count;

            var derniereTransaction = transactions
                .OrderByDescending(t => t.Date)
                .FirstOrDefault();

            // Filtrage par type
            var transactionsFiltrees = transactions.AsEnumerable();
            
            if (!string.IsNullOrEmpty(typeFiltre))
            {
                if (typeFiltre == "Depot")
                {
                    transactionsFiltrees = transactionsFiltrees.Where(t => t.Type == TypeTransaction.Depot);
                }
                else if (typeFiltre == "Retrait")
                {
                    transactionsFiltrees = transactionsFiltrees.Where(t => t.Type == TypeTransaction.Retrait);
                }
            }

            // Pagination
            int pageSize = 5;
            var transactionsOrdered = transactionsFiltrees
                .OrderByDescending(t => t.Date)
                .ToList();

            var totalPages = (int)Math.Ceiling(transactionsOrdered.Count / (double)pageSize);
            
            var transactionsPaginees = transactionsOrdered
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // Passer les données à la vue via ViewBag
            ViewBag.Compte = compte;
            ViewBag.TotalDepots = totalDepots;
            ViewBag.TotalRetraits = totalRetraits;
            ViewBag.NombreTransactions = nombreTransactions;
            ViewBag.DerniereTransactionDate = derniereTransaction?.Date;
            ViewBag.Transactions = transactionsPaginees;
            ViewBag.PageActuelle = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.TypeFiltre = typeFiltre;
            ViewBag.Numero = numero;

            return View("DetailsCompte");
        }
    }
}
