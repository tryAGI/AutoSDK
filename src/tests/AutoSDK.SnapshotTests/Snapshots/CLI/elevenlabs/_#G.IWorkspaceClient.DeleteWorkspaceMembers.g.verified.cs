//HintName: G.IWorkspaceClient.DeleteWorkspaceMembers.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Delete Member<br/>
        /// Deletes a workspace member. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteWorkspaceMemberResponseModel> DeleteWorkspaceMembersAsync(
            global::G.BodyDeleteMemberV1WorkspaceMembersDelete request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete Member<br/>
        /// Deletes a workspace member. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="email">
        /// Email of the target user.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteWorkspaceMemberResponseModel> DeleteWorkspaceMembersAsync(
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}