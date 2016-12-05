DogadjajiDelegati
=================

PretplataNaDogadjaje
--------------------
Primjer Windows Forms aplikacije u kojoj se forma kontrola pretplaćuje na događaje
i prosljeđuje informacije drugoj kontroli na formi.

Primijetiti kako objekti koji generiraju događaje (kontrole) ne znaju ništa o objektima
koji slušaju događaje (nemaju referencu na slušatelje).


StatickeNestatickeDelegatskeMetode
----------------------------------
Primjer definicije delegata, inicijalizacije i poziva delegatskih funkcija.


ProsljedjivanjeDelegata
-----------------------
Jednostavni primjer prosljeđivanja delegata za ispis vrijednosti proizvoljne funkcije u zadanom intervalu.


UlancavanjeDelegata
-------------------
Primjer nadovezivanja metoda u delegatu tako da se sve metode izvode jednim pozivom.


GetInvocationList
-----------------
Dohvaćanje pojedinih metoda u delegatskoj listi kada je rezultat svake metode bitan.


AnonimneMetode
--------------
Primjer korištenja anonimne metode koja se pokreće u novoj niti izvođenja.


BlokiranjeGlavneNiti
--------------------
(nema veze s događajima i delegatima već je nadopuna prethodnog primjera)
Primjer koji pokazuje zašto višenitno izvođenje može biti korisno.
Kada se pritisne tipka, blokira se glavna nit na 10 sekundi
i za to vrijeme aplikacija uopće ne reagira.


LambdaIzrazi
------------
Primjer korištenja lambda izraza.


DefiniranjeDogadjaja
--------------------
Primjer kako definirati klasu koja generira dogadjaje novog tipa te 
kako se slušatelji mogu prijaviti za te događaje.


CurenjeMemorijeZbogNeodjave
---------------------------
Ilustracija kako neodjavljivanje slušatelja uzrokuje curenje memorije.


DogadjajiVirtualneMetode
------------------------
Ilustracija kako i zašto se događaji generiraju u virtualnim metodama.
