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
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exception")]
        public string? Exception { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SummaryInsertMap Summary { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_run_step_end")]
        public int? WbRunStepEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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