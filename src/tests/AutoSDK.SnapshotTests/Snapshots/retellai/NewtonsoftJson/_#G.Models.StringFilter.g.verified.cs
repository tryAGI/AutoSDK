//HintName: G.Models.StringFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StringFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.StringFilterType Type { get; set; }

        /// <summary>
        /// eq: equal, ne: not equal, sw: starts with, ew: ends with, co: contains
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StringFilterOp Op { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StringFilter" /> class.
        /// </summary>
        /// <param name="op">
        /// eq: equal, ne: not equal, sw: starts with, ew: ends with, co: contains
        /// </param>
        /// <param name="value"></param>
        /// <param name="type"></param>
        public StringFilter(
            global::G.StringFilterOp op,
            string value,
            global::G.StringFilterType type)
        {
            this.Type = type;
            this.Op = op;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringFilter" /> class.
        /// </summary>
        public StringFilter()
        {
        }
    }
}