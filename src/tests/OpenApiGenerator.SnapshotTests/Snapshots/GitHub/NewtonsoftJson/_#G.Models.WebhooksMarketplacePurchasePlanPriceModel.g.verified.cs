//HintName: G.Models.WebhooksMarketplacePurchasePlanPriceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksMarketplacePurchasePlanPriceModel
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
    public static class WebhooksMarketplacePurchasePlanPriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksMarketplacePurchasePlanPriceModel value)
        {
            return value switch
            {
                WebhooksMarketplacePurchasePlanPriceModel.FREE => "FREE",
                WebhooksMarketplacePurchasePlanPriceModel.FLATRATE => "FLAT_RATE",
                WebhooksMarketplacePurchasePlanPriceModel.PERUNIT => "PER_UNIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksMarketplacePurchasePlanPriceModel ToEnum(string value)
        {
            return value switch
            {
                "FREE" => WebhooksMarketplacePurchasePlanPriceModel.FREE,
                "FLAT_RATE" => WebhooksMarketplacePurchasePlanPriceModel.FLATRATE,
                "PER_UNIT" => WebhooksMarketplacePurchasePlanPriceModel.PERUNIT,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}