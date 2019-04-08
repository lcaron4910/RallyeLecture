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

## Deuxieme Partie (Web CodeIgniter)

Le projet se divise en 3 parties :

Connexion Administrateur / Utilisateur.
Gestion des Livres
Quizz sur les livres.

l'administateur du site qui controle tout.

![](https://image.noelshack.com/fichiers/2019/15/1/1554749033-capture3.png)

Nous nous sommes donc dans un premier temps intéressés à la pagination des pages du menu "LIVRE". On remarque sur l'image ci-dessous une numérotation des pages réalisées en php.

![](https://image.noelshack.com/fichiers/2019/15/1/1554749036-capture4.png)

Ensuite, nous avons cherché à ajouter la fonctionnalité de pouvoir créer de nouveaux livres et de les insérer dans la base de données.

![](https://image.noelshack.com/fichiers/2019/15/1/1554749034-capture5.png)



### Menu enseignant

L'enseignant, préalablement créée peut donc se connecter au site et avoir accès à divers menus :

![](https://image.noelshack.com/fichiers/2019/15/1/1554749032-capture2.png)


### Les éléves

Les éléves dont nous avons ajouter leurs identifants dans la base de données grâce à l'application C# peuvent eux aussi se connecter au site et avoir accès aux quizzs proposés par leurs professeurs.


### Diagramme du site

![](https://raw.githubusercontent.com/AureohDev/RallyeLectureWebApp/master/Github/Schema/schemaDbRallyeLecture.PNG)

![](https://raw.githubusercontent.com/AureohDev/RallyeLectureWebApp/master/Github/Schema/schemaDbAauth.PNG)
