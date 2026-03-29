//HintName: G.IPromptsClient.GetPromptVersionByTagName.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompt version by tag<br/>
        /// Retrieve a specific prompt version using its tag name. Tags are used to identify specific versions of a prompt.
        /// </summary>
        /// <param name="promptIdentifier">
        /// The identifier of the prompt, i.e. name or ID.
        /// </param>
        /// <param name="tagName">
        /// The tag of the prompt version
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPromptResponseBody> GetPromptVersionByTagNameAsync(
            string promptIdentifier,
            string tagName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}