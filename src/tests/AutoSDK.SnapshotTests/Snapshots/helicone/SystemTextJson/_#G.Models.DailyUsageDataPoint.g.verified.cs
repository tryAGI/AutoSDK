//HintName: G.Models.DailyUsageDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailyUsageDataPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Bytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyUsageDataPoint" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="requests"></param>
        /// <param name="bytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyUsageDataPoint(
            string date,
            double requests,
            double bytes)
        {
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.Requests = requests;
            this.Bytes = bytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyUsageDataPoint" /> class.
        /// </summary>
        public DailyUsageDataPoint()
        {
        }
    }
}