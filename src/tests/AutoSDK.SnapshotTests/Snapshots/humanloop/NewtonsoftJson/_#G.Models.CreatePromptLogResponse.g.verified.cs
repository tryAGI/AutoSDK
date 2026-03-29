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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptId")]
        public string? PromptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceParentId")]
        public string? TraceParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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