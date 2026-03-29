//HintName: G.Models.EndedCallSchemaForInsert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndedCallSchemaForInsert
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exception")]
        public string? Exception { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SummaryInsertMap Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_run_step_end")]
        public int? WbRunStepEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndedCallSchemaForInsert" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="endedAt"></param>
        /// <param name="summary"></param>
        /// <param name="exception"></param>
        /// <param name="output"></param>
        /// <param name="wbRunStepEnd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndedCallSchemaForInsert(
            string projectId,
            string id,
            global::System.DateTime endedAt,
            global::G.SummaryInsertMap summary,
            string? exception,
            object? output,
            int? wbRunStepEnd)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EndedAt = endedAt;
            this.Exception = exception;
            this.Output = output;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.WbRunStepEnd = wbRunStepEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndedCallSchemaForInsert" /> class.
        /// </summary>
        public EndedCallSchemaForInsert()
        {
        }
    }
}