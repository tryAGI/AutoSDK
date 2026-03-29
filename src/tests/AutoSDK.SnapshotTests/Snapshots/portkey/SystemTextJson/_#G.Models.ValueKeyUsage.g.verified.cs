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
        [global::System.Text.Json.Serialization.JsonPropertyName("current_usage")]
        public double? CurrentUsage { get; set; }

        /// <summary>
        /// Usage status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ValueKeyUsageStatusJsonConverter))]
        public global::G.ValueKeyUsageStatus? Status { get; set; }

        /// <summary>
        /// Whether threshold alerts have been sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_threshold_alerts_sent")]
        public bool? IsThresholdAlertsSent { get; set; }

        /// <summary>
        /// Whether exhausted alerts have been sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_exhausted_alerts_sent")]
        public bool? IsExhaustedAlertsSent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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