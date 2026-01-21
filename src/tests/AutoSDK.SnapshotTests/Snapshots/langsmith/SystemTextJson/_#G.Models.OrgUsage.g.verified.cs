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
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_metric_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillableMetricId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_metric_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillableMetricName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double>? Groups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
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