-- Création de la base de données
CREATE DATABASE GestionTaches;
USE GestionTaches;

-- Table Projet
CREATE TABLE Projet (
    id_projet INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(255) NOT NULL,
    description_projet TEXT,
    date_creation DATE NOT NULL,
    date_fin DATE,
    statut VARCHAR(50)
);

-- Table Utilisateur
CREATE TABLE Utilisateur (
    id_utilisateur INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(255) NOT NULL,
    email VARCHAR(191) NOT NULL UNIQUE,
    motdepasse VARCHAR(255) NOT NULL,
    role VARCHAR(50)
);


-- Table Tache
CREATE TABLE Tache (
    id_tache INT AUTO_INCREMENT PRIMARY KEY,
    nom_tache VARCHAR(255) NOT NULL,
    description TEXT,
    statut VARCHAR(50),
    priorite VARCHAR(50),
    date_echeance DATE,
    id_projet INT NOT NULL,
    id_utilisateur INT NOT NULL,
    FOREIGN KEY (id_projet) REFERENCES Projet(id_projet) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_utilisateur) REFERENCES Utilisateur(id_utilisateur) ON DELETE CASCADE ON UPDATE CASCADE
);

-- Table Commentaire
CREATE TABLE Commentaire (
    id_commentaire INT AUTO_INCREMENT PRIMARY KEY,
    commentaire TEXT NOT NULL,
    date_commentaire DATETIME DEFAULT CURRENT_TIMESTAMP,
    id_tache INT NOT NULL,
    FOREIGN KEY (id_tache) REFERENCES Tache(id_tache) ON DELETE CASCADE ON UPDATE CASCADE
);

INSERT INTO Utilisateur (id_utilisateur, nom, email, motdepasse, role) VALUES(1, 'Jean Michel', 'jean.michel@gmail.com', '2dvX5d7w9Gk2SM', 1);
INSERT INTO Utilisateur (id_utilisateur, nom, email, motdepasse, role) VALUES(2, 'Claude Francois', 'claude.francois@gmail.com', 'XvG2dkw7MS952d', 0);
INSERT INTO Utilisateur (id_utilisateur, nom, email, motdepasse, role) VALUES(3, 'Hugo Tavernier', 'hugo.tavernier@orange.com', 'w5X2kd7M2GvdS9', 0);
INSERT INTO Utilisateur (id_utilisateur, nom, email, motdepasse, role) VALUES(4, 'Flavio Dettori', 'flavio.dettori@gmail.com', 'S27vXMGk95w2dd', 0);
INSERT INTO Utilisateur (id_utilisateur, nom, email, motdepasse, role) VALUES(5, 'Matthew LaMarche', 'matthew.lamarche@gmail.com', 'Gdv9dkS2X2M5w7', 0);
