//HintName: G.IWorkspacesClient.DeleteCurrentWorkspacePendingMember.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete Current Workspace Pending Member
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteCurrentWorkspacePendingMemberAsync(
            global::System.Guid identityId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}