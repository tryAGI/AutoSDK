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
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Timestamp when the research task was created.<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </summary>
        /// <example>2025-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The current status of the research task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResearchTaskCompletedStatusJsonConverter))]
        public global::G.ResearchTaskCompletedStatus Status { get; set; }

        /// <summary>
        /// The research report content. Can be a string or a structured object if output_schema was provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, object> Content { get; set; }

        /// <summary>
        /// List of sources used in the research.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ResearchTaskCompletedSource> Sources { get; set; }

        /// <summary>
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 1.23F
        /// </summary>
        /// <example>1.23F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResponseTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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