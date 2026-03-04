//HintName: G.Models.MarketplaceListingPlanPriceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: FLAT_RATE
    /// </summary>
    public enum MarketplaceListingPlanPriceModel
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
    public static class MarketplaceListingPlanPriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarketplaceListingPlanPriceModel value)
        {
            return value switch
            {
                MarketplaceListingPlanPriceModel.Free => "FREE",
                MarketplaceListingPlanPriceModel.FlatRate => "FLAT_RATE",
                MarketplaceListingPlanPriceModel.PerUnit => "PER_UNIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarketplaceListingPlanPriceModel? ToEnum(string value)
        {
            return value switch
            {
                "FREE" => MarketplaceListingPlanPriceModel.Free,
                "FLAT_RATE" => MarketplaceListingPlanPriceModel.FlatRate,
                "PER_UNIT" => MarketplaceListingPlanPriceModel.PerUnit,
                _ => null,
            };
        }
    }
}