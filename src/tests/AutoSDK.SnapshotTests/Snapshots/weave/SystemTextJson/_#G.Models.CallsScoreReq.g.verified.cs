//HintName: G.Models.CallsScoreReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to enqueue scoring jobs for a list of calls.<br/>
    /// Scoring is performed asynchronously by the call_scoring_worker, which<br/>
    /// consumes messages from Kafka and applies each scorer_ref to each call_id.
    /// </summary>
    public sealed partial class CallsScoreReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// List of call IDs to score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CallIds { get; set; }

        /// <summary>
        /// List of scorer refs to apply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_refs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ScorerRefs { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsScoreReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="callIds">
        /// List of call IDs to score
        /// </param>
        /// <param name="scorerRefs">
        /// List of scorer refs to apply
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallsScoreReq(
            string projectId,
            global::System.Collections.Generic.IList<string> callIds,
            global::System.Collections.Generic.IList<string> scorerRefs,
            string? wbUserId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.CallIds = callIds ?? throw new global::System.ArgumentNullException(nameof(callIds));
            this.ScorerRefs = scorerRefs ?? throw new global::System.ArgumentNullException(nameof(scorerRefs));
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsScoreReq" /> class.
        /// </summary>
        public CallsScoreReq()
        {
        }
    }
}