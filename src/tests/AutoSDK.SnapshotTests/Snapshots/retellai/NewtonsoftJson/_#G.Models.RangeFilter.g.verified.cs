//HintName: G.Models.RangeFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RangeFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RangeFilterType Type { get; set; }

        /// <summary>
        /// bt: between
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op")]
        public global::G.RangeFilterOp Op { get; set; }

        /// <summary>
        /// [lower_bound, upper_bound]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeFilter" /> class.
        /// </summary>
        /// <param name="value">
        /// [lower_bound, upper_bound]
        /// </param>
        /// <param name="type"></param>
        /// <param name="op">
        /// bt: between
        /// </param>
        public RangeFilter(
            global::System.Collections.Generic.IList<double> value,
            global::G.RangeFilterType type,
            global::G.RangeFilterOp op)
        {
            this.Type = type;
            this.Op = op;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeFilter" /> class.
        /// </summary>
        public RangeFilter()
        {
        }
    }
}