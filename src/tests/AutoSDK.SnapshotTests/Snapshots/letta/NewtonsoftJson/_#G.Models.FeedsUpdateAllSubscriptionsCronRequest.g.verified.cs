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
        [global::Newtonsoft.Json.JsonProperty("cron_schedule", Required = global::Newtonsoft.Json.Required.Always)]
        public string CronSchedule { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsUpdateAllSubscriptionsCronRequest" /> class.
        /// </summary>
        /// <param name="cronSchedule"></param>
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