//HintName: G.IToolsClient.RunToolFromSource.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Run Tool From Source<br/>
        /// Attempt to build a tool from source, then run it on the provided arguments
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolReturnMessage> RunToolFromSourceAsync(

            global::G.ToolRunFromSource request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Tool From Source<br/>
        /// Attempt to build a tool from source, then run it on the provided arguments
        /// </summary>
        /// <param name="sourceCode">
        /// The source code of the function.
        /// </param>
        /// <param name="args">
        /// The arguments to pass to the tool.
        /// </param>
        /// <param name="envVars">
        /// The environment variables to pass to the tool.
        /// </param>
        /// <param name="name">
        /// The name of the tool to run.
        /// </param>
        /// <param name="sourceType">
        /// The type of the source code.
        /// </param>
        /// <param name="argsJsonSchema">
        /// The args JSON schema of the function.
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema of the function (auto-generated from source_code if not provided)
        /// </param>
        /// <param name="pipRequirements">
        /// Optional list of pip packages required by this tool.
        /// </param>
        /// <param name="npmRequirements">
        /// Optional list of npm packages required by this tool.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolReturnMessage> RunToolFromSourceAsync(
            string sourceCode,
            object args,
            global::System.Collections.Generic.Dictionary<string, string>? envVars = default,
            string? name = default,
            string? sourceType = default,
            object? argsJsonSchema = default,
            object? jsonSchema = default,
            global::System.Collections.Generic.IList<global::G.PipRequirement>? pipRequirements = default,
            global::System.Collections.Generic.IList<global::G.NpmRequirement>? npmRequirements = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}