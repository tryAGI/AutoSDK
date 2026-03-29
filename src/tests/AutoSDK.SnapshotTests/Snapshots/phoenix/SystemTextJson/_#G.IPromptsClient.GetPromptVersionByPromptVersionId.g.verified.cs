//HintName: G.IPromptsClient.GetPromptVersionByPromptVersionId.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompt version by ID<br/>
        /// Retrieve a specific prompt version using its unique identifier. A prompt version contains the actual template and configuration.
        /// </summary>
        /// <param name="promptVersionId">
        /// The ID of the prompt version.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPromptResponseBody> GetPromptVersionByPromptVersionIdAsync(
            string promptVersionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}