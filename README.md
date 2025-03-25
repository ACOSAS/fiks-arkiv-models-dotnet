# Fiks Arkiv Models V1

## Nuget pakke for Fiks Arkiv

For spesifikasjonen for Fiks Arkiv, les [her](https://github.com/ks-no/fiks-arkiv-specification)

Dette repositoriet inneholder kode for å bygge en nuget-pakke som inneholder genererte C# klasser for Fiks Arkiv protokollen.
Den inneholder også xsd-skjemaene som de genererte C# klassene er basert på og som definerer meldingsinnhold i protokollen Fiks Arkiv.
I tillegg har den hjelpeklasser som f.eks. inneholder gyldige [meldingstyper](https://github.com/ks-no/fiks-arkiv-models-dotnet/tree/main/KS.Fiks.Arkiv.Models.V1/Meldingstyper) og [kodelister](https://github.com/ks-no/fiks-arkiv-models-dotnet/tree/main/KS.Fiks.Arkiv.Models.V1/Kodelister) i protokollen.
Disse hjelpeklassene kan brukes når man skal kode med Fiks Arkiv protokollen.

Skjemaene og spesifikasjonen er i følgende GitHub repository: https://github.com/ks-no/fiks-arkiv-specification

Der finnes også en [Wiki](https://github.com/ks-no/fiks-arkiv-specification/wiki) for Fiks Arkiv protokollen.

# Produserer nuget som inneholder XSD skjema og genererte modeller

## Skript for å generere modeller

`GenerateModels.sh` forventer at XSD-skjemaene er plassert under `/Schema/V1`. Den kopierer kopierer XSD skjema og generere C# klasser i prosjektet `KS.Fiks.Arkiv.Models` som blir pakket til nuget.


Se readme.md i `KS.Fiks.Arkiv.Models.V1` for bruk av nuget.
# fiks-arkiv-client (deprecated)

## OBS: Dette repoet er deprecated!
Nytt repository for skjema og spesifikasjonen finnes her: https://github.com/ks-no/fiks-arkiv-specification

Nytt repository som genererer .NET kode basert på spesifikasjonen nevnt ovenfor og leverer nuget-pakken [KS.Fiks.Arkiv.Models.V1](https://www.nuget.org/packages/KS.Fiks.Arkiv.Models.V1) finnes her: https://github.com/ks-no/fiks-arkiv-models-dotnet
#### Pakker:
Nuget-pakken som er resultatet av github-prosjektet.
- [KS.Fiks.Arkiv.Models.V1 (NuGet)](https://www.nuget.org/packages/KS.Fiks.Arkiv.Models.V1)