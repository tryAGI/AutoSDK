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
        [global::System.Text.Json.Serialization.JsonPropertyName("series_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SeriesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<int?, double?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<int?, double?, object>? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsDataPoint" /> class.
        /// </summary>
        /// <param name="seriesId"></param>
        /// <param name="timestamp"></param>
        /// <param name="value"></param>
        /// <param name="group"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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