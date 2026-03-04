//HintName: G.Models.WebhooksPreviousMarketplacePurchasePlanPriceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPreviousMarketplacePurchasePlanPriceModel
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
    public static class WebhooksPreviousMarketplacePurchasePlanPriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPreviousMarketplacePurchasePlanPriceModel value)
        {
            return value switch
            {
                WebhooksPreviousMarketplacePurchasePlanPriceModel.Free => "FREE",
                WebhooksPreviousMarketplacePurchasePlanPriceModel.FlatRate => "FLAT_RATE",
                WebhooksPreviousMarketplacePurchasePlanPriceModel.PerUnit => "PER_UNIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPreviousMarketplacePurchasePlanPriceModel? ToEnum(string value)
        {
            return value switch
            {
                "FREE" => WebhooksPreviousMarketplacePurchasePlanPriceModel.Free,
                "FLAT_RATE" => WebhooksPreviousMarketplacePurchasePlanPriceModel.FlatRate,
                "PER_UNIT" => WebhooksPreviousMarketplacePurchasePlanPriceModel.PerUnit,
                _ => null,
            };
        }
    }
}