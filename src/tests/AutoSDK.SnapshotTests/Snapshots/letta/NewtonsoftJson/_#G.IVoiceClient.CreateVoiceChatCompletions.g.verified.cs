//HintName: G.IVoiceClient.CreateVoiceChatCompletions.g.cs
#nullable enable

namespace G
{
    public partial interface IVoiceClient
    {
        /// <summary>
        /// Create Voice Chat Completions<br/>
        /// DEPRECATED: This voice-beta endpoint has been deprecated.<br/>
        /// The voice functionality has been integrated into the main chat completions endpoint.<br/>
        /// Please use the standard /v1/agents/{agent_id}/messages endpoint instead.<br/>
        /// This endpoint will be removed in a future version.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> CreateVoiceChatCompletionsAsync(
            string agentId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Voice Chat Completions<br/>
        /// DEPRECATED: This voice-beta endpoint has been deprecated.<br/>
        /// The voice functionality has been integrated into the main chat completions endpoint.<br/>
        /// Please use the standard /v1/agents/{agent_id}/messages endpoint instead.<br/>
        /// This endpoint will be removed in a future version.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> CreateVoiceChatCompletionsAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}