# 🏦 BanqueApp - Système de Gestion de Comptes Bancaires

## 👨‍🎓 Projet Académique

**Réalisé par** : [Votre Nom]  
**Classe** : [Votre Classe]  
**Date** : Décembre 2025  
**Enseignant** : [Nom du Professeur]

---

## 📋 Description du Projet

Application ASP.NET Core MVC permettant la consultation des détails de comptes bancaires avec historique des transactions, statistiques en temps réel et filtrage avancé.

### 🎯 Objectif
Développer une application web de gestion bancaire qui permet de :
- Rechercher un compte par son numéro
- Afficher les informations détaillées du compte
- Visualiser des statistiques (dépôts, retraits, transactions)
- Consulter l'historique des transactions avec pagination et filtres

---

## 📚 Documentation Complète

### 1️⃣ Diagramme de Classes
📄 **[Documentation/DiagrammeDeClasses.md](Documentation/DiagrammeDeClasses.md)**
- Diagramme UML complet
- Relations entre Compte et Transaction
- Description des attributs et méthodes
- Énumérations (TypeCompte, StatutCompte, TypeTransaction)

### 2️⃣ Données de Test
📄 **[Documentation/DonneesDeTest.md](Documentation/DonneesDeTest.md)**
- 5 comptes bancaires générés automatiquement
- 75 transactions (15 par compte)
- Détails de chaque compte
- Statistiques globales

### 3️⃣ Maquettes et Captures d'Écran
📄 **[Documentation/Maquettes.md](Documentation/Maquettes.md)**
- Captures d'écran de toutes les pages
- Description des éléments de design
- Palette de couleurs utilisée
- Guide responsive

---

## ✨ Fonctionnalités Implémentées

### 🔍 Recherche de compte
- ✅ Page de recherche avec formulaire simple
- ✅ Validation du numéro de compte
- ✅ Message d'erreur si compte introuvable
- ✅ Liste des comptes disponibles pour tests

### 📊 Affichage des détails
- ✅ **Informations complètes** : numéro, titulaire, type, solde, dates, statut
- ✅ **Statistiques calculées** :
  - Total des dépôts (en vert)
  - Total des retraits (en rouge)
  - Nombre de transactions
  - Date de dernière transaction
- ✅ **Historique des transactions** :
  - Affichage paginé (5 transactions par page)
  - Filtrage par type (Dépôt / Retrait / Tous)
  - Tri par date décroissante
  - Couleurs distinctives (vert pour dépôts, rouge pour retraits)

### 🎨 Interface Utilisateur
- ✅ Design responsive avec Bootstrap 5
- ✅ Cards pour organiser l'information
- ✅ Badges de statut colorés
- ✅ Navigation intuitive
- ✅ Feedback visuel clair

---

## 🗂️ Structure du Projet

```
ProjetBanque/
├── BanqueApp/
│   ├── Controllers/
│   │   ├── CompteController.cs       # Gestion de la recherche et affichage
│   │   └── HomeController.cs         # Page d'accueil
│   ├── Data/
│   │   ├── AppDbContext.cs           # Contexte Entity Framework Core
│   │   └── DbInitializer.cs          # Génération des données de test
│   ├── Models/
│   │   ├── Compte.cs                 # Entité Compte
│   │   ├── Transaction.cs            # Entité Transaction
│   │   └── ErrorViewModel.cs
│   ├── Views/
│   │   ├── Compte/
│   │   │   ├── Details.cshtml        # Page de recherche
│   │   │   ├── DetailsCompte.cshtml  # Page des détails du compte
│   │   │   └── NonTrouve.cshtml      # Page d'erreur
│   │   ├── Home/
│   │   └── Shared/
│   │       └── _Layout.cshtml        # Layout principal
│   ├── wwwroot/
│   │   └── css/
│   │       └── site.css              # Styles personnalisés
│   ├── Program.cs                     # Point d'entrée de l'application
│   ├── BanqueApp.csproj              # Configuration du projet
│   └── README.md                      # Ce fichier
├── Documentation/
│   ├── DiagrammeDeClasses.md         # Modélisation UML
│   ├── DonneesDeTest.md              # Description des données
│   └── Maquettes.md                  # Captures d'écran et design
├── .gitignore                         # Fichiers à ignorer par Git
└── README.md                          # Documentation principale
```

---

## 🚀 Installation et Démarrage

### Prérequis
- **.NET 10.0 SDK** ou supérieur
- **Visual Studio Code** ou **Visual Studio 2025**
- **Git** (pour le clonage)

### Étapes d'installation

1. **Cloner le projet** :
   ```bash
   git clone [URL_DU_REPOSITORY]
   cd ProjetBanque/BanqueApp
   ```

2. **Restaurer les packages NuGet** :
   ```bash
   dotnet restore
   ```

3. **Compiler le projet** :
   ```bash
   dotnet build
   ```

4. **Lancer l'application** :
   ```bash
   dotnet run
   ```

5. **Ouvrir dans le navigateur** :
   - Par défaut : `http://localhost:5106`
   - Ou utiliser l'URL affichée dans le terminal

---

## 🔑 Comptes de Test

Utilisez ces numéros pour tester l'application :

| Numéro  | Titulaire        | Type    | Solde       | Statut  |
|---------|------------------|---------|-------------|---------|
| **CPT001** | Ahmed Benali     | Courant | 15 000 DH   | ✅ Actif   |
| **CPT002** | Fatima Zahra     | Epargne | 45 000 DH   | ✅ Actif   |
| **CPT003** | Mohamed Alaoui   | Courant | 8 500 DH    | ⚠️ Bloqué  |
| **CPT004** | Khadija Alami    | Epargne | 72 000 DH   | ✅ Actif   |
| **CPT005** | Youssef Tazi     | Courant | 3 200 DH    | ✅ Actif   |

---

## 🛠️ Technologies Utilisées

### Backend
- **Framework** : ASP.NET Core MVC (.NET 10.0)
- **Langage** : C# 13
- **ORM** : Entity Framework Core 10.0
- **Base de données** : InMemory Database

### Frontend
- **Moteur de templates** : Razor Pages
- **CSS Framework** : Bootstrap 5
- **JavaScript** : Vanilla JS (minimal)

### Packages NuGet
- `Microsoft.EntityFrameworkCore` (10.0.0)
- `Microsoft.EntityFrameworkCore.InMemory` (10.0.0)

---

## 📐 Modélisation

### Modèle de Données

#### Classe **Compte**
```csharp
- Id : int (PK)
- Numero : string
- Titulaire : string
- TypeCompte : enum (Epargne, Courant)
- SoldeActuel : decimal
- DateCreation : DateTime
- DateDeblocage : DateTime?
- Statut : enum (Actif, Bloqué)
- Transactions : ICollection<Transaction>
```

#### Classe **Transaction**
```csharp
- Id : int (PK)
- Date : DateTime
- Type : enum (Depot, Retrait)
- Montant : decimal
- Description : string
- CompteId : int (FK)
- Compte : Compte
```

### Relation
- **Compte** (1) ──── (*) **Transaction**
- Un compte peut avoir plusieurs transactions
- Cascade delete activé

---

## 📝 Routes de l'Application

| Route | Description |
|-------|-------------|
| `/` | Page d'accueil |
| `/Compte/Details` | Page de recherche de compte |
| `/Compte/Rechercher?numero=XXX` | Détails d'un compte spécifique |
| `/Compte/Rechercher?numero=XXX&page=2` | Pagination des transactions |
| `/Compte/Rechercher?numero=XXX&typeFiltre=Depot` | Filtrage par type |

---

## ✅ Conformité aux Exigences

### Exigences Fonctionnelles
- [x] Page de recherche avec input et bouton OK
- [x] Affichage conditionnel (rien avant la recherche)
- [x] Informations du compte complètes
- [x] Statistiques calculées (dépôts, retraits, nb transactions, dernière date)
- [x] Historique avec pagination (5 par page)
- [x] Filtre par type de transaction
- [x] Message d'erreur si compte introuvable
- [x] Aucun bouton de modification/suppression/création

### Modélisation
- [x] Diagramme de classes UML complet
- [x] 5 comptes générés automatiquement
- [x] 15 transactions par compte (75 au total)
- [x] Données réalistes et cohérentes

### Interface Utilisateur
- [x] Design Bootstrap propre et responsive
- [x] Cards pour les sections
- [x] Couleurs : vert (dépôts), rouge (retraits)
- [x] Badges de statut colorés
- [x] Pagination fonctionnelle
- [x] Filtres dynamiques

---

## 🎨 Éléments de Design

### Palette de Couleurs
- **Dépôts** : Vert (`#28a745`)
- **Retraits** : Rouge (`#dc3545`)
- **Statut Actif** : Vert (`#28a745`)
- **Statut Bloqué** : Jaune (`#ffc107`)

### Composants Bootstrap
- Cards, Badges, Tables, Forms
- Buttons, Pagination, Navbar, Alerts

---

## 📸 Captures d'Écran

Voir le fichier **[Documentation/Maquettes.md](Documentation/Maquettes.md)** pour :
- Page de recherche
- Page des détails du compte
- Page compte introuvable
- Page d'accueil

---

## 🧪 Tests

### Scénarios de Test

1. **Recherche réussie** :
   - Entrer `CPT001` → Affiche les détails du compte

2. **Recherche échouée** :
   - Entrer `CPT999` → Affiche "Compte introuvable"

3. **Pagination** :
   - Comptes avec 15 transactions → 3 pages (5 par page)

4. **Filtrage** :
   - Sélectionner "Dépôts uniquement" → Affiche seulement les dépôts
   - Sélectionner "Retraits uniquement" → Affiche seulement les retraits

---

## 🔒 Sécurité

- Validation côté serveur des entrées utilisateur
- Paramètres de requête validés
- Pas de SQL injection (utilisation d'EF Core)
- Pas de données sensibles en clair

---

## 🚧 Limitations Connues

- Base de données InMemory (données perdues au redémarrage)
- Pas d'authentification utilisateur
- Pas de modification des données (lecture seule)
- Pas de gestion des rôles

---

## 🔮 Améliorations Futures

- [ ] Migration vers SQL Server
- [ ] Authentification et autorisation
- [ ] Export PDF/Excel des transactions
- [ ] Graphiques de statistiques
- [ ] API REST
- [ ] Tests unitaires et d'intégration

---

## 📧 Contact

**Étudiant** : [Votre Nom]  
**Email** : [votre.email@example.com]  
**GitHub** : [votre-username]

---

## 📄 Licence

Projet éducatif - Libre d'utilisation pour des fins pédagogiques

---

## 🙏 Remerciements

Merci au professeur [Nom] pour l'encadrement et les conseils durant ce projet.

---

**Note** : Ce projet a été développé dans le cadre du cours de développement web avec ASP.NET Core MVC.

## ✨ Fonctionnalités

### 🔍 Recherche de compte
- Recherche par numéro de compte
- Interface simple et intuitive
- Message d'erreur si compte introuvable

### 📊 Affichage des détails
- **Informations du compte** : numéro, titulaire, type, solde, dates, statut
- **Statistiques** :
  - Total des dépôts
  - Total des retraits
  - Nombre de transactions
  - Date de dernière transaction
- **Historique des transactions** :
  - Affichage paginé (5 transactions par page)
  - Filtrage par type (Dépôt / Retrait)
  - Tri par date décroissante

### 🎨 Design
- Interface responsive avec Bootstrap
- Couleurs distinctives :
  - ✅ Dépôts en **vert**
  - ❌ Retraits en **rouge**
  - ✅ Statut Actif en **vert**
  - ⚠️ Statut Bloqué en **jaune**

## 🗂️ Structure du Projet

```
BanqueApp/
├── Controllers/
│   ├── CompteController.cs       # Actions Details et Rechercher
│   └── HomeController.cs
├── Data/
│   ├── AppDbContext.cs           # Contexte Entity Framework
│   └── DbInitializer.cs          # Seed data (5 comptes + 75 transactions)
├── Models/
│   ├── Compte.cs                 # Modèle Compte avec propriétés
│   └── Transaction.cs            # Modèle Transaction
├── Views/
│   ├── Compte/
│   │   ├── Details.cshtml        # Page de recherche
│   │   ├── DetailsCompte.cshtml  # Affichage complet du compte
│   │   └── NonTrouve.cshtml      # Message d'erreur
│   └── Shared/
│       └── _Layout.cshtml
└── wwwroot/
    └── css/
        └── site.css              # Styles personnalisés
```

## 🚀 Démarrage

### Prérequis
- .NET 10.0 SDK
- Visual Studio Code ou Visual Studio 2025

### Installation

1. **Cloner ou ouvrir le projet** :
   ```bash
   cd c:\Users\HP\Desktop\ProjetBanque\BanqueApp
   ```

2. **Restaurer les packages NuGet** :
   ```bash
   dotnet restore
   ```

3. **Compiler le projet** :
   ```bash
   dotnet build
   ```

4. **Lancer l'application** :
   ```bash
   dotnet run
   ```

5. **Ouvrir dans le navigateur** :
   - URL : `http://localhost:5106`
   - Ou selon l'URL affichée dans le terminal

## 🔑 Comptes de Test

Utilisez ces numéros pour tester l'application :

| Numéro  | Titulaire        | Type    | Statut  |
|---------|------------------|---------|---------|
| CPT001  | Ahmed Benali     | Courant | Actif   |
| CPT002  | Fatima Zahra     | Epargne | Actif   |
| CPT003  | Mohamed Alaoui   | Courant | Bloqué  |
| CPT004  | Khadija Alami    | Epargne | Actif   |
| CPT005  | Youssef Tazi     | Courant | Actif   |

## 📦 Packages NuGet Utilisés

- `Microsoft.EntityFrameworkCore` (10.0.0)
- `Microsoft.EntityFrameworkCore.InMemory` (10.0.0)

## 🛠️ Technologies

- **Framework** : ASP.NET Core MVC (.NET 10.0)
- **Base de données** : Entity Framework Core InMemory
- **Frontend** : Razor Pages, Bootstrap 5
- **Langage** : C# 13

## 📝 Routes Principales

- `/Compte/Details` - Page de recherche
- `/Compte/Rechercher?numero=XXX` - Affichage des détails d'un compte
- `/Compte/Rechercher?numero=XXX&page=2` - Pagination
- `/Compte/Rechercher?numero=XXX&typeFiltre=Depot` - Filtrage

## 🎯 Caractéristiques Techniques

### Modèle Compte
```csharp
- Id (int)
- Numero (string)
- Titulaire (string)
- TypeCompte (enum: Epargne, Courant)
- SoldeActuel (decimal)
- DateCreation (DateTime)
- DateDeblocage (DateTime?)
- Statut (enum: Actif, Bloqué)
```

### Modèle Transaction
```csharp
- Id (int)
- Date (DateTime)
- Type (enum: Depot, Retrait)
- Montant (decimal)
- Description (string)
- CompteId (FK)
```

## 👨‍💻 Auteur

Projet créé avec GitHub Copilot - ASP.NET Core MVC

## 📄 Licence

Projet éducatif - Libre d'utilisation
#   B a n q u e A p p - P r o j e t  
 