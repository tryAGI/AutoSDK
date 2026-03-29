//HintName: G.Models.PricingConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pricing type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PricingConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="static")]
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PricingConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingConfigType value)
        {
            return value switch
            {
                PricingConfigType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingConfigType? ToEnum(string value)
        {
            return value switch
            {
                "static" => PricingConfigType.Static,
                _ => null,
            };
        }
    }
}