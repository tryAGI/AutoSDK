//HintName: G.IPromptsClient.DeletePromptVersionTag.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Delete a tag from a prompt version<br/>
        /// Delete a tag from a specific prompt version by tag name. The tag is resolved within the scope of the prompt linked to the version.
        /// </summary>
        /// <param name="promptVersionId">
        /// The ID of the prompt version.
        /// </param>
        /// <param name="tagName">
        /// The name of the tag to delete.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePromptVersionTagAsync(
            string promptVersionId,
            string tagName,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}