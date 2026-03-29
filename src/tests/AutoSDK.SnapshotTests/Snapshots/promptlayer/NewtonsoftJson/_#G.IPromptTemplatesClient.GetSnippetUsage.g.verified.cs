//HintName: G.IPromptTemplatesClient.GetSnippetUsage.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptTemplatesClient
    {
        /// <summary>
        /// Get Snippet Usage<br/>
        /// Get all prompts that use a given snippet (prompt template). Returns a list of prompts and their version numbers that reference this snippet.
        /// </summary>
        /// <param name="identifier">
        /// The identifier can be either the prompt name or the prompt id.
        /// </param>
        /// <param name="promptVersionNumber">
        /// Optional specific version number to check usage for
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetSnippetUsageResponse> GetSnippetUsageAsync(
            string identifier,
            int? promptVersionNumber = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}