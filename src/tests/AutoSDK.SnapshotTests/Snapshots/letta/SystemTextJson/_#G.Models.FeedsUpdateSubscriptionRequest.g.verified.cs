//HintName: G.Models.FeedsUpdateSubscriptionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsUpdateSubscriptionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_schedule")]
        public string? CronSchedule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsUpdateSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="cronSchedule"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="disabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedsUpdateSubscriptionRequest(
            string? cronSchedule,
            string? promptTemplate,
            bool? disabled)
        {
            this.CronSchedule = cronSchedule;
            this.PromptTemplate = promptTemplate;
            this.Disabled = disabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsUpdateSubscriptionRequest" /> class.
        /// </summary>
        public FeedsUpdateSubscriptionRequest()
        {
        }
    }
}