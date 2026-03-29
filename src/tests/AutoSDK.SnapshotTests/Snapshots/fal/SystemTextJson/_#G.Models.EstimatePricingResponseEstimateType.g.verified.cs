//HintName: G.Models.EstimatePricingResponseEstimateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of estimate that was performed
    /// </summary>
    public enum EstimatePricingResponseEstimateType
    {
        /// <summary>
        /// 
        /// </summary>
        HistoricalApiPrice,
        /// <summary>
        /// 
        /// </summary>
        UnitPrice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimatePricingResponseEstimateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseEstimateType value)
        {
            return value switch
            {
                EstimatePricingResponseEstimateType.HistoricalApiPrice => "historical_api_price",
                EstimatePricingResponseEstimateType.UnitPrice => "unit_price",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseEstimateType? ToEnum(string value)
        {
            return value switch
            {
                "historical_api_price" => EstimatePricingResponseEstimateType.HistoricalApiPrice,
                "unit_price" => EstimatePricingResponseEstimateType.UnitPrice,
                _ => null,
            };
        }
    }
}