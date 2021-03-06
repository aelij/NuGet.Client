﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using NuGet.Packaging;
using NuGet.Versioning;

namespace NuGet.Commands
{
    public interface IProjectFactory
    {
        Dictionary<string, string> GetProjectProperties();
        void SetIncludeSymbols(bool includeSymbols);
        PackageBuilder CreateBuilder(string basePath, NuGetVersion version, string suffix, bool buildIfNeeded, PackageBuilder builder = null);
    }
}
