//HintName: G.Models.FeedsUpdateAllSubscriptionsCronRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsUpdateAllSubscriptionsCronRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CronSchedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsUpdateAllSubscriptionsCronRequest" /> class.
        /// </summary>
        /// <param name="cronSchedule"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedsUpdateAllSubscriptionsCronRequest(
            string cronSchedule)
        {
            this.CronSchedule = cronSchedule ?? throw new global::System.ArgumentNullException(nameof(cronSchedule));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsUpdateAllSubscriptionsCronRequest" /> class.
        /// </summary>
        public FeedsUpdateAllSubscriptionsCronRequest()
        {
        }
    }
}