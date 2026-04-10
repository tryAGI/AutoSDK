//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_info")]
        public global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfo? ItemInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatusJsonConverter))]
        public global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems" /> class.
        /// </summary>
        /// <param name="itemInfo"></param>
        /// <param name="status"></param>
        public PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems(
            global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfo? itemInfo,
            global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus? status)
        {
            this.ItemInfo = itemInfo;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems" /> class.
        /// </summary>
        public PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems()
        {
        }
    }
}