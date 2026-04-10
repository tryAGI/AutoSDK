//HintName: G.IPromptsClient.GetPromptVersionTags.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// List prompt version tags<br/>
        /// Retrieve all tags associated with a specific prompt version. Tags are used to identify and categorize different versions of a prompt.
        /// </summary>
        /// <param name="promptVersionId">
        /// The ID of the prompt version.
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination (base64-encoded promptVersionTag ID)
        /// </param>
        /// <param name="limit">
        /// The max number of tags to return at a time.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPromptVersionTagsResponseBody> GetPromptVersionTagsAsync(
            string promptVersionId,
            string? cursor = default,
            int? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}