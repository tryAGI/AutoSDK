//HintName: G.IToolsClient.TestLambdaToolWithoutCreation.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Test Lambda tool without creation<br/>
        /// Test a Lambda tool without creating it first. This endpoint allows you to validate code, discover schemas, and test execution before committing to tool creation.<br/>
        /// Use this to:<br/>
        /// - Validate Python code syntax and security constraints<br/>
        /// - Discover input/output schemas from type annotations<br/>
        /// - Test execution with sample input<br/>
        /// - Verify schema compatibility<br/>
        /// The function is executed in the same secure sandbox environment as production tools.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestLambdaToolResponse> TestLambdaToolWithoutCreationAsync(

            global::G.TestLambdaToolRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Test Lambda tool without creation<br/>
        /// Test a Lambda tool without creating it first. This endpoint allows you to validate code, discover schemas, and test execution before committing to tool creation.<br/>
        /// Use this to:<br/>
        /// - Validate Python code syntax and security constraints<br/>
        /// - Discover input/output schemas from type annotations<br/>
        /// - Test execution with sample input<br/>
        /// - Verify schema compatibility<br/>
        /// The function is executed in the same secure sandbox environment as production tools.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="language">
        /// The programming language. Currently only 'python' (Python 3.12) is supported.<br/>
        /// Default Value: python<br/>
        /// Example: python
        /// </param>
        /// <param name="code">
        /// The Python 3.12 code for the function. Must define a `process()` entry point.<br/>
        /// Object parameters must use `TypedDict`; bare `dict` and `Dict[K, V]` parameters are rejected.<br/>
        /// See the `code` field on `CreateLambdaToolRequest` for full details and examples.<br/>
        /// Example: def process(order_count: int, total_revenue: float) -&gt; dict:<br/>
        ///     score = order_count * 10 + total_revenue * 0.1<br/>
        ///     return {'score': round(score, 2)}
        /// </param>
        /// <param name="executionConfiguration">
        /// Execution configuration for the function.
        /// </param>
        /// <param name="testInput">
        /// The input parameters to test the function with. Will be validated against the discovered input schema.<br/>
        /// Example: {"order_count":10,"total_revenue":500}
        /// </param>
        /// <param name="timeoutSeconds">
        /// Maximum execution time in seconds for this test. Overrides execution_configuration if specified.<br/>
        /// Example: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestLambdaToolResponse> TestLambdaToolWithoutCreationAsync(
            string code,
            object testInput,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.TestLambdaToolRequestLanguage? language = default,
            global::G.ExecutionConfiguration? executionConfiguration = default,
            int? timeoutSeconds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}