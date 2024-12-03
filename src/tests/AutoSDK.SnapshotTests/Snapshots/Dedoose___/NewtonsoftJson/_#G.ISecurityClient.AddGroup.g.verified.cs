//HintName: G.ISecurityClient.AddGroup.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// AddGroup<br/>
        /// AddGroup
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserGroup> AddGroupAsync(
            global::G.AddGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddGroup<br/>
        /// AddGroup
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="accessListId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserGroup> AddGroupAsync(
            global::System.Guid projectId,
            string title,
            global::System.Guid accessListId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}