//HintName: G.ISecurityClient.UpdateGroup.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// UpdateGroup<br/>
        /// UpdateGroup
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserGroup> UpdateGroupAsync(
            global::G.UpdateGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateGroup<br/>
        /// UpdateGroup
        /// </summary>
        /// <param name="group"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserGroup> UpdateGroupAsync(
            global::G.UserGroup group,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}