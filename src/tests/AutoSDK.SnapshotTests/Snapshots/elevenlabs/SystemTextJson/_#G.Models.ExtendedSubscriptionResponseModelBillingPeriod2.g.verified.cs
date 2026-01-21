//HintName: G.Models.ExtendedSubscriptionResponseModelBillingPeriod2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExtendedSubscriptionResponseModelBillingPeriod2
    {
        /// <summary>
        /// 
        /// </summary>
        MonthlyPeriod,
        /// <summary>
        /// 
        /// </summary>
        AnnualPeriod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtendedSubscriptionResponseModelBillingPeriod2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtendedSubscriptionResponseModelBillingPeriod2 value)
        {
            return value switch
            {
                ExtendedSubscriptionResponseModelBillingPeriod2.MonthlyPeriod => "monthly_period",
                ExtendedSubscriptionResponseModelBillingPeriod2.AnnualPeriod => "annual_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtendedSubscriptionResponseModelBillingPeriod2? ToEnum(string value)
        {
            return value switch
            {
                "monthly_period" => ExtendedSubscriptionResponseModelBillingPeriod2.MonthlyPeriod,
                "annual_period" => ExtendedSubscriptionResponseModelBillingPeriod2.AnnualPeriod,
                _ => null,
            };
        }
    }
}