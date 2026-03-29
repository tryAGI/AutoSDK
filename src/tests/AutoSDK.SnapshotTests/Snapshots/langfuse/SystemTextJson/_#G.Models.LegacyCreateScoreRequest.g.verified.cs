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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        public string? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observationId")]
        public string? ObservationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetRunId")]
        public string? DatasetRunId { get; set; }

        /// <summary>
        /// Example: novelty
        /// </summary>
        /// <example>novelty</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The value of the score. Must be passed as string for categorical scores, and numeric for boolean and numeric scores
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateScoreValueJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateScoreValue Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The environment of the score. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// The annotation queue referenced by the score. Indicates if score was initially created while processing annotation queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueId")]
        public string? QueueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScoreDataTypeJsonConverter))]
        public global::G.ScoreDataType? DataType { get; set; }

        /// <summary>
        /// Reference a score config on a score. The unique langfuse identifier of a score config. When passing this field, the dataType and stringValue fields are automatically populated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configId")]
        public string? ConfigId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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