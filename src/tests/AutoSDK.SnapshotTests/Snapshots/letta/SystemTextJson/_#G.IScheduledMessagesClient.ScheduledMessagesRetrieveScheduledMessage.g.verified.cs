//HintName: G.IScheduledMessagesClient.ScheduledMessagesRetrieveScheduledMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IScheduledMessagesClient
    {
        /// <summary>
        /// Retrieve Scheduled Agent Message<br/>
        /// Retrieve a scheduled message by its ID for a specific agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="scheduledMessageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScheduledMessagesRetrieveScheduledMessageResponse> ScheduledMessagesRetrieveScheduledMessageAsync(
            string agentId,
            string scheduledMessageId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}