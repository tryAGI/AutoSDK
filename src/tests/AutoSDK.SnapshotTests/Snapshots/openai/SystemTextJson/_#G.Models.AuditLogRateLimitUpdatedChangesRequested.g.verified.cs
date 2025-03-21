//HintName: G.Models.AuditLogRateLimitUpdatedChangesRequested.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The payload used to update the rate limits.
    /// </summary>
    public sealed partial class AuditLogRateLimitUpdatedChangesRequested
    {
        /// <summary>
        /// The maximum batch input tokens per day. Only relevant for certain models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_1_day_max_input_tokens")]
        public int? Batch1DayMaxInputTokens { get; set; }

        /// <summary>
        /// The maximum audio megabytes per minute. Only relevant for certain models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_audio_megabytes_per_1_minute")]
        public int? MaxAudioMegabytesPer1Minute { get; set; }

        /// <summary>
        /// The maximum images per minute. Only relevant for certain models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_images_per_1_minute")]
        public int? MaxImagesPer1Minute { get; set; }

        /// <summary>
        /// The maximum requests per day. Only relevant for certain models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_requests_per_1_day")]
        public int? MaxRequestsPer1Day { get; set; }

        /// <summary>
        /// The maximum requests per minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_requests_per_1_minute")]
        public int? MaxRequestsPer1Minute { get; set; }

        /// <summary>
        /// The maximum tokens per minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens_per_1_minute")]
        public int? MaxTokensPer1Minute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRateLimitUpdatedChangesRequested" /> class.
        /// </summary>
        /// <param name="batch1DayMaxInputTokens">
        /// The maximum batch input tokens per day. Only relevant for certain models.
        /// </param>
        /// <param name="maxAudioMegabytesPer1Minute">
        /// The maximum audio megabytes per minute. Only relevant for certain models.
        /// </param>
        /// <param name="maxImagesPer1Minute">
        /// The maximum images per minute. Only relevant for certain models.
        /// </param>
        /// <param name="maxRequestsPer1Day">
        /// The maximum requests per day. Only relevant for certain models.
        /// </param>
        /// <param name="maxRequestsPer1Minute">
        /// The maximum requests per minute.
        /// </param>
        /// <param name="maxTokensPer1Minute">
        /// The maximum tokens per minute.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogRateLimitUpdatedChangesRequested(
            int? batch1DayMaxInputTokens,
            int? maxAudioMegabytesPer1Minute,
            int? maxImagesPer1Minute,
            int? maxRequestsPer1Day,
            int? maxRequestsPer1Minute,
            int? maxTokensPer1Minute)
        {
            this.Batch1DayMaxInputTokens = batch1DayMaxInputTokens;
            this.MaxAudioMegabytesPer1Minute = maxAudioMegabytesPer1Minute;
            this.MaxImagesPer1Minute = maxImagesPer1Minute;
            this.MaxRequestsPer1Day = maxRequestsPer1Day;
            this.MaxRequestsPer1Minute = maxRequestsPer1Minute;
            this.MaxTokensPer1Minute = maxTokensPer1Minute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRateLimitUpdatedChangesRequested" /> class.
        /// </summary>
        public AuditLogRateLimitUpdatedChangesRequested()
        {
        }
    }
}