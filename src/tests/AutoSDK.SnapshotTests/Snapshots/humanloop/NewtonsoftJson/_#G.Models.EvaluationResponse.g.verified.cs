//HintName: G.Models.EvaluationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for an Evaluation.
    /// </summary>
    public sealed partial class EvaluationResponse
    {
        /// <summary>
        /// Unique identifier for the Evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Total number of Runs in the Evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runsCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int RunsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluators", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvaluationEvaluatorResponse> Evaluators { get; set; } = default!;

        /// <summary>
        /// Name of the Evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// ID of the File associated with the Evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileId")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdBy")]
        public global::G.UserResponse? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// URL to view the Evaluation on Humanloop.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.EvaluationResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the Evaluation.
        /// </param>
        /// <param name="runsCount">
        /// Total number of Runs in the Evaluation.
        /// </param>
        /// <param name="evaluators"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="name">
        /// Name of the Evaluation.
        /// </param>
        /// <param name="fileId">
        /// ID of the File associated with the Evaluation.
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="url">
        /// URL to view the Evaluation on Humanloop.
        /// </param>
        /// <param name="status"></param>
        public EvaluationResponse(
            string id,
            int runsCount,
            global::System.Collections.Generic.IList<global::G.EvaluationEvaluatorResponse> evaluators,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? name,
            string? fileId,
            global::G.UserResponse? createdBy,
            string? url,
            global::G.EvaluationResponseStatus? status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RunsCount = runsCount;
            this.Evaluators = evaluators ?? throw new global::System.ArgumentNullException(nameof(evaluators));
            this.Name = name;
            this.FileId = fileId;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.UpdatedAt = updatedAt;
            this.Url = url;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationResponse" /> class.
        /// </summary>
        public EvaluationResponse()
        {
        }
    }
}