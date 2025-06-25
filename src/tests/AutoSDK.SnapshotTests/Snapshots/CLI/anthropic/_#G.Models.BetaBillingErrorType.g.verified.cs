//HintName: G.Models.BetaBillingErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: billing_error
    /// </summary>
    public enum BetaBillingErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        BillingError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBillingErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBillingErrorType value)
        {
            return value switch
            {
                BetaBillingErrorType.BillingError => "billing_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBillingErrorType? ToEnum(string value)
        {
            return value switch
            {
                "billing_error" => BetaBillingErrorType.BillingError,
                _ => null,
            };
        }
    }
}