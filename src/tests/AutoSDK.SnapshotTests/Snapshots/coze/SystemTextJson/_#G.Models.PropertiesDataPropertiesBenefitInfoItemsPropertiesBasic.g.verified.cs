//HintName: G.Models.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 基础值
    /// </summary>
    public sealed partial class PropertiesDataPropertiesBenefitInfoItemsPropertiesBasic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_info")]
        public global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfo? ItemInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatusJsonConverter))]
        public global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfoItemsPropertiesBasic" /> class.
        /// </summary>
        /// <param name="itemInfo"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesDataPropertiesBenefitInfoItemsPropertiesBasic(
            global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfo? itemInfo,
            global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus? status)
        {
            this.ItemInfo = itemInfo;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesDataPropertiesBenefitInfoItemsPropertiesBasic" /> class.
        /// </summary>
        public PropertiesDataPropertiesBenefitInfoItemsPropertiesBasic()
        {
        }
    }
}