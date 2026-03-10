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
        [global::Newtonsoft.Json.JsonProperty("warning_start_days", Required = global::Newtonsoft.Json.Required.Always)]
        public int WarningStartDays { get; set; } = default!;

        /// <summary>
        /// Number of days before the provider deprecation date when traffic starts being routed to the replacement model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallback_start_days", Required = global::Newtonsoft.Json.Required.Always)]
        public int FallbackStartDays { get; set; } = default!;

        /// <summary>
        /// Number of days before the provider deprecation date when all traffic is routed to the replacement model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallback_complete_days", Required = global::Newtonsoft.Json.Required.Always)]
        public int FallbackCompleteDays { get; set; } = default!;

        /// <summary>
        /// Percentage of traffic routed to the replacement model when fallback begins.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallback_start_percentage", Required = global::Newtonsoft.Json.Required.Always)]
        public int FallbackStartPercentage { get; set; } = default!;

        /// <summary>
        /// Percentage of traffic routed to the replacement model when fallback is complete.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallback_complete_percentage", Required = global::Newtonsoft.Json.Required.Always)]
        public int FallbackCompletePercentage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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