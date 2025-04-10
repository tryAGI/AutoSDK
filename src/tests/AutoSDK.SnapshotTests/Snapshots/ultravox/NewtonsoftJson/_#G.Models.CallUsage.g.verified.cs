//HintName: G.Models.CallUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallUsage
    {
        /// <summary>
        /// All-time call usage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allTime", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CallStatistics AllTime { get; set; } = default!;

        /// <summary>
        /// Call usage per day
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("daily", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DailyCallStatistics> Daily { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallUsage" /> class.
        /// </summary>
        /// <param name="allTime">
        /// All-time call usage
        /// </param>
        /// <param name="daily">
        /// Call usage per day
        /// </param>
        public CallUsage(
            global::G.CallStatistics allTime,
            global::System.Collections.Generic.IList<global::G.DailyCallStatistics> daily)
        {
            this.AllTime = allTime ?? throw new global::System.ArgumentNullException(nameof(allTime));
            this.Daily = daily ?? throw new global::System.ArgumentNullException(nameof(daily));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallUsage" /> class.
        /// </summary>
        public CallUsage()
        {
        }
    }
}