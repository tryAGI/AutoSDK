//HintName: G.IWorkspacesClient.DeleteCurrentWorkspaceMember.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete Current Workspace Member
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteCurrentWorkspaceMemberAsync(
            global::System.Guid identityId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}