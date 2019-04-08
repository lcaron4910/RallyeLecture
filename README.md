# RallyeLecture
Présentation du projet: RallyeLecture est un projet diviser en 2 partie : le site web rallyeLecture avec CodeIgniter ainsi que la librairie de gestion des droits d'accès.Puis une application Windows Form réalisée en C# permettant à un professeur d'alimenter une base de données avec un fichier .csv contenant tous les eleves d'une classe.

Les outils mis en oeuvre :

* git.
* Visual studio.
* SQL.
* Code Igniter.
* Fichier csv.

## Premiere Partie (Windows Form)
Le projet est divisible en 3 grandes parties :

Lecture des informations contenues dans un fichier .csv .
Ecriture d'un fichier .csv avec les informations de connection de chaques eleves.
Alimentation de la base de données avec les informations receuillis.
Aperçus de l'interface Windows Form :

RallyeLecture C# WindowsForm

Cas D'utilisation
RallyeLecture C# Use Case Diagram

Modifiez dans le fichier source ConnectionMySql.cs dans le dossier .../Sources :
```php
user = "";  /* Entrez le nom d'utilisateur pour acceder à votre Serveur MySql */
passWord = "";  /* Entrez le mot de passe pour acceder à votre serveur MySql */
server = "";  /* Entrez l'adresse IP ou url de votre Serveur MySql */
database = ""; /* Entrez le nom de la BDD à utiliser */
```
Schema BDD
RallyeLecture C# Schema BDD

Schema BDD aauth
RallyeLecture C# Schema BDD Aauth

Diagrammes de Classes
Classes métiers

RallyeLecture C# Class Diagram Job

Classes d'accès aux données

RallyeLecture C# Class Diagram BDD Access

Classes Techniques

RallyeLecture C# Class Diagram Technical
