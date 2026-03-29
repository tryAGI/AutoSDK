//HintName: G.Models.Observation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Observation
    {
        /// <summary>
        /// The unique identifier of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The trace ID associated with the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        public string? TraceId { get; set; }

        /// <summary>
        /// The type of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The name of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The start time of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// The end time of the observation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// The completion start time of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionStartTime")]
        public global::System.DateTime? CompletionStartTime { get; set; }

        /// <summary>
        /// The model used for the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The parameters of the model used for the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelParameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ModelParameters { get; set; }

        /// <summary>
        /// The input data of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// The version of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional metadata of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// The output data of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Output { get; set; }

        /// <summary>
        /// (Deprecated. Use usageDetails and costDetails instead.) Standard interface for usage and cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Usage Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ObservationLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ObservationLevel Level { get; set; }

        /// <summary>
        /// The status message of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// The parent observation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentObservationId")]
        public string? ParentObservationId { get; set; }

        /// <summary>
        /// The prompt ID associated with the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptId")]
        public string? PromptId { get; set; }

        /// <summary>
        /// The usage details of the observation. Key is the name of the usage metric, value is the number of units consumed. The total key is the sum of all (non-total) usage metrics or the total value ingested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageDetails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> UsageDetails { get; set; }

        /// <summary>
        /// The cost details of the observation. Key is the name of the cost metric, value is the cost in USD. The total key is the sum of all (non-total) cost metrics or the total value ingested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDetails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> CostDetails { get; set; }

        /// <summary>
        /// The environment from which this observation originated. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
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
        /// Initializes a new instance of the <see cref="Observation" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the observation
        /// </param>
        /// <param name="type">
        /// The type of the observation
        /// </param>
        /// <param name="startTime">
        /// The start time of the observation
        /// </param>
        /// <param name="modelParameters">
        /// The parameters of the model used for the observation
        /// </param>
        /// <param name="input">
        /// The input data of the observation
        /// </param>
        /// <param name="metadata">
        /// Additional metadata of the observation
        /// </param>
        /// <param name="output">
        /// The output data of the observation
        /// </param>
        /// <param name="usage">
        /// (Deprecated. Use usageDetails and costDetails instead.) Standard interface for usage and cost
        /// </param>
        /// <param name="level"></param>
        /// <param name="usageDetails">
        /// The usage details of the observation. Key is the name of the usage metric, value is the number of units consumed. The total key is the sum of all (non-total) usage metrics or the total value ingested.
        /// </param>
        /// <param name="costDetails">
        /// The cost details of the observation. Key is the name of the cost metric, value is the cost in USD. The total key is the sum of all (non-total) cost metrics or the total value ingested.
        /// </param>
        /// <param name="environment">
        /// The environment from which this observation originated. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
        /// </param>
        /// <param name="traceId">
        /// The trace ID associated with the observation
        /// </param>
        /// <param name="name">
        /// The name of the observation
        /// </param>
        /// <param name="endTime">
        /// The end time of the observation.
        /// </param>
        /// <param name="completionStartTime">
        /// The completion start time of the observation
        /// </param>
        /// <param name="model">
        /// The model used for the observation
        /// </param>
        /// <param name="version">
        /// The version of the observation
        /// </param>
        /// <param name="statusMessage">
        /// The status message of the observation
        /// </param>
        /// <param name="parentObservationId">
        /// The parent observation ID
        /// </param>
        /// <param name="promptId">
        /// The prompt ID associated with the observation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Observation(
            string id,
            string type,
            global::System.DateTime startTime,
            object modelParameters,
            object input,
            object metadata,
            object output,
            global::G.Usage usage,
            global::G.ObservationLevel level,
            global::System.Collections.Generic.Dictionary<string, int> usageDetails,
            global::System.Collections.Generic.Dictionary<string, double> costDetails,
            string environment,
            string? traceId,
            string? name,
            global::System.DateTime? endTime,
            global::System.DateTime? completionStartTime,
            string? model,
            string? version,
            string? statusMessage,
            string? parentObservationId,
            string? promptId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TraceId = traceId;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.CompletionStartTime = completionStartTime;
            this.Model = model;
            this.ModelParameters = modelParameters ?? throw new global::System.ArgumentNullException(nameof(modelParameters));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Version = version;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Level = level;
            this.StatusMessage = statusMessage;
            this.ParentObservationId = parentObservationId;
            this.PromptId = promptId;
            this.UsageDetails = usageDetails ?? throw new global::System.ArgumentNullException(nameof(usageDetails));
            this.CostDetails = costDetails ?? throw new global::System.ArgumentNullException(nameof(costDetails));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Observation" /> class.
        /// </summary>
        public Observation()
        {
        }
    }
}