# Space Shooter Unity

## Règles du jeu

Ce jeu est un space shooter composé de deux écrans. Dans le premier, vous devez éviter les astéroïdes et les tirs des vaisseaux ennemis tout en les empêchant d'atteindre 
la bordure gauche de l'écran ce qui vous fera perdre des points. A contrario, détruire des ennemis rapporte des points. Une fois à 100 points, vous pouvez affronter le boss et la
difficulté augmentera légèrement. Une fois le boss vaincu, vous avez gagné la partie.

Il y a deux sortes de bonus, le power up (éclair) qui augmente la cadence de vos tirs et le cœur qui vous redonne de la vie ou du score si votre vie est déjà pleine.

Le jeu est relativement difficile et peut nécessiter plusieurs tentatives. (Testé à de nombreuses reprises par moi et deux autres personne)
Le jeu a été testé sur un PC avec une résolution de 1920x1080.

## Jouer 

- Si vous ne souhaitez pas télécharger le jeu, il est jouable directement [ici](https://ebourhis.github.io/SpaceConflict/).

## Téléchargement

- Le jeu est disponible en téléchargement [ici](https://github.com/eBOURHIS/Space-Conflict/releases).

## Cible

- Windows 32/64 bits, Navigateur Web

## Contrôles
### Clavier

- Flèches directionnelles pour se déplacer. 
- Espace pour tirer.

## Sources

- Bruitages des lasers : [Youtube](https://www.youtube.com/watch?v=C7rMBKhM-wY&t=43s).
- Musique du jeu : [Youtube](https://www.youtube.com/watch?v=UHClzbbpTds).
- Code de la barre de vie : [Unity Asset Store](https://assetstore.unity.com/packages/tools/gui/simple-health-bar-free-95420).

## Problèmes

- Problèmes de modification d'un gameObject mais pas de son prefab ce qui fait que le script ne se déclenche qu'en présence du gameObject d'origine et non de ses clones.
- Des problèmes rencontrés qu'après avoir build le jeu, comme la bar de vie qui fonctionnait dans l'éditeur mais pas après le build.
- Une fois l'écran de gameOver/Victoire atteint, relancer une partie sans quitter le jeu ne fonctionnait pas car les points de vie et le score restait ceux de l'ancienne partie.
- Sauvegarder le score.

## Solutions

- Avant de glisser un gameObject dans le dossier resources, bien faire en sorte de lui assigner tous ces scripts et autres modifications. Sinon ouvrir l'éditeur de prefab
- Le nom du prefab était en cause ce qui faisait apparaitre un problème après le build et pas avant. (Supprimer et recréer le prefab)
- Réinitialiser ces deux valeurs à chaque fois que le joueur (re)passe par la scène du Menu.


## Fonctionnalités

- Tirer et détruire des ennemis
- Récupérer des bonus qui offres des avantages différents
- Gestion des prefabs
- Gestion du son
- Singleton
- IA très basique (déplacement aléatoire)
- Jeu avec un début, un but et une fin.
