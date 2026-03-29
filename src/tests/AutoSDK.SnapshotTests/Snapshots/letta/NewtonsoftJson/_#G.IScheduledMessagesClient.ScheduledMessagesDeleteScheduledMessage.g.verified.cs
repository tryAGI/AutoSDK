//HintName: G.IScheduledMessagesClient.ScheduledMessagesDeleteScheduledMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IScheduledMessagesClient
    {
        /// <summary>
        /// Delete Scheduled Agent Message<br/>
        /// Delete a scheduled message by its ID for a specific agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="scheduledMessageId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScheduledMessagesDeleteScheduledMessageResponse> ScheduledMessagesDeleteScheduledMessageAsync(
            string agentId,
            string scheduledMessageId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Scheduled Agent Message<br/>
        /// Delete a scheduled message by its ID for a specific agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="scheduledMessageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScheduledMessagesDeleteScheduledMessageResponse> ScheduledMessagesDeleteScheduledMessageAsync(
            string agentId,
            string scheduledMessageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}