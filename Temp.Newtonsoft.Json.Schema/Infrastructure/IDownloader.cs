﻿#region License
// Copyright (c) Newtonsoft. All Rights Reserved.
// License: https://raw.github.com/JamesNK/Temp.Newtonsoft.Json.Schema/master/LICENSE.md
#endregion

using System;
using System.IO;
using System.Net;

namespace Temp.Newtonsoft.Json.Schema.Infrastructure
{
    internal interface IDownloader
    {
        Stream GetStream(Uri uri, ICredentials credentials, int? timeout, int? byteLimit);
    }
}
