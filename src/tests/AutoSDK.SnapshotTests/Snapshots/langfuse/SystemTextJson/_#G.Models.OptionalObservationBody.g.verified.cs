//HintName: G.Models.OptionalObservationBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptionalObservationBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        public string? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ObservationLevelJsonConverter))]
        public global::G.ObservationLevel? Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentObservationId")]
        public string? ParentObservationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionalObservationBody" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="name"></param>
        /// <param name="startTime"></param>
        /// <param name="metadata"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="level"></param>
        /// <param name="statusMessage"></param>
        /// <param name="parentObservationId"></param>
        /// <param name="version"></param>
        /// <param name="environment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptionalObservationBody(
            string? traceId,
            string? name,
            global::System.DateTime? startTime,
            object? metadata,
            object? input,
            object? output,
            global::G.ObservationLevel? level,
            string? statusMessage,
            string? parentObservationId,
            string? version,
            string? environment)
        {
            this.TraceId = traceId;
            this.Name = name;
            this.StartTime = startTime;
            this.Metadata = metadata;
            this.Input = input;
            this.Output = output;
            this.Level = level;
            this.StatusMessage = statusMessage;
            this.ParentObservationId = parentObservationId;
            this.Version = version;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionalObservationBody" /> class.
        /// </summary>
        public OptionalObservationBody()
        {
        }
    }
}