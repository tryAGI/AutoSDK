//HintName: G.Models.PricingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PricingConfig
    {
        /// <summary>
        /// Pricing type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PricingConfigTypeJsonConverter))]
        public global::G.PricingConfigType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pay_as_you_go")]
        public global::G.PayAsYouGoPricing? PayAsYouGo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Pricing type
        /// </param>
        /// <param name="payAsYouGo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingConfig(
            global::G.PricingConfigType? type,
            global::G.PayAsYouGoPricing? payAsYouGo)
        {
            this.Type = type;
            this.PayAsYouGo = payAsYouGo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingConfig" /> class.
        /// </summary>
        public PricingConfig()
        {
        }
    }
}