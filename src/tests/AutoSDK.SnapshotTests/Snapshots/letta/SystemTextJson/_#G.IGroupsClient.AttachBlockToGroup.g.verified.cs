//HintName: G.IGroupsClient.AttachBlockToGroup.g.cs
#nullable enable

namespace G
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Attach Block To Group<br/>
        /// Attach a block to a group.<br/>
        /// This will add the block to the group and all agents within the group.
        /// </summary>
        /// <param name="blockId"></param>
        /// <param name="groupId">
        /// The ID of the group in the format 'group-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> AttachBlockToGroupAsync(
            string blockId,
            string groupId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}