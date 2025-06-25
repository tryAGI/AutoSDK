﻿//HintName: G.IActionsClient.ActionsGetRepoPublicKey.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get a repository public key<br/>
        /// Gets your public key, which you need to encrypt secrets. You need to<br/>
        /// encrypt a secret before you can create or update secrets.<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsPublicKey> ActionsGetRepoPublicKeyAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}