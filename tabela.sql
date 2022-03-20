CREATE DATABASE Elektronski_dnevnik;
USE Elektronski_dnevnik;
USE Proba;
DROP DATABASE Elektronski_dnevnik;

CREATE TABLE Osoba(
  id INT PRIMARY KEY IDENTITY(1, 1),
  ime NVARCHAR(20) NOT NULL,
  prezime NVARCHAR(20) NOT NULL,
  adresa NVARCHAR(50),
  jmbg CHAR(13) NOT NULL,
  email NVARCHAR(30) NOT NULL,
  pass NVARCHAR(20) NOT NULL,
  uloga NVARCHAR(20) NOT NULL
);

CREATE TABLE Smer(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(50)
);

CREATE TABLE Predmet(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(40) NOT NULL,
  razred INT NOT NULL
);

CREATE TABLE Skolska_godina(
  id INT PRIMARY KEY IDENTITY(1, 1),
  naziv NVARCHAR(10) NOT NULL
);

CREATE TABLE Odeljenje(
  id INT PRIMARY KEY IDENTITY(1, 1),
  razred INT NOT NULL,
  indeks CHAR(2) NOT NULL,
  smer_id INT FOREIGN KEY REFERENCES Smer(id),
  razredni_id INT FOREIGN KEY REFERENCES Osoba(id),
  godina_id INT FOREIGN KEY REFERENCES Skolska_godina(id)
);

CREATE TABLE Upisnica(
  id INT PRIMARY KEY IDENTITY(1, 1),
  osoba_id INT FOREIGN KEY REFERENCES Osoba(id),
  odeljenje_id INT FOREIGN KEY REFERENCES Odeljenje(id)
);

CREATE TABLE Raspodela(
  id INT PRIMARY KEY IDENTITY(1, 1),
  nastavnik_id INT FOREIGN KEY REFERENCES Osoba(id),
  godina_id INT FOREIGN KEY REFERENCES Skolska_godina(id),
  predmet_id INT FOREIGN KEY REFERENCES Predmet(id),
  odeljenje_id INT FOREIGN KEY REFERENCES Odeljenje(id)
);

CREATE TABLE Ocena(
  id INT PRIMARY KEY IDENTITY(1, 1),
  datum DATE,
  raspodela_id INT FOREIGN KEY REFERENCES Raspodela(id),
  ocena INT NOT NULL,
  ucenik_id INT FOREIGN KEY REFERENCES Osoba(id)
);

INSERT INTO Osoba(ime, prezime, adresa, jmbg, email, pass, uloga) VALUES('PETAR', 'NIKOLIC', 'TADEUSA KOSCUSKA 78', '120703710170', 'petar.nikolic@prva.rs', 'ddd', 'ucenik');
INSERT INTO Osoba(ime, prezime, jmbg, email, pass, uloga) VALUES('JOVAN', 'SAVIC', '2108003524715', 'jovanzsavic@gmail.com', 'Savkela25', 'ucenik');
INSERT INTO Osoba(ime, prezime, jmbg, email, pass, uloga) VALUES('Miloš', 'Pušić', '0101070956018', 'smoki77@yahoo.com', 'milospusic12', 'profesor');
INSERT INTO Osoba(ime, prezime, adresa, jmbg, email, pass, uloga) VALUES('Valentina', 'Popović', 'Cara Dušana 1', '1009080132564', 'valentina.popovic@gmail.com', 'valerijo15', 'profesor');

SELECT *
FROM Osoba;

DELETE FROM Osoba;

SELECT *
FROM Smer;

SELECT *
FROM Predmet;

SELECT *
FROM Skolska_godina;

SELECT *
FROM Odeljenje;

SELECT *
FROM Upisnica;

SELECT *
FROM Raspodela;

SELECT *
FROM Ocena;

UPDATE Osoba
SET ime = 'PETAR'
WHERE id = 1;