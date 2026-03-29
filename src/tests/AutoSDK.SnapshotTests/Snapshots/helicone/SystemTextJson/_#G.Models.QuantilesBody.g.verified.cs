//HintName: G.Models.QuantilesBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuantilesBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterNode Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeFilter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.QuantilesBodyTimeFilter TimeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbIncrement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TimeIncrementJsonConverter))]
        public global::G.TimeIncrement? DbIncrement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeZoneDifference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TimeZoneDifference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Metric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantilesBody" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="timeFilter"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="metric"></param>
        /// <param name="dbIncrement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuantilesBody(
            global::G.FilterNode filter,
            global::G.QuantilesBodyTimeFilter timeFilter,
            double timeZoneDifference,
            string metric,
            global::G.TimeIncrement? dbIncrement)
        {
            this.Filter = filter;
            this.TimeFilter = timeFilter ?? throw new global::System.ArgumentNullException(nameof(timeFilter));
            this.DbIncrement = dbIncrement;
            this.TimeZoneDifference = timeZoneDifference;
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantilesBody" /> class.
        /// </summary>
        public QuantilesBody()
        {
        }
    }
}