//HintName: G.Models.ExtendedSubscriptionResponseModelCurrency2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtendedSubscriptionResponseModelCurrency2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="usd")]
        Usd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eur")]
        Eur,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtendedSubscriptionResponseModelCurrency2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtendedSubscriptionResponseModelCurrency2 value)
        {
            return value switch
            {
                ExtendedSubscriptionResponseModelCurrency2.Usd => "usd",
                ExtendedSubscriptionResponseModelCurrency2.Eur => "eur",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtendedSubscriptionResponseModelCurrency2? ToEnum(string value)
        {
            return value switch
            {
                "usd" => ExtendedSubscriptionResponseModelCurrency2.Usd,
                "eur" => ExtendedSubscriptionResponseModelCurrency2.Eur,
                _ => null,
            };
        }
    }
}