//HintName: G.Models.WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel
    {
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        FlatRate,
        /// <summary>
        /// 
        /// </summary>
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
                WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.Free => "FREE",
                WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.FlatRate => "FLAT_RATE",
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
                "FREE" => WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.Free,
                "FLAT_RATE" => WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.FlatRate,
                "PER_UNIT" => WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.PerUnit,
                _ => null,
            };
        }
    }
}