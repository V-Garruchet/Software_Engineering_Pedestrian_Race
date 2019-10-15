INSERT INTO `course` (`course_id`, `course_nom`) VALUES ('1', 'Course Bordeaux-Pessac');



INSERT INTO `participant` (`participant_NumDossard`, `participant_nom`, `participant_prenom`, `participant_sexe`, `participant_dateNaissance`, `participant_mail`, `participant_license`) VALUES (NULL, 'Cerond', 'Michel', 'M', '1956-11-01 00:00:00', 'mimich@yahoo.fr', 'MC1868');
INSERT INTO `participant` (`participant_NumDossard`, `participant_nom`, `participant_prenom`, `participant_sexe`, `participant_dateNaissance`, `participant_mail`, `participant_license`) VALUES (NULL, 'Fanzo', 'Robert', 'M', '1964-08-09 00:00:00', 'rob@yahoo.fr', 'RF7652');



INSERT INTO `resultat` (`resultat_id`, `resultat_temps`, `participant_numDossard`, `course_id`) VALUES (NULL, '2018-11-26 03:18:32', '1', '1');
INSERT INTO `resultat` (`resultat_id`, `resultat_temps`, `participant_numDossard`, `course_id`) VALUES (NULL, '2018-11-26 02:58:43', '2', '1');