Afleveringsopgave af Maria Ahle 

Projektets formål:

Formålet med projektet er at lave en support-app, hvor en bruger kan oprette henvendelser og se dem på en liste. Vi lærer også at bruge Azure Cosmos DB til at gemme og hente data i skyen

Beskrivelse af hvordan man opretter en ny CosmosDB database, som passer til løsningen, med az -kommandoer:

Man opretter en ny database med CLI. Først logger man ind med sit az login og vælger abonnement med az account. Derefter opretter vi en ressourcegruppe med az group create og en Cosmos DB-konto til NoSQL med az cosmosdb create

Databasen oprettes med az cosmosdb SQL database create, og containeren oprettes med az cosmosdb SQL container create. Containerens partition key skal være /category, så den passer til løsningen. Til sidst konfigureres appen med connection string, databasenavn og containernavn via lokale User Secrets.

Beskriv status – hvad nåede I, hvad mangler og hvad synes I skal være næste trin:

Jeg nåede at implementere en Blazor-app, hvor en bruger kan oprette supporthenvendelser og se dem på en liste, og dataet bliver gemt i skyen.

Jeg mangler at lave validering og fejlhåndtering såsom at vise tydelige succes- og fejlbeskeder, hvilket er de næste trin

