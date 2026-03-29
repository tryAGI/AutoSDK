//HintName: G.Models.ToolResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for a Tool.
    /// </summary>
    public sealed partial class ToolResponse
    {
        /// <summary>
        /// Path of the Tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Unique identifier for the Tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryId")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::G.ToolFunction? Function { get; set; }

        /// <summary>
        /// Code source of the Tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceCode")]
        public string? SourceCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setupValues")]
        public object? SetupValues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Type of Tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolType")]
        public string? ToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Name of the Tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Unique identifier for the specific Tool Version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolResponseTypeJsonConverter))]
        public global::G.ToolResponseType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? Environments { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public global::G.UserResponse? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionLogsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionLogsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalLogsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalLogsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.InputResponse> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        public global::System.Collections.Generic.IList<global::G.MonitoringEvaluatorResponse>? Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorAggregates")]
        public global::System.Collections.Generic.IList<global::G.EvaluatorAggregate>? EvaluatorAggregates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResponse" /> class.
        /// </summary>
        /// <param name="path">
        /// Path of the Tool.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the Tool.
        /// </param>
        /// <param name="name">
        /// Name of the Tool.
        /// </param>
        /// <param name="versionId">
        /// Unique identifier for the specific Tool Version.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="versionLogsCount"></param>
        /// <param name="totalLogsCount"></param>
        /// <param name="inputs"></param>
        /// <param name="directoryId"></param>
        /// <param name="function"></param>
        /// <param name="sourceCode">
        /// Code source of the Tool.
        /// </param>
        /// <param name="setupValues"></param>
        /// <param name="attributes"></param>
        /// <param name="toolType">
        /// Type of Tool.
        /// </param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="tags"></param>
        /// <param name="type"></param>
        /// <param name="environments"></param>
        /// <param name="createdBy"></param>
        /// <param name="evaluators"></param>
        /// <param name="evaluatorAggregates"></param>
        /// <param name="signature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolResponse(
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
            global::G.ToolFunction? function,
            string? sourceCode,
            object? setupValues,
            object? attributes,
            string? toolType,
            string? versionName,
            string? versionDescription,
            string? description,
            string? readme,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.ToolResponseType? type,
            global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? environments,
            global::G.UserResponse? createdBy,
            global::System.Collections.Generic.IList<global::G.MonitoringEvaluatorResponse>? evaluators,
            global::System.Collections.Generic.IList<global::G.EvaluatorAggregate>? evaluatorAggregates,
            string? signature)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DirectoryId = directoryId;
            this.Function = function;
            this.SourceCode = sourceCode;
            this.SetupValues = setupValues;
            this.Attributes = attributes;
            this.ToolType = toolType;
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
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
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResponse" /> class.
        /// </summary>
        public ToolResponse()
        {
        }
    }
}