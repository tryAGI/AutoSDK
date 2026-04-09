//HintName: G.IToolsClient.CreateTool.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Create Tool<br/>
        /// Create a new tool
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> CreateToolAsync(

            global::G.ToolCreate request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool<br/>
        /// Create a new tool
        /// </summary>
        /// <param name="description">
        /// The description of the tool.
        /// </param>
        /// <param name="tags">
        /// Metadata tags.
        /// </param>
        /// <param name="sourceCode">
        /// The source code of the function.
        /// </param>
        /// <param name="sourceType">
        /// The source type of the function.<br/>
        /// Default Value: python
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema of the function (auto-generated from source_code if not provided)
        /// </param>
        /// <param name="argsJsonSchema">
        /// The args JSON schema of the function.
        /// </param>
        /// <param name="returnCharLimit">
        /// The maximum number of characters in the response.<br/>
        /// Default Value: 50000
        /// </param>
        /// <param name="pipRequirements">
        /// Optional list of pip packages required by this tool.
        /// </param>
        /// <param name="npmRequirements">
        /// Optional list of npm packages required by this tool.
        /// </param>
        /// <param name="defaultRequiresApproval">
        /// Whether or not to require approval before executing this tool.
        /// </param>
        /// <param name="enableParallelExecution">
        /// If set to True, then this tool will potentially be executed concurrently with other tools. Default False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> CreateToolAsync(
            string sourceCode,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? sourceType = default,
            object? jsonSchema = default,
            object? argsJsonSchema = default,
            int? returnCharLimit = default,
            global::System.Collections.Generic.IList<global::G.PipRequirement>? pipRequirements = default,
            global::System.Collections.Generic.IList<global::G.NpmRequirement>? npmRequirements = default,
            bool? defaultRequiresApproval = default,
            bool? enableParallelExecution = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}