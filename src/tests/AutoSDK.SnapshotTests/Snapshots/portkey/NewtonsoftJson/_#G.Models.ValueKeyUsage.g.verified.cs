//HintName: G.Models.ValueKeyUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValueKeyUsage
    {
        /// <summary>
        /// Current usage value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_usage")]
        public double? CurrentUsage { get; set; }

        /// <summary>
        /// Usage status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ValueKeyUsageStatus? Status { get; set; }

        /// <summary>
        /// Whether threshold alerts have been sent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_threshold_alerts_sent")]
        public bool? IsThresholdAlertsSent { get; set; }

        /// <summary>
        /// Whether exhausted alerts have been sent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_exhausted_alerts_sent")]
        public bool? IsExhaustedAlertsSent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueKeyUsage" /> class.
        /// </summary>
        /// <param name="currentUsage">
        /// Current usage value
        /// </param>
        /// <param name="status">
        /// Usage status
        /// </param>
        /// <param name="isThresholdAlertsSent">
        /// Whether threshold alerts have been sent
        /// </param>
        /// <param name="isExhaustedAlertsSent">
        /// Whether exhausted alerts have been sent
        /// </param>
        public ValueKeyUsage(
            double? currentUsage,
            global::G.ValueKeyUsageStatus? status,
            bool? isThresholdAlertsSent,
            bool? isExhaustedAlertsSent)
        {
            this.CurrentUsage = currentUsage;
            this.Status = status;
            this.IsThresholdAlertsSent = isThresholdAlertsSent;
            this.IsExhaustedAlertsSent = isExhaustedAlertsSent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueKeyUsage" /> class.
        /// </summary>
        public ValueKeyUsage()
        {
        }
    }
}