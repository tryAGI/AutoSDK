//HintName: G.Models.FeedbackIngestTokenCreateSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Feedback ingest token create schema.
    /// </summary>
    public sealed partial class FeedbackIngestTokenCreateSchema
    {
        /// <summary>
        /// Timedelta input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_in")]
        public global::G.TimedeltaInput? ExpiresIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RunId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string FeedbackKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_config")]
        public global::G.FeedbackConfig? FeedbackConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackIngestTokenCreateSchema" /> class.
        /// </summary>
        /// <param name="expiresIn">
        /// Timedelta input.
        /// </param>
        /// <param name="expiresAt"></param>
        /// <param name="runId"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="feedbackConfig"></param>
        public FeedbackIngestTokenCreateSchema(
            global::System.Guid runId,
            string feedbackKey,
            global::G.TimedeltaInput? expiresIn,
            global::System.DateTime? expiresAt,
            global::G.FeedbackConfig? feedbackConfig)
        {
            this.RunId = runId;
            this.FeedbackKey = feedbackKey ?? throw new global::System.ArgumentNullException(nameof(feedbackKey));
            this.ExpiresIn = expiresIn;
            this.ExpiresAt = expiresAt;
            this.FeedbackConfig = feedbackConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackIngestTokenCreateSchema" /> class.
        /// </summary>
        public FeedbackIngestTokenCreateSchema()
        {
        }
    }
}