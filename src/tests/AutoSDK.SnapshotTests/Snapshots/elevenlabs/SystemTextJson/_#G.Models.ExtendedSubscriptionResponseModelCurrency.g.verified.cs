//HintName: G.Models.ExtendedSubscriptionResponseModelCurrency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExtendedSubscriptionResponseModelCurrency
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
    public static class ExtendedSubscriptionResponseModelCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtendedSubscriptionResponseModelCurrency value)
        {
            return value switch
            {
                ExtendedSubscriptionResponseModelCurrency.Usd => "usd",
                ExtendedSubscriptionResponseModelCurrency.Eur => "eur",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtendedSubscriptionResponseModelCurrency? ToEnum(string value)
        {
            return value switch
            {
                "usd" => ExtendedSubscriptionResponseModelCurrency.Usd,
                "eur" => ExtendedSubscriptionResponseModelCurrency.Eur,
                _ => null,
            };
        }
    }
}