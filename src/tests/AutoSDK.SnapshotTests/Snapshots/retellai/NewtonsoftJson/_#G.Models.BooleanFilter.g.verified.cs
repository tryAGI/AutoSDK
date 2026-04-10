//HintName: G.Models.BooleanFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BooleanFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BooleanFilterTypeJsonConverter))]
        public global::G.BooleanFilterType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BooleanFilterOpJsonConverter))]
        public global::G.BooleanFilterOp Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFilter" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <param name="op"></param>
        public BooleanFilter(
            bool value,
            global::G.BooleanFilterType type,
            global::G.BooleanFilterOp op)
        {
            this.Type = type;
            this.Op = op;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFilter" /> class.
        /// </summary>
        public BooleanFilter()
        {
        }
    }
}