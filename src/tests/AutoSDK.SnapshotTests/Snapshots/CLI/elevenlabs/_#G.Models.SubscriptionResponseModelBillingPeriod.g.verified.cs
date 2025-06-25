﻿//HintName: G.Models.SubscriptionResponseModelBillingPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The billing period of the user's subscription.
    /// </summary>
    public enum SubscriptionResponseModelBillingPeriod
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
    public static class SubscriptionResponseModelBillingPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionResponseModelBillingPeriod value)
        {
            return value switch
            {
                SubscriptionResponseModelBillingPeriod.MonthlyPeriod => "monthly_period",
                SubscriptionResponseModelBillingPeriod.AnnualPeriod => "annual_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionResponseModelBillingPeriod? ToEnum(string value)
        {
            return value switch
            {
                "monthly_period" => SubscriptionResponseModelBillingPeriod.MonthlyPeriod,
                "annual_period" => SubscriptionResponseModelBillingPeriod.AnnualPeriod,
                _ => null,
            };
        }
    }
}