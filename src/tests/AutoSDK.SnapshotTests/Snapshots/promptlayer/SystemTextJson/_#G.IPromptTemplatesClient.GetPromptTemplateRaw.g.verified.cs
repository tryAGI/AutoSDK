//HintName: G.IPromptTemplatesClient.GetPromptTemplateRaw.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptTemplatesClient
    {
        /// <summary>
        /// Get Prompt Template Raw Data<br/>
        /// Retrieve raw prompt template data without applying input variables. Designed for GitHub sync, local caching, and template inspection. By default, snippets are resolved (expanded). Use resolve_snippets=false to get the raw template with snippet references intact.
        /// </summary>
        /// <param name="identifier">
        /// The identifier can be either the prompt name or the prompt id.
        /// </param>
        /// <param name="version">
        /// Specific version number to retrieve. Mutually exclusive with `label`.
        /// </param>
        /// <param name="label">
        /// Release label name to retrieve (e.g. 'prod', 'staging'). Mutually exclusive with `version`.
        /// </param>
        /// <param name="resolveSnippets">
        /// When true (default), snippets are expanded in the returned prompt_template. When false, raw @@@snippet@@@ references are preserved.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeLlmKwargs">
        /// When true, includes provider-specific llm_kwargs in the response. Requires model metadata to be set on the template.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPromptTemplateRawResponse> GetPromptTemplateRawAsync(
            string identifier,
            int? version = default,
            string? label = default,
            bool? resolveSnippets = default,
            bool? includeLlmKwargs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}