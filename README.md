# FirstDB
-Per prima cosa dobbiamo creare una cartella con il nome giusto\
-Poi dobbiamo aprire la cartella su visual studio code\
-Nel terminale scrivere 'dotnet new console'\
-Cliccare sul link che segue https://www.sqlitetutorial.net/sqlite-sample-database/ e scaricare il file per poi inserirlo nella cartella dove dobbiamo lavorare\
![image](https://user-images.githubusercontent.com/116791046/235087869-6c102804-fa96-4d1c-939b-7b4fe0c36987.png)\
-Poi possiamo iniziare a scrivere il codice\
-Prima cosa ricordarsi di aggiungere 'using SQLite'\
-Fondamentale aggiungere tramite il terminale la libreria che serve per il programma ![image](https://user-images.githubusercontent.com/116791046/235085335-e5c5da92-495e-462a-83e5-8345c106b4ea.png)\
-Dopo inizia il vero programma\
-Il comando che ci permette di accedere alla libreria è:\
###
    SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
###
-L'istruzione per scegliere specificatamente cosa voglio prendere del database è: 
###
    var tblArtist = cn1.Query<Artist>("select * from artists");
###
-Il comando che ci permette di vedere il numero di record dentro a una certa tabella è: 
###
    Console.WriteLine($"In questa tabella ci sono {tblArtist.Count} record" );
###

![image](https://user-images.githubusercontent.com/116791046/235087243-faf65896-e8b7-4809-8a06-50e08bf9758e.png)\
-Dobbiamo anche creare una classe che noi abbiamo nominato Artist\
![image](https://user-images.githubusercontent.com/116791046/236140245-b9ddbe3f-6c10-4e5a-ba05-1ed356b0590d.png)\
-Per ora il codice finisce così in caso di nuovi aggiornamenti verranno caricati nuovamente


