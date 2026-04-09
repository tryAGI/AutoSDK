//HintName: G.Models.ObservationBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObservationBody
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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ObservationTypeJsonConverter))]
        public global::G.ObservationType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startTime")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completionStartTime")]
        public global::System.DateTime? CompletionStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelParameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public object? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public object? Output { get; set; }

        /// <summary>
        /// (Deprecated. Use usageDetails and costDetails instead.) Standard interface for usage and cost
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.Usage? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("level")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ObservationLevelJsonConverter))]
        public global::G.ObservationLevel? Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parentObservationId")]
        public string? ParentObservationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationBody" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="traceId"></param>
        /// <param name="name"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="completionStartTime"></param>
        /// <param name="model"></param>
        /// <param name="modelParameters"></param>
        /// <param name="input"></param>
        /// <param name="version"></param>
        /// <param name="metadata"></param>
        /// <param name="output"></param>
        /// <param name="usage">
        /// (Deprecated. Use usageDetails and costDetails instead.) Standard interface for usage and cost
        /// </param>
        /// <param name="level"></param>
        /// <param name="statusMessage"></param>
        /// <param name="parentObservationId"></param>
        /// <param name="environment"></param>
        public ObservationBody(
            global::G.ObservationType type,
            string? id,
            string? traceId,
            string? name,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            global::System.DateTime? completionStartTime,
            string? model,
            object? modelParameters,
            object? input,
            string? version,
            object? metadata,
            object? output,
            global::G.Usage? usage,
            global::G.ObservationLevel? level,
            string? statusMessage,
            string? parentObservationId,
            string? environment)
        {
            this.Id = id;
            this.TraceId = traceId;
            this.Type = type;
            this.Name = name;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.CompletionStartTime = completionStartTime;
            this.Model = model;
            this.ModelParameters = modelParameters;
            this.Input = input;
            this.Version = version;
            this.Metadata = metadata;
            this.Output = output;
            this.Usage = usage;
            this.Level = level;
            this.StatusMessage = statusMessage;
            this.ParentObservationId = parentObservationId;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationBody" /> class.
        /// </summary>
        public ObservationBody()
        {
        }
    }
}