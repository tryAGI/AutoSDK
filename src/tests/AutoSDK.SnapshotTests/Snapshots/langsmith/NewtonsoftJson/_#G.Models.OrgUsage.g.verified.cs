//HintName: G.Models.OrgUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CustomerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billable_metric_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BillableMetricId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billable_metric_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BillableMetricName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string StartTimestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string EndTimestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double? Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groups", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, double>? Groups { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgUsage" /> class.
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="billableMetricId"></param>
        /// <param name="billableMetricName"></param>
        /// <param name="startTimestamp"></param>
        /// <param name="endTimestamp"></param>
        /// <param name="value"></param>
        /// <param name="groups"></param>
        public OrgUsage(
            string customerId,
            string billableMetricId,
            string billableMetricName,
            string startTimestamp,
            string endTimestamp,
            double? value,
            global::System.Collections.Generic.Dictionary<string, double>? groups)
        {
            this.CustomerId = customerId ?? throw new global::System.ArgumentNullException(nameof(customerId));
            this.BillableMetricId = billableMetricId ?? throw new global::System.ArgumentNullException(nameof(billableMetricId));
            this.BillableMetricName = billableMetricName ?? throw new global::System.ArgumentNullException(nameof(billableMetricName));
            this.StartTimestamp = startTimestamp ?? throw new global::System.ArgumentNullException(nameof(startTimestamp));
            this.EndTimestamp = endTimestamp ?? throw new global::System.ArgumentNullException(nameof(endTimestamp));
            this.Value = value;
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgUsage" /> class.
        /// </summary>
        public OrgUsage()
        {
        }
    }
}