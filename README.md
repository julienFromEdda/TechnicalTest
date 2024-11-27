# Test Technique Angular / C#

Bienvenue dans le test technique sur les technologies Angular / .NET

Les versions utilisées pour le test sont :
* Angular 19
* .NET 9

Après récupération et installation des 2 projets, il faut modifier le front pour gérer l'affichage d'une table (de préférence le [composant table d'Angular material](https://material.angular.io/components/table/overview)) affichant les données récupérées via l'API.

Ensuite, il faut implémenter une pagination côté serveur afin de ne pas afficher les 1000 résultats à la fois, mais 20 par 20.

Le lien entre le front Angular et l'API C# est déjà créé et le composant principal du front affiche déjà la liste des utilisateurs.

Le tableau doit présenter le nom, le prénom et l'adresse email des différents utilisateurs, le mécanisme de pagination est libre de choix, la seule contrainte étant que ce soit l'API qui effectue cette pagination.

Bonus :
-------
Implémenter côté front un champ de recherche afin de pouvoir filtrer la liste des utilisateurs, il existe déjà dans la requête vers le serveur un champ "Term" qui filtrera sur le nom et prénom des différents utilisateurs.

Ne pas oublier la gestion de la pagination lors du filtrage des données !
