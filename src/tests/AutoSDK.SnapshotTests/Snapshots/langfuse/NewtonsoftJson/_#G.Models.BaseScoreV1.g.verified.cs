//HintName: G.Models.BaseScoreV1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseScoreV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TraceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScoreSource Source { get; set; } = default!;

        /// <summary>
        /// The observation ID associated with the score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("observationId")]
        public string? ObservationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The user ID of the author
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorUserId")]
        public string? AuthorUserId { get; set; }

        /// <summary>
        /// Comment on the score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Metadata associated with the score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object Metadata { get; set; } = default!;

        /// <summary>
        /// Reference a score config on a score. When set, config and score name must be equal and value must comply to optionally defined numerical range
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configId")]
        public string? ConfigId { get; set; }

        /// <summary>
        /// The annotation queue referenced by the score. Indicates if score was initially created while processing annotation queue.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queueId")]
        public string? QueueId { get; set; }

        /// <summary>
        /// The environment from which this score originated. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Environment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseScoreV1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="traceId"></param>
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
        /// <param name="observationId">
        /// The observation ID associated with the score
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
        public BaseScoreV1(
            string id,
            string traceId,
            string name,
            global::G.ScoreSource source,
            global::System.DateTime timestamp,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object metadata,
            string environment,
            string? observationId,
            string? authorUserId,
            string? comment,
            string? configId,
            string? queueId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source;
            this.ObservationId = observationId;
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
        /// Initializes a new instance of the <see cref="BaseScoreV1" /> class.
        /// </summary>
        public BaseScoreV1()
        {
        }
    }
}