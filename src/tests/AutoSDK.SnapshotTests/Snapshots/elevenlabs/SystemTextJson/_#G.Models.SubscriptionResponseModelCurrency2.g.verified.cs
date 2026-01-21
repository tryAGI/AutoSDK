//HintName: G.Models.SubscriptionResponseModelCurrency2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionResponseModelCurrency2
    {
        /// <summary>
        /// 
        /// </summary>
        Usd,
        /// <summary>
        /// 
        /// </summary>
        Eur,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionResponseModelCurrency2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionResponseModelCurrency2 value)
        {
            return value switch
            {
                SubscriptionResponseModelCurrency2.Usd => "usd",
                SubscriptionResponseModelCurrency2.Eur => "eur",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionResponseModelCurrency2? ToEnum(string value)
        {
            return value switch
            {
                "usd" => SubscriptionResponseModelCurrency2.Usd,
                "eur" => SubscriptionResponseModelCurrency2.Eur,
                _ => null,
            };
        }
    }
}