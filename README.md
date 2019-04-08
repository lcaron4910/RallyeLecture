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

### Cas d'utilisation

![Capture.png](https://image.noelshack.com/fichiers/2019/13/3/1553701046-capture.png)<br>


### Diagrammes de classe

![Capture2.png](https://image.noelshack.com/fichiers/2019/13/3/1553701172-capture2.png)<br>
![Capture3.png](https://image.noelshack.com/fichiers/2019/13/3/1553701182-capture3.png)<br>


### Développement

Nous retrouvons donc deux interfaces Windows Forms :

![Capture.png](https://image.noelshack.com/fichiers/2019/13/3/1553695324-capture.png)<br>
La première permet à un enseignant (et uniquement à un enseignant) de se connecter à l'application.

![Capture2.png](https://image.noelshack.com/fichiers/2019/13/3/1553695327-capture2.png)<br>
La seconde est donc l'interface principale.
Nous y retrouvons : 
* Choix d'un répertoire contenant des csv.
* Choix du csv à utiliser.
* Choix de l'année scolaire.
* Choix du niveau scolaire.
* Choix de la génération du mot de passe.

### Schéma de la base de données
![Capture.png](https://image.noelshack.com/fichiers/2019/13/3/1553696893-capture3.png)<br> 

![Capture.png](https://image.noelshack.com/fichiers/2019/13/3/1553696895-capture4.png)
