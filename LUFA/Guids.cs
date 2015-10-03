﻿// Guids.cs
// MUST match guids.h
using System;

namespace FourWalledCubicle.LUFA
{
    static class GuidList
    {
        public const string guidLUFAVSIXManifestString = "FourWalledCubicle.LUFA.0e160d5c-e331-48d9-850b-e0387912171b";
        public const string guidASFVSIXManifestString = "4ce20911-d794-4550-8b94-6c66a93228b8";

        public const string guidLUFAPkgString = "2cfcbce0-84cb-45dc-8315-cad3f82b9467";
        public const string guidLUFACmdSetString = "1f3dc770-b782-4cfd-b11a-b9065cdc6e70";

        public static readonly Guid guidLUFACmdSet = new Guid(guidLUFACmdSetString);
    };
}