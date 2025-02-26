//HintName: G.Models.BillingErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: billing_error
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BillingErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="billing_error")]
        BillingError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingErrorType value)
        {
            return value switch
            {
                BillingErrorType.BillingError => "billing_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingErrorType? ToEnum(string value)
        {
            return value switch
            {
                "billing_error" => BillingErrorType.BillingError,
                _ => null,
            };
        }
    }
}