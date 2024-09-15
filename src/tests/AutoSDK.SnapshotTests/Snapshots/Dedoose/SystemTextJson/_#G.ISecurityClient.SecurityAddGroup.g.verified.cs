//HintName: G.ISecurityClient.SecurityAddGroup.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// AddGroup.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="accessListId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserGroup> SecurityAddGroupAsync(
            string? token = default,
            global::System.Guid projectId = default,
            string? title = default,
            global::System.Guid accessListId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}