 -- exemple de création d'un compte admin
 -- pour la base de données
 GRANT ALL PRIVILEGES 
 ON RallyeLecture.* 
 TO adminRallyeLecture@localhost
 IDENTIFIED BY 'siojjr' 
 WITH GRANT OPTION;