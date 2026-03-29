//HintName: G.Models.GetCreditsResponseCreditProductBillingInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetCreditsResponseCreditProductBillingInterval
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
    public static class GetCreditsResponseCreditProductBillingIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCreditsResponseCreditProductBillingInterval value)
        {
            return value switch
            {
                GetCreditsResponseCreditProductBillingInterval.Month => "month",
                GetCreditsResponseCreditProductBillingInterval.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCreditsResponseCreditProductBillingInterval? ToEnum(string value)
        {
            return value switch
            {
                "month" => GetCreditsResponseCreditProductBillingInterval.Month,
                "year" => GetCreditsResponseCreditProductBillingInterval.Year,
                _ => null,
            };
        }
    }
}