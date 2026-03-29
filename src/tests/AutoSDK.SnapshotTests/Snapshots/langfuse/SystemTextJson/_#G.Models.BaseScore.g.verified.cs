//HintName: G.Models.BaseScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseScore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The trace ID associated with the score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        public string? TraceId { get; set; }

        /// <summary>
        /// The session ID associated with the score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The observation ID associated with the score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observationId")]
        public string? ObservationId { get; set; }

        /// <summary>
        /// The dataset run ID associated with the score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetRunId")]
        public string? DatasetRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScoreSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ScoreSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The user ID of the author
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorUserId")]
        public string? AuthorUserId { get; set; }

        /// <summary>
        /// Comment on the score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Metadata associated with the score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Reference a score config on a score. When set, config and score name must be equal and value must comply to optionally defined numerical range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configId")]
        public string? ConfigId { get; set; }

        /// <summary>
        /// The annotation queue referenced by the score. Indicates if score was initially created while processing annotation queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueId")]
        public string? QueueId { get; set; }

        /// <summary>
        /// The environment from which this score originated. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseScore" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="source"></param>
        /// <param name="timestamp"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="metadata">
        /// Metadata associated with the score
        /// </param>
        /// <param name="environment">
        /// The environment from which this score originated. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
        /// </param>
        /// <param name="traceId">
        /// The trace ID associated with the score
        /// </param>
        /// <param name="sessionId">
        /// The session ID associated with the score
        /// </param>
        /// <param name="observationId">
        /// The observation ID associated with the score
        /// </param>
        /// <param name="datasetRunId">
        /// The dataset run ID associated with the score
        /// </param>
        /// <param name="authorUserId">
        /// The user ID of the author
        /// </param>
        /// <param name="comment">
        /// Comment on the score
        /// </param>
        /// <param name="configId">
        /// Reference a score config on a score. When set, config and score name must be equal and value must comply to optionally defined numerical range
        /// </param>
        /// <param name="queueId">
        /// The annotation queue referenced by the score. Indicates if score was initially created while processing annotation queue.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseScore(
            string id,
            string name,
            global::G.ScoreSource source,
            global::System.DateTime timestamp,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object metadata,
            string environment,
            string? traceId,
            string? sessionId,
            string? observationId,
            string? datasetRunId,
            string? authorUserId,
            string? comment,
            string? configId,
            string? queueId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TraceId = traceId;
            this.SessionId = sessionId;
            this.ObservationId = observationId;
            this.DatasetRunId = datasetRunId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source;
            this.Timestamp = timestamp;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AuthorUserId = authorUserId;
            this.Comment = comment;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ConfigId = configId;
            this.QueueId = queueId;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseScore" /> class.
        /// </summary>
        public BaseScore()
        {
        }
    }
}