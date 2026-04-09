//HintName: G.Models.RateLimits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimits
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RateLimitsTypeJsonConverter))]
        public global::G.RateLimitsType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RateLimitsUnitJsonConverter))]
        public global::G.RateLimitsUnit? Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public int? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimits" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public RateLimits(
            global::G.RateLimitsType? type,
            global::G.RateLimitsUnit? unit,
            int? value)
        {
            this.Type = type;
            this.Unit = unit;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimits" /> class.
        /// </summary>
        public RateLimits()
        {
        }
    }
}