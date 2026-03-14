//HintName: G.IInstructionsClient.TestInstruction.g.cs
#nullable enable

namespace G
{
    public partial interface IInstructionsClient
    {
        /// <summary>
        /// Test instruction<br/>
        /// Test an instruction template using supplied context and available tools. This endpoint evaluates Velocity expressions such as `$tools`, `${session.metadata.field}`, or `${agent.metadata.field}`, and returns the fully rendered template output. Use this operation to validate formatting, logic, or metadata-dependent behavior before deploying instructions to agents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="instructionId">
        /// The unique identifier for an instruction.<br/>
        /// Example: ins_customer_support_init
        /// </param>
        /// <param name="version">
        /// Example: 1
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestInstructionResponse> TestInstructionAsync(
            string instructionId,

            global::G.TestInstructionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Test instruction<br/>
        /// Test an instruction template using supplied context and available tools. This endpoint evaluates Velocity expressions such as `$tools`, `${session.metadata.field}`, or `${agent.metadata.field}`, and returns the fully rendered template output. Use this operation to validate formatting, logic, or metadata-dependent behavior before deploying instructions to agents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="instructionId">
        /// The unique identifier for an instruction.<br/>
        /// Example: ins_customer_support_init
        /// </param>
        /// <param name="version">
        /// Example: 1
        /// </param>
        /// <param name="context">
        /// Context data to use when rendering the instruction template. This will be merged into `$session.metadata` for template access.<br/>
        /// Example: If you provide `{"currentDate": "2024-01-15"}`, you can access it in the template as `$session.metadata.currentDate`.<br/>
        /// Example: {"currentDate":"2024-01-15","companyName":"Acme Corp"}
        /// </param>
        /// <param name="tools">
        /// List of tools to include in the instruction context for testing.<br/>
        /// Default Value: []<br/>
        /// Example: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestInstructionResponse> TestInstructionAsync(
            string instructionId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? version = default,
            object? context = default,
            global::System.Collections.Generic.IList<global::G.Tool>? tools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}