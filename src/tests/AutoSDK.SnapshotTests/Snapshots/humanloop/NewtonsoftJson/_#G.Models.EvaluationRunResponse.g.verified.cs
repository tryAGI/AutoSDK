//HintName: G.Models.EvaluationRunResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationRunResponse
    {
        /// <summary>
        /// Unique identifier for the Run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluationId", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvaluationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EvaluationRunResponseStatusJsonConverter))]
        public global::G.EvaluationRunResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the Run.
        /// </param>
        /// <param name="evaluationId"></param>
        /// <param name="versionId"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public EvaluationRunResponse(
            string id,
            string evaluationId,
            string? versionId,
            global::G.EvaluationRunResponseStatus? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EvaluationId = evaluationId ?? throw new global::System.ArgumentNullException(nameof(evaluationId));
            this.VersionId = versionId;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunResponse" /> class.
        /// </summary>
        public EvaluationRunResponse()
        {
        }
    }
}