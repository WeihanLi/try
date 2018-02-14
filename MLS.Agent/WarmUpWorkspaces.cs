﻿using System;
using System.Threading;
using System.Threading.Tasks;
using WorkspaceServer;

namespace MLS.Agent
{
    public class WarmUpWorkspaces : HostedService
    {
        private readonly WorkspaceServerRegistry workspaceServerRegistry;

        public WarmUpWorkspaces(WorkspaceServerRegistry workspaceServerRegistry)
        {
            this.workspaceServerRegistry = workspaceServerRegistry ??
                                           throw new ArgumentNullException(nameof(workspaceServerRegistry));
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return;
            }

            await workspaceServerRegistry.StartAllServers();
        }
    }
}