//HintName: G.Models.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FREE")]
        Free,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FLAT_RATE")]
        FlatRate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PER_UNIT")]
        PerUnit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel value)
        {
            return value switch
            {
                WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.Free => "FREE",
                WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.FlatRate => "FLAT_RATE",
                WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.PerUnit => "PER_UNIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel? ToEnum(string value)
        {
            return value switch
            {
                "FREE" => WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.Free,
                "FLAT_RATE" => WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.FlatRate,
                "PER_UNIT" => WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.PerUnit,
                _ => null,
            };
        }
    }
}