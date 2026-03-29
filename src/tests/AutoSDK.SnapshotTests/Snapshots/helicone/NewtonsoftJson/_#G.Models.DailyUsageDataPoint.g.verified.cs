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
        [global::Newtonsoft.Json.JsonProperty("date", Required = global::Newtonsoft.Json.Required.Always)]
        public string Date { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests", Required = global::Newtonsoft.Json.Required.Always)]
        public double Requests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public double Bytes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyUsageDataPoint" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="requests"></param>
        /// <param name="bytes"></param>
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