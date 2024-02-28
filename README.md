# Kriptiranje-dekriptiranje-sazetak-digitalni_potpis

Stvoren je program koji omogućuje korisnicima sljedeće funkcionalnosti:

  * Generiranje i pohranjivanje kriptografskih ključeva u datoteke tajni_kljuc.txt, javni_kljuc.txt i privatni_kljuc.txt.
  
  * Kriptiranje i dekriptiranje zadane datoteke korištenjem simetričnih i asimetričnih algoritama.
  
  * Izračunavanje sažetka poruke (ulazne datoteke).
  
  * Digitalno potpisivanje ulazne datoteke te provjera digitalnog potpisa.
  
Za simetrično kriptiranje i dekriptiranje koristi se AES algoritam, dok se za asimetrično kriptiranje i dekriptiranje koristi RSA algoritam. Digitalni potpis se stvara pomoću RSA algoritma, dok se sažetak poruke izračunava korištenjem hash funkcije (SHA256). Sažetak se zatim kriptira privatnim ključem i dodaje izvornoj poruci/sadržaju. Program je razvijen u okviru Windows Forms aplikacije kroz jednostavnu i preglednu formu kako bi olakšao korisnicima korištenje. Za razvoj programa korišten je alat Visual Studio.

Upute za korištenje aplikacije nalaze se unutar datoteke "Patricio_Poldrugac_C#" u folderu: "upute.txt".
