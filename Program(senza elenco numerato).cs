// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi). 
 L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
-La lunghezza della classifica
-La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
-Il vostro cibo top (prima posizione della classifica)
-Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Le modalità di consegna sono le solite: repo GitHub, commit e push*/
string[] cibi = { "Crêpes", "Pizza","Cioccolato","Croissants","Riso" };
for (int i = 0; i < cibi.Length; i++)
{
    Console.WriteLine(cibi[i]);

}

var primocibo = cibi[0];
Console.WriteLine("Ecco il mio cibo preferito:"+primocibo);
var ultimocibo = cibi[4];
Console.WriteLine("Ecco il mio cibo preferito ma non troppo:"+cibi[4]);
