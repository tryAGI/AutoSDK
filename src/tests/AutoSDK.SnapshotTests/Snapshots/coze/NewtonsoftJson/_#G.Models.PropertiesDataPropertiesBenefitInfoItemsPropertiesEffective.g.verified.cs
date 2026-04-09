//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffective.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 实际生效总量
    /// </summary>
    public sealed partial class PropertiesDataPropertiesBenefitInfoItemsPropertiesEffective
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_info")]
        public global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfo? ItemInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatusJsonConverter))]
        public global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfoItemsPropertiesEffective" /> class.
        /// </summary>
        /// <param name="itemInfo"></param>
        /// <param name="status"></param>
        public PropertiesDataPropertiesBenefitInfoItemsPropertiesEffective(
            global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfo? itemInfo,
            global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus? status)
        {
            this.ItemInfo = itemInfo;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfoItemsPropertiesEffective" /> class.
        /// </summary>
        public PropertiesDataPropertiesBenefitInfoItemsPropertiesEffective()
        {
        }
    }
}