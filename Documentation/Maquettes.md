# 🖼️ Maquettes de l'Application BanqueApp

## 📸 Captures d'écran de l'application

### 1️⃣ Page de Recherche (`/Compte/Details`)

![Page de recherche](screenshots/page-recherche.png)

**Description** :
- Formulaire simple avec un champ de saisie pour le numéro de compte
- Bouton "Rechercher" pour lancer la recherche
- Liste des comptes disponibles pour faciliter les tests
- Design épuré avec Bootstrap
- En-tête avec menu de navigation

**Fonctionnalités** :
- ✅ Saisie du numéro de compte
- ✅ Validation côté client
- ✅ Navigation vers les résultats

---

### 2️⃣ Page des Détails du Compte (`/Compte/Rechercher?numero=CPT001`)

![Détails du compte](screenshots/page-details-compte.png)

**Sections affichées** :

#### 📋 Informations du Compte
- Numéro du compte
- Nom du titulaire
- Type de compte (Courant/Epargne)
- Solde actuel (en vert, mis en évidence)
- Date de création
- Statut avec badge coloré :
  - 🟢 Vert pour "Actif"
  - 🟡 Jaune pour "Bloqué"
- Date de déblocage (si applicable)

#### 📊 Statistiques
Quatre cartes affichant :
- **Total dépôts** (en vert)
- **Total retraits** (en rouge)
- **Nombre de transactions**
- **Date de dernière transaction**

#### 📜 Historique des Transactions
- **Filtre** : Sélecteur pour filtrer par type (Tous/Dépôts/Retraits)
- **Tableau** :
  - Date et heure de la transaction
  - Type avec badge coloré (🟢 Dépôt / 🔴 Retrait)
  - Description
  - Montant avec couleur :
    - ✅ Vert avec "+" pour les dépôts
    - ❌ Rouge avec "-" pour les retraits
- **Pagination** : 5 transactions par page avec navigation

---

### 3️⃣ Page Compte Introuvable (`/Compte/NonTrouve`)

![Compte introuvable](screenshots/page-non-trouve.png)

**Description** :
- Message d'erreur clair et visible
- Icône d'avertissement
- Bouton de retour vers la recherche
- Design cohérent avec le reste de l'application

---

### 4️⃣ Page d'Accueil (`/Home/Index`)

![Page d'accueil](screenshots/page-accueil.png)

**Description** :
- Page d'accueil standard ASP.NET Core MVC
- Lien vers la fonctionnalité de recherche de compte
- Menu de navigation avec tous les liens

---

## 🎨 Éléments de Design

### Palette de Couleurs

| Élément | Couleur | Code |
|---------|---------|------|
| Dépôts | Vert | `#28a745` |
| Retraits | Rouge | `#dc3545` |
| Statut Actif | Vert | `#28a745` |
| Statut Bloqué | Jaune | `#ffc107` |
| En-tête Info | Bleu | `#0d6efd` |
| En-tête Statistiques | Cyan | `#0dcaf0` |
| En-tête Transactions | Vert | `#198754` |
| Erreur | Rouge | `#dc3545` |

### Typographie
- Police : Système par défaut (Bootstrap)
- Taille de base : 16px
- Responsive : 14px sur mobile

### Composants Bootstrap Utilisés
- ✅ Cards
- ✅ Badges
- ✅ Tables
- ✅ Forms
- ✅ Buttons
- ✅ Pagination
- ✅ Navbar
- ✅ Alerts

---

## 📱 Responsive Design

L'application est entièrement responsive et s'adapte à tous les écrans :

### 💻 Desktop (> 768px)
- Affichage sur 4 colonnes pour les statistiques
- Tableau complet des transactions
- Navigation horizontale

### 📱 Mobile (< 768px)
- Statistiques empilées verticalement
- Tableau responsive avec scroll horizontal
- Menu hamburger

---

## 🔄 Interactions Utilisateur

### 1. Recherche de compte
```
Saisie numéro → Clic "Rechercher" → Redirection vers résultats
```

### 2. Filtrage des transactions
```
Sélection filtre → Soumission automatique → Mise à jour de la liste
```

### 3. Pagination
```
Clic sur numéro de page → Rechargement avec nouvelles transactions
```

### 4. Navigation
```
Menu → Sélection "Rechercher un compte" → Page de recherche
```

---

## ✨ Points Forts de la Maquette

1. ✅ **Interface intuitive** : Navigation claire et facile
2. ✅ **Feedback visuel** : Couleurs significatives (vert/rouge)
3. ✅ **Responsive** : Fonctionne sur tous les appareils
4. ✅ **Accessible** : Utilisation de Bootstrap pour l'accessibilité
5. ✅ **Performance** : Pagination pour gérer de grandes listes
6. ✅ **Filtrage** : Recherche facile par type de transaction
7. ✅ **Statistiques** : Vue d'ensemble rapide du compte

---

## 🎯 Conformité aux Exigences

### ✅ Exigences Fonctionnelles
- [x] Page de recherche avec formulaire
- [x] Affichage des détails du compte
- [x] Affichage des statistiques calculées
- [x] Historique des transactions
- [x] Pagination fonctionnelle
- [x] Filtrage par type de transaction
- [x] Message d'erreur si compte introuvable

### ✅ Exigences de Design
- [x] Cards Bootstrap pour les sections
- [x] Couleurs : vert (dépôts), rouge (retraits)
- [x] Badges de statut colorés
- [x] Tableaux responsive
- [x] Mise en page professionnelle

### ❌ Fonctionnalités Exclues (Selon Cahier des Charges)
- [x] Pas de modification de compte
- [x] Pas de suppression de compte
- [x] Pas de création de transaction
- [x] Pas de boutons d'édition

---

## 📝 Instructions pour Capturer les Screenshots

Pour obtenir les captures d'écran de l'application en cours d'exécution :

1. **Démarrer l'application** :
   ```bash
   dotnet run
   ```

2. **Ouvrir dans le navigateur** : `http://localhost:5106`

3. **Créer un dossier** : `Documentation/screenshots/`

4. **Capturer les écrans** :
   - Page de recherche : `/Compte/Details`
   - Page avec détails : `/Compte/Rechercher?numero=CPT001`
   - Page erreur : Entrer un numéro invalide
   - Page accueil : `/`

5. **Renommer les fichiers** :
   - `page-recherche.png`
   - `page-details-compte.png`
   - `page-non-trouve.png`
   - `page-accueil.png`

---

## 🌐 Démo en Ligne

Une fois déployé sur GitHub, l'application sera accessible via GitHub Pages ou un service de déploiement comme :
- Azure App Service
- Heroku
- Railway
- Render

---

**Note** : Les captures d'écran doivent être ajoutées manuellement dans le dossier `Documentation/screenshots/` après avoir pris les screenshots de l'application en cours d'exécution.
