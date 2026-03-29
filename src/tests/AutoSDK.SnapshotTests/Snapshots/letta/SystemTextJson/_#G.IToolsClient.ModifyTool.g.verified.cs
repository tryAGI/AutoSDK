//HintName: G.IToolsClient.ModifyTool.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Modify Tool<br/>
        /// Update an existing tool
        /// </summary>
        /// <param name="toolId">
        /// The ID of the tool in the format 'tool-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> ModifyToolAsync(
            string toolId,

            global::G.ToolUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify Tool<br/>
        /// Update an existing tool
        /// </summary>
        /// <param name="toolId">
        /// The ID of the tool in the format 'tool-&lt;uuid4&gt;'
        /// </param>
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
        /// The type of the source code.
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema of the function (auto-generated from source_code if not provided)
        /// </param>
        /// <param name="argsJsonSchema">
        /// The args JSON schema of the function.
        /// </param>
        /// <param name="returnCharLimit">
        /// The maximum number of characters in the response.
        /// </param>
        /// <param name="pipRequirements">
        /// Optional list of pip packages required by this tool.
        /// </param>
        /// <param name="npmRequirements">
        /// Optional list of npm packages required by this tool.
        /// </param>
        /// <param name="metadata">
        /// A dictionary of additional metadata for the tool.
        /// </param>
        /// <param name="defaultRequiresApproval">
        /// Whether or not to require approval before executing this tool.
        /// </param>
        /// <param name="enableParallelExecution">
        /// If set to True, then this tool will potentially be executed concurrently with other tools. Default False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> ModifyToolAsync(
            string toolId,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? sourceCode = default,
            string? sourceType = default,
            object? jsonSchema = default,
            object? argsJsonSchema = default,
            int? returnCharLimit = default,
            global::System.Collections.Generic.IList<global::G.PipRequirement>? pipRequirements = default,
            global::System.Collections.Generic.IList<global::G.NpmRequirement>? npmRequirements = default,
            object? metadata = default,
            bool? defaultRequiresApproval = default,
            bool? enableParallelExecution = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}