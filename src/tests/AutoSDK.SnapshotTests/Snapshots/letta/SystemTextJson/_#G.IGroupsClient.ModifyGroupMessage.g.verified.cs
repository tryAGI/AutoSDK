//HintName: G.IGroupsClient.ModifyGroupMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Modify Group Message<br/>
        /// Update the details of a message associated with an agent.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the group in the format 'group-&lt;uuid4&gt;'
        /// </param>
        /// <param name="messageId">
        /// The ID of the message in the format 'message-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.ModifyGroupMessageResponse> ModifyGroupMessageAsync(
            string groupId,
            string messageId,

            global::G.AnyOf<global::G.UpdateSystemMessage, global::G.UpdateUserMessage, global::G.UpdateReasoningMessage, global::G.UpdateAssistantMessage> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify Group Message<br/>
        /// Update the details of a message associated with an agent.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the group in the format 'group-&lt;uuid4&gt;'
        /// </param>
        /// <param name="messageId">
        /// The ID of the message in the format 'message-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.ModifyGroupMessageResponse> ModifyGroupMessageAsync(
            string groupId,
            string messageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}