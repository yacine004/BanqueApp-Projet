# 🏦 Projet BanqueApp - Documentation Principale

## 👨‍🎓 Informations Projet

**Réalisé par** : BA Ndèye Yacine
**Classe** : L3 - GLRS B
**Date** : Décembre 2025  
**Enseignant** : Mr BAILA WANE
---

## 📋 Livrables du Projet

Ce repository contient tous les livrables demandés :

### ✅ 1. Modélisation
📄 **[Documentation/DiagrammeDeClasses.md](Documentation/DiagrammeDeClasses.md)**
- Diagramme UML complet des classes Compte et Transaction
- Relations et cardinalités
- Description détaillée des attributs et méthodes

### ✅ 2. Données de Test
📄 **[Documentation/DonneesDeTest.md](Documentation/DonneesDeTest.md)**
- 5 comptes bancaires créés automatiquement
- 75 transactions (15 par compte)
- Description complète de toutes les données

### ✅ 3. Maquettes de l'Application
📄 **[Documentation/Maquettes.md](Documentation/Maquettes.md)**
- Captures d'écran de toutes les pages
- Guide de design et palette de couleurs
- Description de l'interface utilisateur

### ✅ 4. Code Source Complet
📁 **[BanqueApp/](BanqueApp/)**
- Application ASP.NET Core MVC fonctionnelle
- Architecture MVC complète
- README avec instructions d'installation

---

## 🚀 Démarrage Rapide

```bash
# 1. Cloner le projet
git clone [URL_DU_REPOSITORY]
cd ProjetBanque/BanqueApp

# 2. Restaurer les packages
dotnet restore

# 3. Lancer l'application
dotnet run

# 4. Ouvrir dans le navigateur
# http://localhost:5106
```

---

## 🔑 Comptes de Test

| Numéro | Titulaire | Type | Statut |
|--------|-----------|------|--------|
| CPT001 | Ahmed Benali | Courant | ✅ Actif |
| CPT002 | Fatima Zahra | Epargne | ✅ Actif |
| CPT003 | Mohamed Alaoui | Courant | ⚠️ Bloqué |
| CPT004 | Khadija Alami | Epargne | ✅ Actif |
| CPT005 | Youssef Tazi | Courant | ✅ Actif |

---

## 📁 Structure du Repository

```
ProjetBanque/
├── BanqueApp/                  # Code source de l'application
│   ├── Controllers/            # Contrôleurs MVC
│   ├── Data/                   # DbContext et données
│   ├── Models/                 # Modèles (Compte, Transaction)
│   ├── Views/                  # Vues Razor
│   └── wwwroot/                # Fichiers statiques (CSS, JS)
├── Documentation/              # Documentation complète
│   ├── DiagrammeDeClasses.md   # Modélisation UML
│   ├── DonneesDeTest.md        # Description des données
│   └── Maquettes.md            # Captures d'écran et design
├── .gitignore                  # Fichiers Git à ignorer
└── README.md                   # Ce fichier
```

---

## 🎯 Fonctionnalités Principales

### Page de Recherche
- Formulaire simple avec input pour numéro de compte
- Validation et message d'erreur si compte introuvable

### Page Détails du Compte
- **Informations** : Numéro, titulaire, type, solde, dates, statut
- **Statistiques** : Total dépôts/retraits, nombre de transactions
- **Historique** : Pagination (5/page) + Filtrage (Dépôt/Retrait)

---

## 🛠️ Technologies

- **Backend** : ASP.NET Core MVC (.NET 10.0)
- **ORM** : Entity Framework Core InMemory
- **Frontend** : Razor Pages + Bootstrap 5
- **Langage** : C# 13

---

## 📧 Contact

**Étudiant** : BA Ndèye Yacine 
**Email** : yacineba042@gmail.com  
**GitHub** : yacine004
---

## 📝 Notes pour le Professeur

### Respect du Cahier des Charges

✅ **Comportement demandé** :
- Page Details n'affiche rien au départ (uniquement le formulaire)
- Recherche par numéro de compte
- Affichage conditionnel après recherche réussie
- Aucun bouton de modification/suppression/création

✅ **Modélisation** :
- Diagramme de classes UML complet avec toutes les propriétés
- Relations One-to-Many entre Compte et Transaction
- Énumérations pour TypeCompte, StatutCompte, TypeTransaction

✅ **Données de test** :
- 5 comptes générés automatiquement au démarrage
- 15 transactions par compte (75 au total)
- Données réalistes avec montants et dates aléatoires

✅ **Maquette** :
- Design Bootstrap propre et responsive
- Cards pour les sections
- Couleurs : vert (dépôts), rouge (retraits)
- Badges de statut colorés
- Pagination et filtrage fonctionnels

✅ **Documentation** :
- README complet avec instructions
- Diagrammes et explications détaillées
- Captures d'écran de l'application

---

## 🎓 Projet Réalisé

Application complète et fonctionnelle répondant à tous les critères demandés.

Pour toute question, n'hésitez pas à me contacter.

---

**Date de soumission** : 09/12/2025
**Repository GitHub** : 
