//HintName: G.IPrompt2025Client.GetPrompt2025VersionBody.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompt2025Client
    {
        /// <summary>
        /// Get the full prompt body (messages, tools, etc.) for a specific prompt version.
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPrompt2025Version91PromptBody93String> GetPrompt2025VersionBodyAsync(
            string promptVersionId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}