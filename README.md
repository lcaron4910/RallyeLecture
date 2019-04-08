# RallyeLecture
Ce projet est une application Windows Form réalisée en C# permettant à un professeur d'alimenter une base de données avec un fichier .csv contenant tous les eleves d'une classe.

L'objectif de cette partie du PPE RallyeLecture n'est autre que la conception d'un programme permettant la réalisation des besoins d'un utilisateur dans un contexte professionnel définis.

Le projet est divisible en 3 grandes parties :

Lecture des informations contenues dans un fichier .csv .
Ecriture d'un fichier .csv avec les informations de connection de chaques eleves.
Alimentation de la base de données avec les informations receuillis.
Aperçus de l'interface Windows Form :

RallyeLecture C# WindowsForm

Cas D'utilisation
RallyeLecture C# Use Case Diagram

Installation & Configuration
Téléchargez le dossier .Zip sur Github de la solution.

Extrayez les fichiers sources du dossier .../Sources dans un projet de votre choix (exemple : un projet Visual Studio).

Créez une Base de Donnée (Nom au choix) puis insérez-y les scripts rallyelecture_structure.sql et Aauth_v2.sql présent dans le dossier .../Github/Database.

Pour les tests, ajoutez le jeu d'enregistrements rallyelecture_records.sql présent dans le dossier .../Github/Database.

Modifiez dans le fichier source ConnectionMySql.cs dans le dossier .../Sources :

user = "";  /* Entrez le nom d'utilisateur pour acceder à votre Serveur MySql */
passWord = "";  /* Entrez le mot de passe pour acceder à votre serveur MySql */
server = "";  /* Entrez l'adresse IP ou url de votre Serveur MySql */
database = ""; /* Entrez le nom de la BDD à utiliser */
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
