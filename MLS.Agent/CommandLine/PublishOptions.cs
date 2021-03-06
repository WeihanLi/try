// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using MLS.Agent.Tools;

namespace MLS.Agent.CommandLine
{
    public class PublishOptions
    {
        public PublishOptions(
            IDirectoryAccessor rootDirectory, 
            IDirectoryAccessor targetDirectory = null, 
            PublishFormat format = PublishFormat.Markdown)
        {
            RootDirectory = rootDirectory ?? throw new System.ArgumentNullException(nameof(rootDirectory));
            Format = format;
            TargetDirectory = targetDirectory ?? rootDirectory;
        }

        public IDirectoryAccessor RootDirectory { get; }

        public IDirectoryAccessor TargetDirectory { get; }

        public PublishFormat Format { get; }
    }
}