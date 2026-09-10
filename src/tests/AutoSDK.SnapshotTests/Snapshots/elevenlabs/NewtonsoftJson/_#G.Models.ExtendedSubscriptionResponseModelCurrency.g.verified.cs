//HintName: G.Models.ExtendedSubscriptionResponseModelCurrency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtendedSubscriptionResponseModelCurrency
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eur")]
        Eur,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inr")]
        Inr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="usd")]
        Usd,
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
                ExtendedSubscriptionResponseModelCurrency.Eur => "eur",
                ExtendedSubscriptionResponseModelCurrency.Inr => "inr",
                ExtendedSubscriptionResponseModelCurrency.Usd => "usd",
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
                "eur" => ExtendedSubscriptionResponseModelCurrency.Eur,
                "inr" => ExtendedSubscriptionResponseModelCurrency.Inr,
                "usd" => ExtendedSubscriptionResponseModelCurrency.Usd,
                _ => null,
            };
        }
    }
}