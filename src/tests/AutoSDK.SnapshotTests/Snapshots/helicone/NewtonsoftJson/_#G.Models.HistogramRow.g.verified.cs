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
        [global::Newtonsoft.Json.JsonProperty("range_start", Required = global::Newtonsoft.Json.Required.Always)]
        public string RangeStart { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("range_end", Required = global::Newtonsoft.Json.Required.Always)]
        public string RangeEnd { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistogramRow" /> class.
        /// </summary>
        /// <param name="rangeStart"></param>
        /// <param name="rangeEnd"></param>
        /// <param name="value"></param>
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