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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RateLimitsTypeJsonConverter))]
        public global::G.RateLimitsType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RateLimitsUnitJsonConverter))]
        public global::G.RateLimitsUnit? Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public int? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimits" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="unit"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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