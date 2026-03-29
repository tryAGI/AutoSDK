//HintName: G.IGroupsClient.DetachBlockFromGroup.g.cs
#nullable enable

namespace G
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Detach Block From Group<br/>
        /// Detach a block from a group.<br/>
        /// This will remove the block from the group and all agents within the group.
        /// </summary>
        /// <param name="blockId"></param>
        /// <param name="groupId">
        /// The ID of the group in the format 'group-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> DetachBlockFromGroupAsync(
            string blockId,
            string groupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}