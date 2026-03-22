//HintName: G.Models.ExtendedSubscriptionResponseModelCurrency2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExtendedSubscriptionResponseModelCurrency2
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
    public static class ExtendedSubscriptionResponseModelCurrency2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtendedSubscriptionResponseModelCurrency2 value)
        {
            return value switch
            {
                ExtendedSubscriptionResponseModelCurrency2.Eur => "eur",
                ExtendedSubscriptionResponseModelCurrency2.Inr => "inr",
                ExtendedSubscriptionResponseModelCurrency2.Usd => "usd",
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
                "eur" => ExtendedSubscriptionResponseModelCurrency2.Eur,
                "inr" => ExtendedSubscriptionResponseModelCurrency2.Inr,
                "usd" => ExtendedSubscriptionResponseModelCurrency2.Usd,
                _ => null,
            };
        }
    }
}