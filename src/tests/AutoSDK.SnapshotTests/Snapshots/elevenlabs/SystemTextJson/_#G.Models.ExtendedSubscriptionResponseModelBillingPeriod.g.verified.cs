//HintName: G.Models.ExtendedSubscriptionResponseModelBillingPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The billing period of the user's subscription.
    /// </summary>
    public enum ExtendedSubscriptionResponseModelBillingPeriod
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
    public static class ExtendedSubscriptionResponseModelBillingPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtendedSubscriptionResponseModelBillingPeriod value)
        {
            return value switch
            {
                ExtendedSubscriptionResponseModelBillingPeriod.MonthlyPeriod => "monthly_period",
                ExtendedSubscriptionResponseModelBillingPeriod.AnnualPeriod => "annual_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtendedSubscriptionResponseModelBillingPeriod? ToEnum(string value)
        {
            return value switch
            {
                "monthly_period" => ExtendedSubscriptionResponseModelBillingPeriod.MonthlyPeriod,
                "annual_period" => ExtendedSubscriptionResponseModelBillingPeriod.AnnualPeriod,
                _ => null,
            };
        }
    }
}