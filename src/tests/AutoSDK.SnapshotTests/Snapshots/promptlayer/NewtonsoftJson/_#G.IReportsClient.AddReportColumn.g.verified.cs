//HintName: G.IReportsClient.AddReportColumn.g.cs
#nullable enable

namespace G
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Add Column to Evaluation Pipeline<br/>
        /// Adds a new evaluation step (column) to an existing evaluation pipeline. Columns execute sequentially from left to right and can reference data from previous columns.<br/>
        /// **Column Types Available:**<br/>
        /// - **Primary**: PROMPT_TEMPLATE, ENDPOINT, MCP, HUMAN, CODE_EXECUTION, CODING_AGENT, CONVERSATION_SIMULATOR, WORKFLOW<br/>
        /// - **Evaluation**: LLM_ASSERTION, AI_DATA_EXTRACTION, COMPARE, CONTAINS, REGEX, REGEX_EXTRACTION, COSINE_SIMILARITY, ABSOLUTE_NUMERIC_DISTANCE<br/>
        /// - **Helper**: JSON_PATH, XML_PATH, PARSE_VALUE, APPLY_DIFF, VARIABLE, ASSERT_VALID, COALESCE, COMBINE_COLUMNS, COUNT, MATH_OPERATOR, MIN_MAX<br/>
        /// See the full documentation for detailed configuration requirements for each column type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddReportColumnResponse> AddReportColumnAsync(

            global::G.AddReportColumnRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Column to Evaluation Pipeline<br/>
        /// Adds a new evaluation step (column) to an existing evaluation pipeline. Columns execute sequentially from left to right and can reference data from previous columns.<br/>
        /// **Column Types Available:**<br/>
        /// - **Primary**: PROMPT_TEMPLATE, ENDPOINT, MCP, HUMAN, CODE_EXECUTION, CODING_AGENT, CONVERSATION_SIMULATOR, WORKFLOW<br/>
        /// - **Evaluation**: LLM_ASSERTION, AI_DATA_EXTRACTION, COMPARE, CONTAINS, REGEX, REGEX_EXTRACTION, COSINE_SIMILARITY, ABSOLUTE_NUMERIC_DISTANCE<br/>
        /// - **Helper**: JSON_PATH, XML_PATH, PARSE_VALUE, APPLY_DIFF, VARIABLE, ASSERT_VALID, COALESCE, COMBINE_COLUMNS, COUNT, MATH_OPERATOR, MIN_MAX<br/>
        /// See the full documentation for detailed configuration requirements for each column type.
        /// </summary>
        /// <param name="reportId">
        /// The ID of the evaluation pipeline to add this column to.
        /// </param>
        /// <param name="columnType">
        /// The type of evaluation or transformation this column performs. Must be one of the supported column types.
        /// </param>
        /// <param name="name">
        /// Display name for this column. Must be unique within the pipeline. This name is used to reference the column in subsequent steps.
        /// </param>
        /// <param name="configuration">
        /// Column-specific configuration. The schema varies based on column_type. See documentation for each type's requirements.
        /// </param>
        /// <param name="position">
        /// Optional position for the column. If not specified, the column is added at the end. Cannot overwrite dataset columns.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddReportColumnResponse> AddReportColumnAsync(
            int reportId,
            global::G.AddReportColumnRequestColumnType columnType,
            string name,
            object configuration,
            int? position = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}