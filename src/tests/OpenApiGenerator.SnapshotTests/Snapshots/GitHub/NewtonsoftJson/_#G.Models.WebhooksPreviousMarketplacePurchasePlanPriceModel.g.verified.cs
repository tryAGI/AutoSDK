//HintName: G.Models.WebhooksPreviousMarketplacePurchasePlanPriceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPreviousMarketplacePurchasePlanPriceModel
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
    public static class WebhooksPreviousMarketplacePurchasePlanPriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPreviousMarketplacePurchasePlanPriceModel value)
        {
            return value switch
            {
                WebhooksPreviousMarketplacePurchasePlanPriceModel.FREE => "FREE",
                WebhooksPreviousMarketplacePurchasePlanPriceModel.FLATRATE => "FLAT_RATE",
                WebhooksPreviousMarketplacePurchasePlanPriceModel.PERUNIT => "PER_UNIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPreviousMarketplacePurchasePlanPriceModel ToEnum(string value)
        {
            return value switch
            {
                "FREE" => WebhooksPreviousMarketplacePurchasePlanPriceModel.FREE,
                "FLAT_RATE" => WebhooksPreviousMarketplacePurchasePlanPriceModel.FLATRATE,
                "PER_UNIT" => WebhooksPreviousMarketplacePurchasePlanPriceModel.PERUNIT,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}