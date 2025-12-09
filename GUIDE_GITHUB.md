# 📧 Guide de Déploiement sur GitHub

## Étapes pour Publier le Projet sur GitHub

### 1️⃣ Créer un Repository sur GitHub

1. **Aller sur GitHub** : https://github.com
2. **Cliquer sur "New repository"** (bouton vert)
3. **Remplir les informations** :
   - **Repository name** : `BanqueApp-Projet` (ou le nom de votre choix)
   - **Description** : `Projet ASP.NET Core MVC - Gestion de comptes bancaires`
   - **Visibility** : Public
   - ⚠️ **NE PAS** cocher "Initialize this repository with a README"
4. **Cliquer sur "Create repository"**

---

### 2️⃣ Lier votre Projet Local au Repository GitHub

Ouvrez le terminal dans VS Code et exécutez ces commandes :

```bash
# 1. Définir la branche principale
git branch -M main

# 2. Ajouter le remote (remplacer YOUR-USERNAME et REPO-NAME)
git remote add origin https://github.com/YOUR-USERNAME/BanqueApp-Projet.git

# 3. Pousser le code vers GitHub
git push -u origin main
```

**Exemple concret** :
```bash
git branch -M main
git remote add origin https://github.com/votre-username/BanqueApp-Projet.git
git push -u origin main
```

---

### 3️⃣ Vérifier que le Projet est en Ligne

1. **Rafraîchir la page GitHub**
2. **Vérifier que tous les fichiers sont présents** :
   - ✅ BanqueApp/
   - ✅ Documentation/
   - ✅ README.md
   - ✅ .gitignore

---

### 4️⃣ Préparer l'Email pour le Professeur

#### Modèle d'Email

```
Objet : Projet BanqueApp - [Votre Nom] - [Votre Classe]

Bonjour Professeur [Nom],

J'ai le plaisir de vous soumettre mon projet de développement web ASP.NET Core MVC.

🔗 Lien du repository GitHub :
https://github.com/VOTRE-USERNAME/BanqueApp-Projet

📋 Contenu du projet :

1. ✅ Modélisation (Diagramme de classes UML)
   → Documentation/DiagrammeDeClasses.md

2. ✅ Données de test (5 comptes + 75 transactions)
   → Documentation/DonneesDeTest.md

3. ✅ Maquettes de l'application
   → Documentation/Maquettes.md

4. ✅ Code source complet
   → BanqueApp/

🚀 Instructions pour tester l'application :
- Cloner le repository
- cd BanqueApp
- dotnet restore
- dotnet run
- Ouvrir http://localhost:5106

🔑 Comptes de test disponibles :
CPT001, CPT002, CPT003, CPT004, CPT005

Tous les livrables demandés sont présents et documentés.

Cordialement,
[Votre Nom]
[Votre Classe]
```

---

## ✅ Checklist Avant Envoi

Vérifiez que votre repository contient :

- [ ] ✅ README.md principal à la racine
- [ ] ✅ Code source complet dans BanqueApp/
- [ ] ✅ Documentation/DiagrammeDeClasses.md
- [ ] ✅ Documentation/DonneesDeTest.md
- [ ] ✅ Documentation/Maquettes.md
- [ ] ✅ .gitignore (pour exclure bin/, obj/, etc.)
- [ ] ✅ Tous les fichiers sont commités

---

## 🎯 Commandes Git Utiles

### Vérifier le statut
```bash
git status
```

### Ajouter des modifications
```bash
git add .
git commit -m "Description des changements"
git push
```

### Voir l'historique
```bash
git log --oneline
```

---

## 📸 Ajout de Screenshots (Optionnel)

Si vous voulez ajouter des vraies captures d'écran :

1. **Créer le dossier** :
   ```bash
   mkdir Documentation/screenshots
   ```

2. **Prendre les screenshots** :
   - Page de recherche
   - Page avec détails d'un compte
   - Page erreur

3. **Renommer les fichiers** :
   - `page-recherche.png`
   - `page-details-compte.png`
   - `page-non-trouve.png`

4. **Ajouter et commiter** :
   ```bash
   git add Documentation/screenshots/
   git commit -m "Ajout des captures d'écran"
   git push
   ```

---

## 🌐 Lien du Repository

Votre lien GitHub aura cette forme :
```
https://github.com/VOTRE-USERNAME/BanqueApp-Projet
```

C'est ce lien que vous enverrez au professeur.

---

## ⚠️ Problèmes Courants

### Erreur "remote origin already exists"
```bash
git remote remove origin
git remote add origin https://github.com/YOUR-USERNAME/REPO-NAME.git
```

### Erreur d'authentification
- Utilisez un **Personal Access Token** au lieu du mot de passe
- Générez-le dans : GitHub → Settings → Developer settings → Personal access tokens

### Fichiers trop volumineux
- Vérifiez que `.gitignore` exclut bien `bin/` et `obj/`

---

## ✅ Projet Prêt !

Une fois ces étapes complétées :
1. ✅ Votre projet est sur GitHub
2. ✅ Vous pouvez envoyer le lien au professeur
3. ✅ Tous les livrables sont présents et accessibles

Bon courage ! 🚀
