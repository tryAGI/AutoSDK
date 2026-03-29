//HintName: G.IScheduledMessagesClient.ScheduledMessagesListScheduledMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IScheduledMessagesClient
    {
        /// <summary>
        /// List Scheduled Agent Messages<br/>
        /// List all scheduled messages for a specific agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScheduledMessagesListScheduledMessagesResponse> ScheduledMessagesListScheduledMessagesAsync(
            string agentId,
            string? limit = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}