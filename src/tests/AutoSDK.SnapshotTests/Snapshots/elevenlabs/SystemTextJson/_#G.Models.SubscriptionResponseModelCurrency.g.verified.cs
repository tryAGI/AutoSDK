//HintName: G.Models.SubscriptionResponseModelCurrency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionResponseModelCurrency
    {
        /// <summary>
        /// 
        /// </summary>
        Eur,
        /// <summary>
        /// 
        /// </summary>
        Inr,
        /// <summary>
        /// 
        /// </summary>
        Usd,
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
                SubscriptionResponseModelCurrency.Eur => "eur",
                SubscriptionResponseModelCurrency.Inr => "inr",
                SubscriptionResponseModelCurrency.Usd => "usd",
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
                "eur" => SubscriptionResponseModelCurrency.Eur,
                "inr" => SubscriptionResponseModelCurrency.Inr,
                "usd" => SubscriptionResponseModelCurrency.Usd,
                _ => null,
            };
        }
    }
}