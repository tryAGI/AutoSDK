//HintName: G.IGroupsClient.DeleteGroupId.g.cs
#nullable enable

namespace G
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Delete group<br/>
        /// Delete a group object by its id
        /// </summary>
        /// <param name="groupId">
        /// Group id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Group> DeleteGroupIdAsync(
            global::System.Guid groupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}