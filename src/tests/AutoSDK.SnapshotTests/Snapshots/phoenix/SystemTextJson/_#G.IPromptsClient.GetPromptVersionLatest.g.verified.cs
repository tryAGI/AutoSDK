//HintName: G.IPromptsClient.GetPromptVersionLatest.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get latest prompt version<br/>
        /// Retrieve the most recent version of a specific prompt.
        /// </summary>
        /// <param name="promptIdentifier">
        /// The identifier of the prompt, i.e. name or ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPromptResponseBody> GetPromptVersionLatestAsync(
            string promptIdentifier,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}