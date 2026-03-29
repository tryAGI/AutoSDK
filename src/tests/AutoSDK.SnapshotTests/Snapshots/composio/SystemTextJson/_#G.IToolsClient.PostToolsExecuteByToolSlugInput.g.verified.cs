//HintName: G.IToolsClient.PostToolsExecuteByToolSlugInput.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Generate tool inputs from natural language<br/>
        /// Uses AI to translate a natural language description into structured arguments for a specific tool. This endpoint is useful when you want to let users describe what they want to do in plain language instead of providing structured parameters.
        /// </summary>
        /// <param name="toolSlug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolsExecuteByToolSlugInputResponse> PostToolsExecuteByToolSlugInputAsync(
            string toolSlug,

            global::G.PostToolsExecuteByToolSlugInputRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate tool inputs from natural language<br/>
        /// Uses AI to translate a natural language description into structured arguments for a specific tool. This endpoint is useful when you want to let users describe what they want to do in plain language instead of providing structured parameters.
        /// </summary>
        /// <param name="toolSlug"></param>
        /// <param name="text">
        /// Natural language description of what you want to accomplish with this tool<br/>
        /// Example: I need to trigger the main workflow in the octocat/Hello-World repository to deploy to production
        /// </param>
        /// <param name="customDescription">
        /// Custom description of the tool to help guide the LLM in generating more accurate inputs<br/>
        /// Example: This tool triggers GitHub Actions workflows in a repository. It requires the repository name, workflow ID, and optional input parameters.
        /// </param>
        /// <param name="systemPrompt">
        /// System prompt to control and guide the behavior of the LLM when generating inputs<br/>
        /// Example: You are an expert assistant that generates precise GitHub Actions workflow parameters. Extract exact repository names, workflow IDs, and input values from user descriptions.
        /// </param>
        /// <param name="version">
        /// Tool version to use when generating inputs (defaults to "latest" if not specified)<br/>
        /// Example: latest
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolsExecuteByToolSlugInputResponse> PostToolsExecuteByToolSlugInputAsync(
            string toolSlug,
            string text,
            string? customDescription = default,
            string? systemPrompt = default,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}