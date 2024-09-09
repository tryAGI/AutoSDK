//HintName: G.Models.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FREE")]
        FREE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FLAT_RATE")]
        FLATRATE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PER_UNIT")]
        PERUNIT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel value)
        {
            return value switch
            {
                WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel.FREE => "FREE",
                WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel.FLATRATE => "FLAT_RATE",
                WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel.PERUNIT => "PER_UNIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel? ToEnum(string value)
        {
            return value switch
            {
                "FREE" => WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel.FREE,
                "FLAT_RATE" => WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel.FLATRATE,
                "PER_UNIT" => WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel.PERUNIT,
                _ => null,
            };
        }
    }
}