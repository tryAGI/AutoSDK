//HintName: G.Models.ScoreBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreBody
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
        /// The name of the score. Always overrides "output" for correction scores.<br/>
        /// Example: novelty
        /// </summary>
        /// <example>novelty</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// The annotation queue referenced by the score. Indicates if score was initially created while processing annotation queue.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queueId")]
        public string? QueueId { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataType")]
        public global::G.ScoreDataType? DataType { get; set; }

        /// <summary>
        /// Reference a score config on a score. When set, the score name must equal the config name and scores must comply with the config's range and data type. For categorical scores, the value must map to a config category. Numeric scores might be constrained by the score config's max and min values
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configId")]
        public string? ConfigId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreBody" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the score. Always overrides "output" for correction scores.<br/>
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
        /// <param name="environment"></param>
        /// <param name="queueId">
        /// The annotation queue referenced by the score. Indicates if score was initially created while processing annotation queue.
        /// </param>
        /// <param name="comment"></param>
        /// <param name="metadata"></param>
        /// <param name="dataType"></param>
        /// <param name="configId">
        /// Reference a score config on a score. When set, the score name must equal the config name and scores must comply with the config's range and data type. For categorical scores, the value must map to a config category. Numeric scores might be constrained by the score config's max and min values
        /// </param>
        public ScoreBody(
            string name,
            global::G.CreateScoreValue value,
            string? id,
            string? traceId,
            string? sessionId,
            string? observationId,
            string? datasetRunId,
            string? environment,
            string? queueId,
            string? comment,
            object? metadata,
            global::G.ScoreDataType? dataType,
            string? configId)
        {
            this.Id = id;
            this.TraceId = traceId;
            this.SessionId = sessionId;
            this.ObservationId = observationId;
            this.DatasetRunId = datasetRunId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Environment = environment;
            this.QueueId = queueId;
            this.Value = value;
            this.Comment = comment;
            this.Metadata = metadata;
            this.DataType = dataType;
            this.ConfigId = configId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreBody" /> class.
        /// </summary>
        public ScoreBody()
        {
        }
    }
}