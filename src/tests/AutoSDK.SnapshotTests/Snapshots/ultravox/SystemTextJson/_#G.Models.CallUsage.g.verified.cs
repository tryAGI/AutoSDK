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
        [global::System.Text.Json.Serialization.JsonPropertyName("allTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CallStatistics AllTime { get; set; }

        /// <summary>
        /// Call usage per day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DailyCallStatistics> Daily { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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