//HintName: G.Models.LegacyCreateScoreRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyCreateScoreRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceId")]
        public string? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("observationId")]
        public string? ObservationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetRunId")]
        public string? DatasetRunId { get; set; }

        /// <summary>
        /// Example: novelty
        /// </summary>
        /// <example>novelty</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The value of the score. Must be passed as string for categorical scores, and numeric for boolean and numeric scores
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateScoreValue Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The environment of the score. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// The annotation queue referenced by the score. Indicates if score was initially created while processing annotation queue.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queueId")]
        public string? QueueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataType")]
        public global::G.ScoreDataType? DataType { get; set; }

        /// <summary>
        /// Reference a score config on a score. The unique langfuse identifier of a score config. When passing this field, the dataType and stringValue fields are automatically populated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configId")]
        public string? ConfigId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyCreateScoreRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: novelty
        /// </param>
        /// <param name="value">
        /// The value of the score. Must be passed as string for categorical scores, and numeric for boolean and numeric scores
        /// </param>
        /// <param name="id"></param>
        /// <param name="traceId"></param>
        /// <param name="sessionId"></param>
        /// <param name="observationId"></param>
        /// <param name="datasetRunId"></param>
        /// <param name="comment"></param>
        /// <param name="metadata"></param>
        /// <param name="environment">
        /// The environment of the score. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
        /// </param>
        /// <param name="queueId">
        /// The annotation queue referenced by the score. Indicates if score was initially created while processing annotation queue.
        /// </param>
        /// <param name="dataType"></param>
        /// <param name="configId">
        /// Reference a score config on a score. The unique langfuse identifier of a score config. When passing this field, the dataType and stringValue fields are automatically populated.
        /// </param>
        public LegacyCreateScoreRequest(
            string name,
            global::G.CreateScoreValue value,
            string? id,
            string? traceId,
            string? sessionId,
            string? observationId,
            string? datasetRunId,
            string? comment,
            object? metadata,
            string? environment,
            string? queueId,
            global::G.ScoreDataType? dataType,
            string? configId)
        {
            this.Id = id;
            this.TraceId = traceId;
            this.SessionId = sessionId;
            this.ObservationId = observationId;
            this.DatasetRunId = datasetRunId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
            this.Comment = comment;
            this.Metadata = metadata;
            this.Environment = environment;
            this.QueueId = queueId;
            this.DataType = dataType;
            this.ConfigId = configId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyCreateScoreRequest" /> class.
        /// </summary>
        public LegacyCreateScoreRequest()
        {
        }
    }
}