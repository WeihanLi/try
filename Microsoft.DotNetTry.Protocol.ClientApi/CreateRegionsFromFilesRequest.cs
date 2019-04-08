﻿using System;
using Newtonsoft.Json;

namespace Microsoft.DotNetTry.Protocol.ClientApi
{
    public class CreateRegionsFromFilesRequest : MessageBase
    {
        [JsonProperty("files")]
        public SourceFile[] Files { get; }

        public CreateRegionsFromFilesRequest(string requestId, SourceFile[] files) : base(requestId)
        {
            if (files == null)
            {
                throw new ArgumentNullException(nameof(files));
            }

            if (files.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty collection.", nameof(files));
            }

            Files = files;
        }
    }
}