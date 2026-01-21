//HintName: G.Models.SubscriptionResponseModelBillingPeriod2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionResponseModelBillingPeriod2
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
    public static class SubscriptionResponseModelBillingPeriod2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionResponseModelBillingPeriod2 value)
        {
            return value switch
            {
                SubscriptionResponseModelBillingPeriod2.MonthlyPeriod => "monthly_period",
                SubscriptionResponseModelBillingPeriod2.AnnualPeriod => "annual_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionResponseModelBillingPeriod2? ToEnum(string value)
        {
            return value switch
            {
                "monthly_period" => SubscriptionResponseModelBillingPeriod2.MonthlyPeriod,
                "annual_period" => SubscriptionResponseModelBillingPeriod2.AnnualPeriod,
                _ => null,
            };
        }
    }
}