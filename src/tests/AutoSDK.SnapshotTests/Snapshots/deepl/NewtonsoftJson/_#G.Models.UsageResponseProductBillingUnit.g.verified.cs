//HintName: G.Models.UsageResponseProductBillingUnit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The billing unit for this product type.<br/>
    /// Example: characters
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageResponseProductBillingUnit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="characters")]
        Characters,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="milliseconds")]
        Milliseconds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageResponseProductBillingUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageResponseProductBillingUnit value)
        {
            return value switch
            {
                UsageResponseProductBillingUnit.Characters => "characters",
                UsageResponseProductBillingUnit.Milliseconds => "milliseconds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageResponseProductBillingUnit? ToEnum(string value)
        {
            return value switch
            {
                "characters" => UsageResponseProductBillingUnit.Characters,
                "milliseconds" => UsageResponseProductBillingUnit.Milliseconds,
                _ => null,
            };
        }
    }
}