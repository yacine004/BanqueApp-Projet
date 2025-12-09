# 📊 Diagramme de Classes - BanqueApp

## Diagramme UML

```
┌─────────────────────────────────────────┐
│           <<enumeration>>               │
│            TypeCompte                   │
├─────────────────────────────────────────┤
│ + Epargne                               │
│ + Courant                               │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│           <<enumeration>>               │
│           StatutCompte                  │
├─────────────────────────────────────────┤
│ + Actif                                 │
│ + Bloque                                │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│           <<enumeration>>               │
│          TypeTransaction                │
├─────────────────────────────────────────┤
│ + Depot                                 │
│ + Retrait                               │
└─────────────────────────────────────────┘

┌─────────────────────────────────────────┐
│              Compte                     │
├─────────────────────────────────────────┤
│ - Id : int                              │
│ - Numero : string                       │
│ - Titulaire : string                    │
│ - TypeCompte : TypeCompte               │
│ - SoldeActuel : decimal                 │
│ - DateCreation : DateTime               │
│ - DateDeblocage : DateTime?             │
│ - Statut : StatutCompte                 │
│ - Transactions : ICollection<Transaction>│
├─────────────────────────────────────────┤
│ + GetTotalDepots() : decimal            │
│ + GetTotalRetraits() : decimal          │
│ + GetNombreTransactions() : int         │
│ + GetDerniereTransaction() : DateTime?  │
└─────────────────────────────────────────┘
              │ 1
              │
              │ possède
              │
              │ *
┌─────────────────────────────────────────┐
│           Transaction                   │
├─────────────────────────────────────────┤
│ - Id : int                              │
│ - Date : DateTime                       │
│ - Type : TypeTransaction                │
│ - Montant : decimal                     │
│ - Description : string                  │
│ - CompteId : int                        │
│ - Compte : Compte                       │
├─────────────────────────────────────────┤
│ + EstDepot() : bool                     │
│ + EstRetrait() : bool                   │
└─────────────────────────────────────────┘
```

## Relations

### 1. Compte ↔ Transaction
- **Type de relation** : Association (One-to-Many / Un-à-Plusieurs)
- **Multiplicité** : 
  - Un Compte peut avoir **0 à plusieurs** Transactions (1..*)
  - Une Transaction appartient à **exactement un** Compte (1)
- **Implémentation** :
  - Clé étrangère `CompteId` dans Transaction
  - Navigation property `Transactions` dans Compte
  - Navigation property `Compte` dans Transaction
  - Cascade delete activé

## Description des Classes

### Classe Compte
Représente un compte bancaire avec toutes ses caractéristiques.

**Attributs** :
- `Id` : Identifiant unique du compte (clé primaire)
- `Numero` : Numéro du compte (ex: CPT001)
- `Titulaire` : Nom du propriétaire du compte
- `TypeCompte` : Type du compte (Epargne ou Courant)
- `SoldeActuel` : Solde actuel en dirham marocain
- `DateCreation` : Date de création du compte
- `DateDeblocage` : Date de déblocage (nullable, pour comptes épargne)
- `Statut` : Statut du compte (Actif ou Bloqué)
- `Transactions` : Collection de toutes les transactions liées

### Classe Transaction
Représente une opération bancaire (dépôt ou retrait).

**Attributs** :
- `Id` : Identifiant unique de la transaction (clé primaire)
- `Date` : Date et heure de la transaction
- `Type` : Type d'opération (Dépôt ou Retrait)
- `Montant` : Montant de l'opération en dirham
- `Description` : Description de la transaction
- `CompteId` : Référence au compte (clé étrangère)
- `Compte` : Référence navigation vers le compte

### Énumérations

#### TypeCompte
- `Epargne` : Compte d'épargne (peut avoir une date de déblocage)
- `Courant` : Compte courant (opérations libres)

#### StatutCompte
- `Actif` : Compte actif et opérationnel
- `Bloque` : Compte bloqué (consultation uniquement)

#### TypeTransaction
- `Depot` : Opération de dépôt (crédit)
- `Retrait` : Opération de retrait (débit)

## Contraintes

1. **Compte.Numero** : Doit être unique
2. **Compte.SoldeActuel** : Précision de 18 chiffres avec 2 décimales
3. **Transaction.Montant** : Précision de 18 chiffres avec 2 décimales
4. **Transaction.CompteId** : Obligatoire (FK)
5. **Cascade Delete** : Suppression d'un compte supprime toutes ses transactions

## Cardinalités

```
Compte (1) ──────< possède >────── (*) Transaction

Un compte possède zéro ou plusieurs transactions
Une transaction appartient à un et un seul compte
```
