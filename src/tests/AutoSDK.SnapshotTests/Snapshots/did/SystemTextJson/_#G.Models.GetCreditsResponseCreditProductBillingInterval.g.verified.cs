//HintName: G.Models.GetCreditsResponseCreditProductBillingInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCreditsResponseCreditProductBillingInterval
    {
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
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