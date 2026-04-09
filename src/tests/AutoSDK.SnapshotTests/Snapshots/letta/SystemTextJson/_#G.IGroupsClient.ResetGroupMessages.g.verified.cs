//HintName: G.IGroupsClient.ResetGroupMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Reset Group Messages<br/>
        /// Delete the group messages for all agents that are part of the multi-agent group.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the group in the format 'group-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> ResetGroupMessagesAsync(
            string groupId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}