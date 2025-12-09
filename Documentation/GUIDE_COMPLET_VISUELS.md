# 🎨 Guide Complet : Maquettes et Diagrammes

## 📐 Diagramme UML avec PlantUML

### Option 1 : Générer en ligne (Le plus simple)

1. **J'ai créé le fichier** : `Documentation/diagramme-classes.puml`

2. **Copier tout le contenu** de ce fichier

3. **Aller sur** : http://www.plantuml.com/plantuml/uml/

4. **Coller le code** dans la zone de texte

5. **Cliquer sur "Submit"** → Le diagramme apparaît !

6. **Télécharger l'image** :
   - Clic droit sur l'image → "Save image as..."
   - Nom : `diagramme-classes-uml.png`
   - Sauvegarder dans : `Documentation/images/`

### Option 2 : Avec Visual Studio Code

1. **Installer l'extension** :
   - Ouvrir VS Code
   - Aller dans Extensions (Ctrl+Shift+X)
   - Chercher "PlantUML"
   - Installer l'extension de jebbs

2. **Ouvrir** `Documentation/diagramme-classes.puml`

3. **Prévisualiser** :
   - Appuyer sur Alt+D
   - Ou clic droit → "Preview Current Diagram"

4. **Exporter** :
   - Clic droit dans le fichier .puml
   - "Export Current Diagram"
   - Choisir PNG
   - Sauvegarder dans `Documentation/images/`

### Option 3 : Draw.io (Interface graphique)

Si PlantUML est trop technique :

1. **Aller sur** : https://app.diagrams.net/

2. **Créer un nouveau diagramme** :
   - Create New Diagram
   - Blank Diagram

3. **Utiliser les formes UML** :
   - Dans le panneau de gauche, chercher "UML"
   - Glisser-déposer les formes "Class"

4. **Créer les classes** :

**Classe Compte :**
```
┌─────────────────────────┐
│        Compte           │
├─────────────────────────┤
│ - Id : int              │
│ - Numero : string       │
│ - Titulaire : string    │
│ - TypeCompte : enum     │
│ - SoldeActuel : decimal │
│ - DateCreation : DateTime│
│ - DateDeblocage : DateTime?│
│ - Statut : enum         │
├─────────────────────────┤
│ + GetTotalDepots()      │
│ + GetTotalRetraits()    │
└─────────────────────────┘
```

**Classe Transaction :**
```
┌─────────────────────────┐
│      Transaction        │
├─────────────────────────┤
│ - Id : int              │
│ - Date : DateTime       │
│ - Type : enum           │
│ - Montant : decimal     │
│ - Description : string  │
│ - CompteId : int        │
├─────────────────────────┤
│ + EstDepot()            │
│ + EstRetrait()          │
└─────────────────────────┘
```

5. **Ajouter la relation** :
   - Ligne avec "1" du côté Compte
   - Ligne avec "*" du côté Transaction
   - Label : "possède"

6. **Exporter** :
   - File → Export as → PNG
   - Qualité : 300 DPI
   - Sauvegarder dans `Documentation/images/diagramme-classes-uml.png`

---

## 🎨 Maquettes Figma

### Écrans à créer (minimum 3)

#### 1. Page de Recherche
**Éléments :**
- En-tête avec logo "BanqueApp"
- Menu navigation : Accueil | Rechercher un compte
- Card centrale avec :
  - Titre : "🔍 Recherche de compte bancaire"
  - Input : "Numéro de compte"
  - Bouton : "Rechercher" (bleu)
  - Info box : Liste des comptes de test (CPT001-CPT005)

#### 2. Page Détails du Compte
**Sections :**

**Card 1 - Informations du compte** (Header bleu)
- Numéro : CPT001
- Titulaire : Ahmed Benali
- Type : Courant
- Solde : 15,000.00 DH (en vert, gros)
- Date création : 09/12/2022
- Statut : Badge vert "Actif"

**Card 2 - Statistiques** (Header cyan)
- 4 colonnes :
  - Total dépôts : 45,500 DH (vert)
  - Total retraits : 30,500 DH (rouge)
  - Nb transactions : 15
  - Dernière transaction : 08/12/2025

**Card 3 - Historique** (Header vert)
- Filtre dropdown : Tous | Dépôts | Retraits
- Tableau avec :
  - Date | Type (badge) | Description | Montant (coloré)
  - 5 lignes de transactions exemple
- Pagination : 1 2 3 (5 éléments actif)

#### 3. Page Compte Introuvable
**Éléments :**
- Card rouge centrée
- Icône ⚠️ (grande)
- Titre : "Compte introuvable"
- Texte : "Le numéro saisi n'existe pas"
- Bouton : "Retour à la recherche"

### Exporter depuis Figma

**Méthode 1 - Images :**
1. Sélectionner un écran (frame)
2. Dans panneau de droite : Export
3. Format : PNG, 2x
4. Export "Nom-ecran"
5. Sauvegarder dans `Documentation/screenshots/`

**Méthode 2 - Lien Figma (Recommandé) :**
1. Clic sur "Share" (en haut à droite)
2. "Anyone with the link" → "Can view"
3. Copier le lien
4. Me donner le lien pour que je l'ajoute au README

---

## ✅ Checklist Finale

### Diagramme UML
- [ ] Fichier .puml créé ✅ (déjà fait)
- [ ] Générer l'image PNG sur plantuml.com
- [ ] Sauvegarder dans `Documentation/images/diagramme-classes-uml.png`

### Maquettes Figma
- [ ] Créer les 3 écrans sur Figma
- [ ] Exporter en PNG (ou copier le lien)
- [ ] Placer dans `Documentation/screenshots/`

### Noms de fichiers attendus

**Images diagramme :**
- `Documentation/images/diagramme-classes-uml.png`

**Screenshots maquettes :**
- `Documentation/screenshots/maquette-recherche.png`
- `Documentation/screenshots/maquette-details.png`
- `Documentation/screenshots/maquette-erreur.png`

**OU simplement :**
- Lien Figma à me partager

---

## 🚀 Quand vous aurez terminé

**Dites-moi :**
1. ✅ "J'ai mis le diagramme UML dans images/"
2. ✅ "J'ai mis les maquettes dans screenshots/"
   
**OU**

3. ✅ "Voici mon lien Figma : [lien]"

**Et je mettrai automatiquement à jour tous les fichiers MD pour afficher vos images !**

---

**Bon courage ! N'hésitez pas si vous avez besoin d'aide.** 🎨
