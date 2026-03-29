//HintName: G.IPromptTemplatesClient.GetPromptTemplatesLabelsPromptIdentifierPost.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptTemplatesClient
    {
        /// <summary>
        /// Get Prompt Template Labels
        /// </summary>
        /// <param name="identifier">
        /// The identifier can be either the prompt name or the prompt id.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPromptTemplateLabelResponse> GetPromptTemplatesLabelsPromptIdentifierPostAsync(
            string identifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}