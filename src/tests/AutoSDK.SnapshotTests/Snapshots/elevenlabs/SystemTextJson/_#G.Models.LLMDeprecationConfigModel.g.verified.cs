//HintName: G.Models.LLMDeprecationConfigModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"fallback_complete_days":7,"fallback_complete_percentage":100,"fallback_start_days":14,"fallback_start_percentage":25,"warning_start_days":30}
    /// </summary>
    public sealed partial class LLMDeprecationConfigModel
    {
        /// <summary>
        /// Number of days before the provider deprecation date when warnings start being shown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning_start_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WarningStartDays { get; set; }

        /// <summary>
        /// Number of days before the provider deprecation date when traffic starts being routed to the replacement model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_start_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FallbackStartDays { get; set; }

        /// <summary>
        /// Number of days before the provider deprecation date when all traffic is routed to the replacement model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_complete_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FallbackCompleteDays { get; set; }

        /// <summary>
        /// Percentage of traffic routed to the replacement model when fallback begins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_start_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FallbackStartPercentage { get; set; }

        /// <summary>
        /// Percentage of traffic routed to the replacement model when fallback is complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_complete_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FallbackCompletePercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMDeprecationConfigModel" /> class.
        /// </summary>
        /// <param name="warningStartDays">
        /// Number of days before the provider deprecation date when warnings start being shown.
        /// </param>
        /// <param name="fallbackStartDays">
        /// Number of days before the provider deprecation date when traffic starts being routed to the replacement model.
        /// </param>
        /// <param name="fallbackCompleteDays">
        /// Number of days before the provider deprecation date when all traffic is routed to the replacement model.
        /// </param>
        /// <param name="fallbackStartPercentage">
        /// Percentage of traffic routed to the replacement model when fallback begins.
        /// </param>
        /// <param name="fallbackCompletePercentage">
        /// Percentage of traffic routed to the replacement model when fallback is complete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMDeprecationConfigModel(
            int warningStartDays,
            int fallbackStartDays,
            int fallbackCompleteDays,
            int fallbackStartPercentage,
            int fallbackCompletePercentage)
        {
            this.WarningStartDays = warningStartDays;
            this.FallbackStartDays = fallbackStartDays;
            this.FallbackCompleteDays = fallbackCompleteDays;
            this.FallbackStartPercentage = fallbackStartPercentage;
            this.FallbackCompletePercentage = fallbackCompletePercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMDeprecationConfigModel" /> class.
        /// </summary>
        public LLMDeprecationConfigModel()
        {
        }
    }
}