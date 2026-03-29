//HintName: G.Models.EstimatePricingRequestVariant1EstimateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Estimate type: historical API pricing based on past usage patterns
    /// </summary>
    public enum EstimatePricingRequestVariant1EstimateType
    {
        /// <summary>
        /// 
        /// </summary>
        HistoricalApiPrice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimatePricingRequestVariant1EstimateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingRequestVariant1EstimateType value)
        {
            return value switch
            {
                EstimatePricingRequestVariant1EstimateType.HistoricalApiPrice => "historical_api_price",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingRequestVariant1EstimateType? ToEnum(string value)
        {
            return value switch
            {
                "historical_api_price" => EstimatePricingRequestVariant1EstimateType.HistoricalApiPrice,
                _ => null,
            };
        }
    }
}