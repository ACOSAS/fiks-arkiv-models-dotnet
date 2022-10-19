#!/bin/bash

GENERATOR_PATH=KS.Fiks.Arkiv.XsdModelGenerator
MODELS_PATH=../KS.Fiks.Arkiv.Models.V1
SCHEMA_PATH=../KS.Fiks.Arkiv.Models.V1/bin/Debug/netstandard2.0/Schema/V1

cd $GENERATOR_PATH

dotnet.exe run $SCHEMA_PATH $MODELS_PATH
