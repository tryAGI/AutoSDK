//HintName: G.Models.SubscriptionResponseModelCurrency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SubscriptionResponseModelCurrency
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
    public static class SubscriptionResponseModelCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionResponseModelCurrency value)
        {
            return value switch
            {
                SubscriptionResponseModelCurrency.Usd => "usd",
                SubscriptionResponseModelCurrency.Eur => "eur",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionResponseModelCurrency? ToEnum(string value)
        {
            return value switch
            {
                "usd" => SubscriptionResponseModelCurrency.Usd,
                "eur" => SubscriptionResponseModelCurrency.Eur,
                _ => null,
            };
        }
    }
}