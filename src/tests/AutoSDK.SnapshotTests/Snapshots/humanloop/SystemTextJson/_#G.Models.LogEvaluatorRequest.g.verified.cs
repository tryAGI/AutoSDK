//HintName: G.Models.LogEvaluatorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogEvaluatorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the Log being evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save")]
        public bool? Save { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logId")]
        public string? LogId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="parentId">
        /// The ID of the Log being evaluated.
        /// </param>
        /// <param name="source"></param>
        /// <param name="metadata"></param>
        /// <param name="save"></param>
        /// <param name="logId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogEvaluatorRequest(
            string? versionId,
            string? environment,
            string? path,
            string? id,
            string? parentId,
            string? source,
            object? metadata,
            bool? save,
            string? logId)
        {
            this.VersionId = versionId;
            this.Environment = environment;
            this.Path = path;
            this.Id = id;
            this.ParentId = parentId;
            this.Source = source;
            this.Metadata = metadata;
            this.Save = save;
            this.LogId = logId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogEvaluatorRequest" /> class.
        /// </summary>
        public LogEvaluatorRequest()
        {
        }
    }
}