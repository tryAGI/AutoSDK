//HintName: G.Models.ObservationV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An observation from the v2 API with field-group-based selection.<br/>
    /// Core fields are always present. Other fields are included only when their field group is requested.
    /// </summary>
    public sealed partial class ObservationV2
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
        /// The start time of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// The end time of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// The project ID this observation belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The parent observation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentObservationId")]
        public string? ParentObservationId { get; set; }

        /// <summary>
        /// The type of the observation (e.g. GENERATION, SPAN, EVENT)
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ObservationLevelJsonConverter))]
        public global::G.ObservationLevel? Level { get; set; }

        /// <summary>
        /// The status message of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// The version of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The environment from which this observation originated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Whether the observation is bookmarked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bookmarked")]
        public bool? Bookmarked { get; set; }

        /// <summary>
        /// Whether the observation is public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// The user ID associated with the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// The session ID associated with the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The completion start time of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionStartTime")]
        public global::System.DateTime? CompletionStartTime { get; set; }

        /// <summary>
        /// The creation timestamp of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The last update timestamp of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The input data of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// The output data of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// Additional metadata of the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The model name as provided by the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providedModelName")]
        public string? ProvidedModelName { get; set; }

        /// <summary>
        /// The internal model ID matched by Langfuse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalModelId")]
        public string? InternalModelId { get; set; }

        /// <summary>
        /// The parameters of the model used for the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelParameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// The usage details of the observation. Key is the usage metric name, value is the number of units consumed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageDetails")]
        public global::System.Collections.Generic.Dictionary<string, int>? UsageDetails { get; set; }

        /// <summary>
        /// The cost details of the observation. Key is the cost metric name, value is the cost in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDetails")]
        public global::System.Collections.Generic.Dictionary<string, double>? CostDetails { get; set; }

        /// <summary>
        /// The total cost of the observation in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// The prompt ID associated with the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptId")]
        public string? PromptId { get; set; }

        /// <summary>
        /// The prompt name associated with the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptName")]
        public string? PromptName { get; set; }

        /// <summary>
        /// The prompt version associated with the observation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersion")]
        public int? PromptVersion { get; set; }

        /// <summary>
        /// The latency in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// The time to first token in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeToFirstToken")]
        public double? TimeToFirstToken { get; set; }

        /// <summary>
        /// The matched model ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationV2" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the observation
        /// </param>
        /// <param name="startTime">
        /// The start time of the observation
        /// </param>
        /// <param name="projectId">
        /// The project ID this observation belongs to
        /// </param>
        /// <param name="type">
        /// The type of the observation (e.g. GENERATION, SPAN, EVENT)
        /// </param>
        /// <param name="traceId">
        /// The trace ID associated with the observation
        /// </param>
        /// <param name="endTime">
        /// The end time of the observation
        /// </param>
        /// <param name="parentObservationId">
        /// The parent observation ID
        /// </param>
        /// <param name="name">
        /// The name of the observation
        /// </param>
        /// <param name="level"></param>
        /// <param name="statusMessage">
        /// The status message of the observation
        /// </param>
        /// <param name="version">
        /// The version of the observation
        /// </param>
        /// <param name="environment">
        /// The environment from which this observation originated
        /// </param>
        /// <param name="bookmarked">
        /// Whether the observation is bookmarked
        /// </param>
        /// <param name="public">
        /// Whether the observation is public
        /// </param>
        /// <param name="userId">
        /// The user ID associated with the observation
        /// </param>
        /// <param name="sessionId">
        /// The session ID associated with the observation
        /// </param>
        /// <param name="completionStartTime">
        /// The completion start time of the observation
        /// </param>
        /// <param name="createdAt">
        /// The creation timestamp of the observation
        /// </param>
        /// <param name="updatedAt">
        /// The last update timestamp of the observation
        /// </param>
        /// <param name="input">
        /// The input data of the observation
        /// </param>
        /// <param name="output">
        /// The output data of the observation
        /// </param>
        /// <param name="metadata">
        /// Additional metadata of the observation
        /// </param>
        /// <param name="providedModelName">
        /// The model name as provided by the user
        /// </param>
        /// <param name="internalModelId">
        /// The internal model ID matched by Langfuse
        /// </param>
        /// <param name="modelParameters">
        /// The parameters of the model used for the observation
        /// </param>
        /// <param name="usageDetails">
        /// The usage details of the observation. Key is the usage metric name, value is the number of units consumed.
        /// </param>
        /// <param name="costDetails">
        /// The cost details of the observation. Key is the cost metric name, value is the cost in USD.
        /// </param>
        /// <param name="totalCost">
        /// The total cost of the observation in USD
        /// </param>
        /// <param name="promptId">
        /// The prompt ID associated with the observation
        /// </param>
        /// <param name="promptName">
        /// The prompt name associated with the observation
        /// </param>
        /// <param name="promptVersion">
        /// The prompt version associated with the observation
        /// </param>
        /// <param name="latency">
        /// The latency in seconds
        /// </param>
        /// <param name="timeToFirstToken">
        /// The time to first token in seconds
        /// </param>
        /// <param name="modelId">
        /// The matched model ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservationV2(
            string id,
            global::System.DateTime startTime,
            string projectId,
            string type,
            string? traceId,
            global::System.DateTime? endTime,
            string? parentObservationId,
            string? name,
            global::G.ObservationLevel? level,
            string? statusMessage,
            string? version,
            string? environment,
            bool? bookmarked,
            bool? @public,
            string? userId,
            string? sessionId,
            global::System.DateTime? completionStartTime,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            object? input,
            object? output,
            object? metadata,
            string? providedModelName,
            string? internalModelId,
            object? modelParameters,
            global::System.Collections.Generic.Dictionary<string, int>? usageDetails,
            global::System.Collections.Generic.Dictionary<string, double>? costDetails,
            double? totalCost,
            string? promptId,
            string? promptName,
            int? promptVersion,
            double? latency,
            double? timeToFirstToken,
            string? modelId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TraceId = traceId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ParentObservationId = parentObservationId;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name;
            this.Level = level;
            this.StatusMessage = statusMessage;
            this.Version = version;
            this.Environment = environment;
            this.Bookmarked = bookmarked;
            this.Public = @public;
            this.UserId = userId;
            this.SessionId = sessionId;
            this.CompletionStartTime = completionStartTime;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Input = input;
            this.Output = output;
            this.Metadata = metadata;
            this.ProvidedModelName = providedModelName;
            this.InternalModelId = internalModelId;
            this.ModelParameters = modelParameters;
            this.UsageDetails = usageDetails;
            this.CostDetails = costDetails;
            this.TotalCost = totalCost;
            this.PromptId = promptId;
            this.PromptName = promptName;
            this.PromptVersion = promptVersion;
            this.Latency = latency;
            this.TimeToFirstToken = timeToFirstToken;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationV2" /> class.
        /// </summary>
        public ObservationV2()
        {
        }
    }
}