//HintName: G.Models.GetSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSubscriptionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetSubscriptionResponseItem> Items { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trial_end")]
        public double? TrialEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_period_start", Required = global::Newtonsoft.Json.Required.Always)]
        public double CurrentPeriodStart { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_period_end", Required = global::Newtonsoft.Json.Required.Always)]
        public double CurrentPeriodEnd { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancel_at_period_end", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CancelAtPeriodEnd { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="id"></param>
        /// <param name="currentPeriodStart"></param>
        /// <param name="currentPeriodEnd"></param>
        /// <param name="cancelAtPeriodEnd"></param>
        /// <param name="status"></param>
        /// <param name="trialEnd"></param>
        public GetSubscriptionResponse(
            global::System.Collections.Generic.IList<global::G.GetSubscriptionResponseItem> items,
            string id,
            double currentPeriodStart,
            double currentPeriodEnd,
            bool cancelAtPeriodEnd,
            string status,
            double? trialEnd)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.TrialEnd = trialEnd;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CurrentPeriodStart = currentPeriodStart;
            this.CurrentPeriodEnd = currentPeriodEnd;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponse" /> class.
        /// </summary>
        public GetSubscriptionResponse()
        {
        }
    }
}