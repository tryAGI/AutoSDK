//HintName: G.Models.CreatePromptLogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptLogResponse
    {
        /// <summary>
        /// Unique identifier for the created log.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptId")]
        public string? PromptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceParentId")]
        public string? TraceParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptLogResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the created log.
        /// </param>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="traceParentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePromptLogResponse(
            string id,
            string? promptId,
            string? versionId,
            string? traceParentId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PromptId = promptId;
            this.VersionId = versionId;
            this.TraceParentId = traceParentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptLogResponse" /> class.
        /// </summary>
        public CreatePromptLogResponse()
        {
        }
    }
}