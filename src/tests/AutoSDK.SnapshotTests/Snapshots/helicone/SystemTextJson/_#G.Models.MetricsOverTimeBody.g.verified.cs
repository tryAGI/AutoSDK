//HintName: G.Models.MetricsOverTimeBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricsOverTimeBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeFilter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MetricsOverTimeBodyTimeFilter TimeFilter { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsOverTimeBody" /> class.
        /// </summary>
        /// <param name="timeFilter"></param>
        /// <param name="filter"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="dbIncrement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricsOverTimeBody(
            global::G.MetricsOverTimeBodyTimeFilter timeFilter,
            global::G.FilterNode filter,
            double timeZoneDifference,
            global::G.TimeIncrement? dbIncrement)
        {
            this.TimeFilter = timeFilter ?? throw new global::System.ArgumentNullException(nameof(timeFilter));
            this.Filter = filter;
            this.DbIncrement = dbIncrement;
            this.TimeZoneDifference = timeZoneDifference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsOverTimeBody" /> class.
        /// </summary>
        public MetricsOverTimeBody()
        {
        }
    }
}