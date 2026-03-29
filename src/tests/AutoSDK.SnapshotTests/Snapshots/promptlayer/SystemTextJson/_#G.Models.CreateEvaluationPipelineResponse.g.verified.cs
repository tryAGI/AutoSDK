//HintName: G.Models.CreateEvaluationPipelineResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"success":true,"report_id":456,"report_columns":[{"id":789,"report_id":456,"column_type":"LLM_ASSERTION","name":"Language Check","position":2,"is_part_of_score":true,"configuration":{"source":"response","prompt":"Is the response written in {language}?","variable_mappings":{"language":"target_language"}}}]}
    /// </summary>
    public sealed partial class CreateEvaluationPipelineResponse
    {
        /// <summary>
        /// Indicates if the operation was successful<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// The unique ID of the created evaluation pipeline. Use this ID to run evaluations.<br/>
        /// Example: 456
        /// </summary>
        /// <example>456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReportId { get; set; }

        /// <summary>
        /// List of created columns (only present if columns were provided in the request)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_columns")]
        public global::System.Collections.Generic.IList<global::G.CreateEvaluationPipelineResponseReportColumn>? ReportColumns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates if the operation was successful<br/>
        /// Example: true
        /// </param>
        /// <param name="reportId">
        /// The unique ID of the created evaluation pipeline. Use this ID to run evaluations.<br/>
        /// Example: 456
        /// </param>
        /// <param name="reportColumns">
        /// List of created columns (only present if columns were provided in the request)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvaluationPipelineResponse(
            bool success,
            int reportId,
            global::System.Collections.Generic.IList<global::G.CreateEvaluationPipelineResponseReportColumn>? reportColumns)
        {
            this.Success = success;
            this.ReportId = reportId;
            this.ReportColumns = reportColumns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineResponse" /> class.
        /// </summary>
        public CreateEvaluationPipelineResponse()
        {
        }
    }
}