//HintName: G.Models.HistogramRow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HistogramRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RangeStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RangeEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistogramRow" /> class.
        /// </summary>
        /// <param name="rangeStart"></param>
        /// <param name="rangeEnd"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistogramRow(
            string rangeStart,
            string rangeEnd,
            double value)
        {
            this.RangeStart = rangeStart ?? throw new global::System.ArgumentNullException(nameof(rangeStart));
            this.RangeEnd = rangeEnd ?? throw new global::System.ArgumentNullException(nameof(rangeEnd));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistogramRow" /> class.
        /// </summary>
        public HistogramRow()
        {
        }
    }
}