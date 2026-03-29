//HintName: G.Models.EstimatePricingRequestVariant2EstimateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Estimate type: unit price calculation based on billing units
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EstimatePricingRequestVariant2EstimateType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unit_price")]
        UnitPrice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimatePricingRequestVariant2EstimateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingRequestVariant2EstimateType value)
        {
            return value switch
            {
                EstimatePricingRequestVariant2EstimateType.UnitPrice => "unit_price",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingRequestVariant2EstimateType? ToEnum(string value)
        {
            return value switch
            {
                "unit_price" => EstimatePricingRequestVariant2EstimateType.UnitPrice,
                _ => null,
            };
        }
    }
}