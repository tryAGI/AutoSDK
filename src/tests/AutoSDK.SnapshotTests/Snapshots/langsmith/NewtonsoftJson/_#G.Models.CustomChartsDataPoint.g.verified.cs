//HintName: G.Models.CustomChartsDataPoint.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartsDataPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("series_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SeriesId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<int?, double?, object>? Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group")]
        public string? Group { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsDataPoint" /> class.
        /// </summary>
        /// <param name="seriesId"></param>
        /// <param name="timestamp"></param>
        /// <param name="value"></param>
        /// <param name="group"></param>
        public CustomChartsDataPoint(
            string seriesId,
            global::System.DateTime timestamp,
            global::G.AnyOf<int?, double?, object>? value,
            string? group)
        {
            this.SeriesId = seriesId ?? throw new global::System.ArgumentNullException(nameof(seriesId));
            this.Timestamp = timestamp;
            this.Value = value;
            this.Group = group;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsDataPoint" /> class.
        /// </summary>
        public CustomChartsDataPoint()
        {
        }
    }
}