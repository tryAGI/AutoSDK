//HintName: G.Models.NumberFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NumberFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.NumberFilterTypeJsonConverter))]
        public global::G.NumberFilterType Type { get; set; }

        /// <summary>
        /// eq: equal, ne: not equal, gt: greater than, ge: greater than or equal, lt: less than, le: less than or equal
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.NumberFilterOpJsonConverter))]
        public global::G.NumberFilterOp Op { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="NumberFilter" /> class.
        /// </summary>
        /// <param name="op">
        /// eq: equal, ne: not equal, gt: greater than, ge: greater than or equal, lt: less than, le: less than or equal
        /// </param>
        /// <param name="value"></param>
        /// <param name="type"></param>
        public NumberFilter(
            global::G.NumberFilterOp op,
            double value,
            global::G.NumberFilterType type)
        {
            this.Type = type;
            this.Op = op;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberFilter" /> class.
        /// </summary>
        public NumberFilter()
        {
        }
    }
}