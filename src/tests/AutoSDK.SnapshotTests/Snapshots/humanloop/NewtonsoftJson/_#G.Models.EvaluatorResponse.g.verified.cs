//HintName: G.Models.EvaluatorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for an Evaluator.
    /// </summary>
    public sealed partial class EvaluatorResponse
    {
        /// <summary>
        /// Path of the Evaluator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the Evaluator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("directoryId")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// The evaluator specification.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spec")]
        public object? Spec { get; set; }

        /// <summary>
        /// Name of the Evaluator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Unique identifier for the specific Evaluator Version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EvaluatorResponseType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environments")]
        public global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? Environments { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdBy")]
        public global::G.UserResponse? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUsedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastUsedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionLogsCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionLogsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalLogsCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalLogsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.InputResponse> Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluators")]
        public global::System.Collections.Generic.IList<global::G.MonitoringEvaluatorResponse>? Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluatorAggregates")]
        public global::System.Collections.Generic.IList<global::G.EvaluatorAggregate>? EvaluatorAggregates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorResponse" /> class.
        /// </summary>
        /// <param name="path">
        /// Path of the Evaluator.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the Evaluator.
        /// </param>
        /// <param name="name">
        /// Name of the Evaluator.
        /// </param>
        /// <param name="versionId">
        /// Unique identifier for the specific Evaluator Version.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="versionLogsCount"></param>
        /// <param name="totalLogsCount"></param>
        /// <param name="inputs"></param>
        /// <param name="directoryId"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="spec">
        /// The evaluator specification.
        /// </param>
        /// <param name="description"></param>
        /// <param name="schema"></param>
        /// <param name="readme"></param>
        /// <param name="tags"></param>
        /// <param name="type"></param>
        /// <param name="environments"></param>
        /// <param name="createdBy"></param>
        /// <param name="evaluators"></param>
        /// <param name="evaluatorAggregates"></param>
        /// <param name="attributes"></param>
        public EvaluatorResponse(
            string path,
            string id,
            string name,
            string versionId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime lastUsedAt,
            int versionLogsCount,
            int totalLogsCount,
            global::System.Collections.Generic.IList<global::G.InputResponse> inputs,
            string? directoryId,
            string? versionName,
            string? versionDescription,
            object? spec,
            string? description,
            object? schema,
            string? readme,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.EvaluatorResponseType? type,
            global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? environments,
            global::G.UserResponse? createdBy,
            global::System.Collections.Generic.IList<global::G.MonitoringEvaluatorResponse>? evaluators,
            global::System.Collections.Generic.IList<global::G.EvaluatorAggregate>? evaluatorAggregates,
            object? attributes)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DirectoryId = directoryId;
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
            this.Spec = spec;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Schema = schema;
            this.Readme = readme;
            this.Tags = tags;
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.Type = type;
            this.Environments = environments;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreatedBy = createdBy;
            this.LastUsedAt = lastUsedAt;
            this.VersionLogsCount = versionLogsCount;
            this.TotalLogsCount = totalLogsCount;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Evaluators = evaluators;
            this.EvaluatorAggregates = evaluatorAggregates;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorResponse" /> class.
        /// </summary>
        public EvaluatorResponse()
        {
        }
    }
}