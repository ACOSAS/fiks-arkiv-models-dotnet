# Produserer nuget som inneholder XSD skjema og genererte modeller

## Skript for å generere modeller

`GenerateModels.sh` forventer at XSD-skjemaene er plassert under `/Schema/V1`. Den kopierer kopierer XSD skjema og generere C# klasser i prosjektet `KS.Fiks.Arkiv.Models` som blir pakket til nuget.

Se readme.md i `KS.Fiks.Arkiv.Models.V1` for bruk av nuget.
# fiks-arkiv-client (deprecated)

## OBS: Dette repoet er deprecated!
Nytt repository for skjema og spesifikasjonen finnes her: https://github.com/ks-no/fiks-arkiv-specification

Nytt repository som genererer .NET kode basert på spesifikasjonen nevnt ovenfor og leverer nuget-pakken [KS.Fiks.Arkiv.Models.V1](https://www.nuget.org/packages/KS.Fiks.Arkiv.Models.V1) finnes her: https://github.com/ks-no/fiks-arkiv-models-dotnet
