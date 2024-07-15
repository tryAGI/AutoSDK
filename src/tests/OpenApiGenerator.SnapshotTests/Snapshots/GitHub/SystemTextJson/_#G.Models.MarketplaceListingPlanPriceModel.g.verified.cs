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
        FREE,
        /// <summary>
        /// 
        /// </summary>
        FLATRATE,
        /// <summary>
        /// 
        /// </summary>
        PERUNIT,
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
                MarketplaceListingPlanPriceModel.FREE => "FREE",
                MarketplaceListingPlanPriceModel.FLATRATE => "FLAT_RATE",
                MarketplaceListingPlanPriceModel.PERUNIT => "PER_UNIT",
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
                "FREE" => MarketplaceListingPlanPriceModel.FREE,
                "FLAT_RATE" => MarketplaceListingPlanPriceModel.FLATRATE,
                "PER_UNIT" => MarketplaceListingPlanPriceModel.PERUNIT,
                _ => null,
            };
        }
    }
}