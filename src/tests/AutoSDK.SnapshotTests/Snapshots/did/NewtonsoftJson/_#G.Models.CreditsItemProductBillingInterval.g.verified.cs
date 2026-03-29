//HintName: G.Models.CreditsItemProductBillingInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreditsItemProductBillingInterval
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="month")]
        Month,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="year")]
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreditsItemProductBillingIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreditsItemProductBillingInterval value)
        {
            return value switch
            {
                CreditsItemProductBillingInterval.Month => "month",
                CreditsItemProductBillingInterval.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreditsItemProductBillingInterval? ToEnum(string value)
        {
            return value switch
            {
                "month" => CreditsItemProductBillingInterval.Month,
                "year" => CreditsItemProductBillingInterval.Year,
                _ => null,
            };
        }
    }
}