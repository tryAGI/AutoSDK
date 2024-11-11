//HintName: G.Models.FeedbackConfigSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackConfigSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string FeedbackKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FeedbackConfig FeedbackConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ModifiedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_lower_score_better")]
        public bool? IsLowerScoreBetter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackConfigSchema" /> class.
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="tenantId"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="isLowerScoreBetter"></param>
        public FeedbackConfigSchema(
            string feedbackKey,
            global::G.FeedbackConfig feedbackConfig,
            global::System.Guid tenantId,
            global::System.DateTime modifiedAt,
            bool? isLowerScoreBetter)
        {
            this.FeedbackKey = feedbackKey ?? throw new global::System.ArgumentNullException(nameof(feedbackKey));
            this.FeedbackConfig = feedbackConfig ?? throw new global::System.ArgumentNullException(nameof(feedbackConfig));
            this.TenantId = tenantId;
            this.ModifiedAt = modifiedAt;
            this.IsLowerScoreBetter = isLowerScoreBetter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackConfigSchema" /> class.
        /// </summary>
        public FeedbackConfigSchema()
        {
        }
    }
}