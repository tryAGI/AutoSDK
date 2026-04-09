//HintName: G.Models.EnumFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnumFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EnumFilterTypeJsonConverter))]
        public global::G.EnumFilterType Type { get; set; }

        /// <summary>
        /// in: value is one of the listed values
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EnumFilterOpJsonConverter))]
        public global::G.EnumFilterOp Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumFilter" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <param name="op">
        /// in: value is one of the listed values
        /// </param>
        public EnumFilter(
            global::System.Collections.Generic.IList<string> value,
            global::G.EnumFilterType type,
            global::G.EnumFilterOp op)
        {
            this.Type = type;
            this.Op = op;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumFilter" /> class.
        /// </summary>
        public EnumFilter()
        {
        }
    }
}