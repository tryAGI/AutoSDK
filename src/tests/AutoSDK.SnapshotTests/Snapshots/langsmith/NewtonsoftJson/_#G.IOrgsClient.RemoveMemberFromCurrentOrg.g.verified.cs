﻿//HintName: G.IOrgsClient.RemoveMemberFromCurrentOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Remove Member From Current Org<br/>
        /// Remove a user from the current organization.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RemoveMemberFromCurrentOrgAsync(
            global::System.Guid identityId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}