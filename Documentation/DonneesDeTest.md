# 💾 Données de Test - BanqueApp

## Vue d'ensemble

L'application contient **5 comptes bancaires** avec un total de **75 transactions** (15 transactions par compte).

---

## 📋 Liste des Comptes

### Compte 1 : CPT001
| Propriété | Valeur |
|-----------|--------|
| **Numéro** | CPT001 |
| **Titulaire** | Ahmed Benali |
| **Type** | Courant |
| **Solde Actuel** | 15 000.00 DH |
| **Date de Création** | 9 décembre 2022 |
| **Date de Déblocage** | - |
| **Statut** | ✅ Actif |
| **Transactions** | 15 |

---

### Compte 2 : CPT002
| Propriété | Valeur |
|-----------|--------|
| **Numéro** | CPT002 |
| **Titulaire** | Fatima Zahra |
| **Type** | Epargne |
| **Solde Actuel** | 45 000.00 DH |
| **Date de Création** | 9 décembre 2020 |
| **Date de Déblocage** | 9 décembre 2026 |
| **Statut** | ✅ Actif |
| **Transactions** | 15 |

---

### Compte 3 : CPT003
| Propriété | Valeur |
|-----------|--------|
| **Numéro** | CPT003 |
| **Titulaire** | Mohamed Alaoui |
| **Type** | Courant |
| **Solde Actuel** | 8 500.00 DH |
| **Date de Création** | 9 décembre 2023 |
| **Date de Déblocage** | - |
| **Statut** | ⚠️ Bloqué |
| **Transactions** | 15 |

---

### Compte 4 : CPT004
| Propriété | Valeur |
|-----------|--------|
| **Numéro** | CPT004 |
| **Titulaire** | Khadija Alami |
| **Type** | Epargne |
| **Solde Actuel** | 72 000.00 DH |
| **Date de Création** | 9 décembre 2018 |
| **Date de Déblocage** | 9 juin 2026 |
| **Statut** | ✅ Actif |
| **Transactions** | 15 |

---

### Compte 5 : CPT005
| Propriété | Valeur |
|-----------|--------|
| **Numéro** | CPT005 |
| **Titulaire** | Youssef Tazi |
| **Type** | Courant |
| **Solde Actuel** | 3 200.00 DH |
| **Date de Création** | 9 juin 2025 |
| **Date de Déblocage** | - |
| **Statut** | ✅ Actif |
| **Transactions** | 15 |

---

## 📊 Statistiques Globales

| Statistique | Valeur |
|-------------|--------|
| **Nombre total de comptes** | 5 |
| **Nombre total de transactions** | 75 |
| **Comptes actifs** | 4 |
| **Comptes bloqués** | 1 |
| **Comptes courants** | 3 |
| **Comptes épargne** | 2 |
| **Solde total de tous les comptes** | 143 700.00 DH |

---

## 🔄 Types de Transactions Générées

Les transactions sont générées aléatoirement avec les caractéristiques suivantes :

### Types d'opérations
- ✅ **Dépôt** : Crédit sur le compte
- ❌ **Retrait** : Débit du compte

### Montants
- Montants aléatoires entre **100 DH** et **10 000 DH**

### Dates
- Transactions générées sur les **12 derniers mois**
- Réparties aléatoirement dans le temps

### Descriptions possibles
1. Virement salaire
2. Retrait ATM
3. Paiement facture électricité
4. Achat en ligne
5. Virement reçu
6. Retrait espèces
7. Paiement loyer
8. Remboursement
9. Achat supermarché
10. Transfert bancaire
11. Dépôt chèque
12. Paiement assurance
13. Achat carte bancaire
14. Retrait bureau de change
15. Dépôt espèces

---

## 💡 Exemple de Transactions pour CPT001

Voici un exemple du type de données générées (les valeurs réelles varient à chaque exécution) :

| Date | Type | Montant | Description |
|------|------|---------|-------------|
| 08/12/2025 14:30 | 🟢 Dépôt | 5 420.00 DH | Virement salaire |
| 05/12/2025 09:15 | 🔴 Retrait | 1 200.00 DH | Retrait ATM |
| 01/12/2025 16:45 | 🔴 Retrait | 850.00 DH | Paiement facture électricité |
| 28/11/2025 11:20 | 🟢 Dépôt | 3 150.00 DH | Virement reçu |
| 25/11/2025 08:30 | 🔴 Retrait | 2 500.00 DH | Paiement loyer |
| ... | ... | ... | ... |
| *(15 transactions au total)* |

---

## 🔧 Génération des Données

Les données sont générées automatiquement au démarrage de l'application via la classe **`DbInitializer`**.

### Code de génération
```csharp
// Localisation : BanqueApp/Data/DbInitializer.cs

public static void Seed(AppDbContext context)
{
    // Création de 5 comptes
    // Pour chaque compte : 15 transactions aléatoires
    // Types : Dépôt ou Retrait (50/50)
    // Montants : Entre 100 et 10 000 DH
    // Dates : Derniers 365 jours
}
```

### Stockage
- **Base de données** : InMemory (Entity Framework Core)
- **Persistance** : Données régénérées à chaque démarrage
- **Accès** : Via `AppDbContext`

---

## 📝 Notes Importantes

1. **Données aléatoires** : Les montants et dates des transactions changent à chaque redémarrage de l'application
2. **Seed automatique** : Les données sont insérées automatiquement via `DbInitializer.Seed()` dans `Program.cs`
3. **Base InMemory** : Les données existent uniquement en mémoire pendant l'exécution de l'application
4. **Identifiants fixes** : Les numéros de comptes (CPT001-CPT005) et les titulaires restent constants
5. **Distribution** : Chaque compte a exactement 15 transactions pour des tests cohérents

---

## 🎯 Utilisation pour les Tests

Pour tester l'application, utilisez ces numéros de compte :

```
CPT001 → Compte actif avec transactions variées
CPT002 → Compte épargne avec solde élevé
CPT003 → Compte BLOQUÉ (pour tester le statut)
CPT004 → Compte épargne avec date de déblocage
CPT005 → Compte récent avec peu de transactions
```

---

## ✅ Validation des Données

Toutes les données respectent les contraintes suivantes :
- ✅ Numéros de compte uniques
- ✅ Montants avec 2 décimales
- ✅ Dates cohérentes
- ✅ Relations FK valides
- ✅ Types énumérés valides
