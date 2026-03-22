//HintName: G.Models.WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FLAT_RATE")]
        FlatRate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FREE")]
        Free,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PER_UNIT")]
        PerUnit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel value)
        {
            return value switch
            {
                WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.FlatRate => "FLAT_RATE",
                WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.Free => "FREE",
                WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.PerUnit => "PER_UNIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel? ToEnum(string value)
        {
            return value switch
            {
                "FLAT_RATE" => WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.FlatRate,
                "FREE" => WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.Free,
                "PER_UNIT" => WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.PerUnit,
                _ => null,
            };
        }
    }
}