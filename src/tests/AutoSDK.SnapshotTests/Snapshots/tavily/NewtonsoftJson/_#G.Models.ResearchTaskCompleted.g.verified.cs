//HintName: G.Models.ResearchTaskCompleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"request_id":"123e4567-e89b-12d3-a456-426614174111","created_at":"2025-01-15T10:30:00Z","status":"completed","content":"Research Report: Latest Developments in AI\n\n## Executive Summary\n\nArtificial Intelligence has seen significant advancements in recent months, with major breakthroughs in large language models, multimodal AI systems, and real-world applications...","sources":[{"title":"Latest AI Developments","url":"https://example.com/ai-news","favicon":"https://example.com/favicon.ico"},{"title":"AI Research Breakthroughs","url":"https://example.com/ai-research","favicon":"https://example.com/favicon.ico"}],"response_time":1.23}
    /// </summary>
    public sealed partial class ResearchTaskCompleted
    {
        /// <summary>
        /// The unique identifier of the research task.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174111
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174111</example>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// Timestamp when the research task was created.<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </summary>
        /// <example>2025-01-15T10:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The current status of the research task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResearchTaskCompletedStatusJsonConverter))]
        public global::G.ResearchTaskCompletedStatus Status { get; set; }

        /// <summary>
        /// The research report content. Can be a string or a structured object if output_schema was provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, object> Content { get; set; } = default!;

        /// <summary>
        /// List of sources used in the research.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sources", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResearchTaskCompletedSource> Sources { get; set; } = default!;

        /// <summary>
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 1.23F
        /// </summary>
        /// <example>1.23F</example>
        [global::Newtonsoft.Json.JsonProperty("response_time", Required = global::Newtonsoft.Json.Required.Always)]
        public int ResponseTime { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTaskCompleted" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier of the research task.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174111
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the research task was created.<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </param>
        /// <param name="content">
        /// The research report content. Can be a string or a structured object if output_schema was provided.
        /// </param>
        /// <param name="sources">
        /// List of sources used in the research.
        /// </param>
        /// <param name="responseTime">
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 1.23F
        /// </param>
        /// <param name="status">
        /// The current status of the research task.
        /// </param>
        public ResearchTaskCompleted(
            string requestId,
            string createdAt,
            global::G.OneOf<string, object> content,
            global::System.Collections.Generic.IList<global::G.ResearchTaskCompletedSource> sources,
            int responseTime,
            global::G.ResearchTaskCompletedStatus status)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
            this.Content = content;
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.ResponseTime = responseTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTaskCompleted" /> class.
        /// </summary>
        public ResearchTaskCompleted()
        {
        }
    }
}