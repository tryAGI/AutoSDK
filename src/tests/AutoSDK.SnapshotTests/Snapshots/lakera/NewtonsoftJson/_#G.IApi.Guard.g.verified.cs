//HintName: G.IApi.Guard.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Screen content for threats<br/>
        /// Screens messages for prompt injection, jailbreaks, PII, profanity, malicious links, <br/>
        /// unknown links, relevant languages, and other threats. Returns a boolean flagged verdict <br/>
        /// along with per-category results.<br/>
        /// The messages array follows the OpenAI chat format with role and content fields.<br/>
        /// You can optionally specify a policy to customize which detectors run and their thresholds.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardResponse> GuardAsync(

            global::G.GuardRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Screen content for threats<br/>
        /// Screens messages for prompt injection, jailbreaks, PII, profanity, malicious links, <br/>
        /// unknown links, relevant languages, and other threats. Returns a boolean flagged verdict <br/>
        /// along with per-category results.<br/>
        /// The messages array follows the OpenAI chat format with role and content fields.<br/>
        /// You can optionally specify a policy to customize which detectors run and their thresholds.
        /// </summary>
        /// <param name="messages">
        /// Array of chat messages to screen. Follows the OpenAI chat format.
        /// </param>
        /// <param name="policy">
        /// Inline policy configuration that specifies which detectors to run and their thresholds.
        /// </param>
        /// <param name="breakdown">
        /// If true, returns per-message breakdown in the results.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="metadata">
        /// Optional metadata to attach to this screening request for logging/tracking.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GuardResponse> GuardAsync(
            global::System.Collections.Generic.IList<global::G.GuardMessage> messages,
            global::G.Policy? policy = default,
            bool? breakdown = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}