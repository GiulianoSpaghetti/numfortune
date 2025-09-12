# numerone's fortune

Un fortune teller per android e windows grafico.
Best usaed on surface 11.

## Come installare

## Su Android

[![google](https://play.google.com/intl/it_it/badges/static/images/badges/en_badge_web_generic.png)](https://play.google.com/store/apps/details?id=org.altervista.numerone.numfortune)

## Su Windows

Batsa prendere l'msix che più piace dalle release su github, che sono controllate e non contengono virus. Il package msix è associato ad un certificato .cer che bisogna installare in "Computer locale" > "Persone Attendibili".

Prerequisiti: 

https://winstall.app/apps/Microsoft.DotNet.DesktopRuntime.9

## Aggiornamenti

Per windows i package msix sono platform indepedent ed in IL, per cui è sufficiente scaricarsi il nuovo dotnet framework runtime e reinstallarsi il pacchetto per ottenere il codice binario ottimizzato con le ultime patch.


## Differenze tra il software maui ed il software avalonia

Il maui ha bisogno di girare in una sandbox, invece avalonia gira coi permessi dell'utente.
Per cui su windows è meglio usare l'avalonia.

## Screenshots

<img width="1431" alt="2025-02-01 (7)" src="https://github.com/user-attachments/assets/b912c33c-8ac9-43c7-b8f7-a225342e7952" />
<img width="1431" alt="2025-02-01 (6)" src="https://github.com/user-attachments/assets/41c2b49d-9ba1-49e0-89da-96b24ad45d59" />
<img width="1431" alt="2025-02-01 (5)" src="https://github.com/user-attachments/assets/25d691dc-78eb-4b28-895a-b48ef30a093c" />
<img width="1431" alt="2025-02-01 (4)" src="https://github.com/user-attachments/assets/8209a20e-fc84-44a7-be7b-bc990085ee3d" />


## Bug noti

Ci sono certi caratteri di escape che non vengono correttamente convertiti.

# Donazioni

http://numerone.altervista.org/donazioni.php
