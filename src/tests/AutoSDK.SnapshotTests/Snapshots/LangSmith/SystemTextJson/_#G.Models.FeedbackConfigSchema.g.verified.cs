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
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeedbackKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FeedbackConfig FeedbackConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_lower_score_better")]
        public bool? IsLowerScoreBetter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackConfigSchema" /> class.
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="tenantId"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="isLowerScoreBetter"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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