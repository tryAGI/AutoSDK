//HintName: G.IWorkspacesClient.AddMemberToCurrentWorkspace.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Add Member To Current Workspace<br/>
        /// Add an existing organization member to the current workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Identity> AddMemberToCurrentWorkspaceAsync(
            global::G.IdentityCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Member To Current Workspace<br/>
        /// Add an existing organization member to the current workspace.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="orgIdentityId"></param>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Identity> AddMemberToCurrentWorkspaceAsync(
            global::System.Guid? userId = default,
            global::System.Guid? orgIdentityId = default,
            bool? readOnly = default,
            global::System.Guid? roleId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}