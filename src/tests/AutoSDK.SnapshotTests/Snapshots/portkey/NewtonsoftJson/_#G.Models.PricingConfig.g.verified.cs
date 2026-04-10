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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PricingConfigTypeJsonConverter))]
        public global::G.PricingConfigType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pay_as_you_go")]
        public global::G.PayAsYouGoPricing? PayAsYouGo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Pricing type
        /// </param>
        /// <param name="payAsYouGo"></param>
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