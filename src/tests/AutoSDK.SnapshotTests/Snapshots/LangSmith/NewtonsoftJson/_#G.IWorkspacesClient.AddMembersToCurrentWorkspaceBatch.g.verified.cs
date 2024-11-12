//HintName: G.IWorkspacesClient.AddMembersToCurrentWorkspaceBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Add Members To Current Workspace Batch<br/>
        /// Batch invite up to 500 users to the current workspace and organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PendingIdentity>> AddMembersToCurrentWorkspaceBatchAsync(
            global::System.Collections.Generic.IList<global::G.PendingIdentityCreate> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}