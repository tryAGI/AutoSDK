//HintName: G.IToolsClient.TestTool.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {

        /// <summary>
        /// Test Lambda tool<br/>
        /// Execute a Lambda tool with test inputs to verify it works correctly.<br/>
        /// This endpoint allows users to test their functions before using them with agents.<br/>
        /// The function is executed in a secure sandbox environment with the same constraints as production.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolId">
        /// Example: tol_python_function_123
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestToolResponse> TestToolAsync(
            string toolId,

            global::G.TestToolRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Test Lambda tool<br/>
        /// Execute a Lambda tool with test inputs to verify it works correctly.<br/>
        /// This endpoint allows users to test their functions before using them with agents.<br/>
        /// The function is executed in a secure sandbox environment with the same constraints as production.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolId">
        /// Example: tol_python_function_123
        /// </param>
        /// <param name="input">
        /// The input parameters to pass to the function. Must match the tool's input schema.<br/>
        /// Example: {"number":42,"text":"Hello, world!"}
        /// </param>
        /// <param name="timeoutSeconds">
        /// Maximum execution time in seconds. If not specified, uses the tool's configured timeout.<br/>
        /// Example: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestToolResponse> TestToolAsync(
            string toolId,
            object input,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? timeoutSeconds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}