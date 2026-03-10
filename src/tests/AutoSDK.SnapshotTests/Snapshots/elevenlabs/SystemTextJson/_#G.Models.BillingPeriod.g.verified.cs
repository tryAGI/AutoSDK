//HintName: G.Models.BillingPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BillingPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        MonthlyPeriod,
        /// <summary>
        /// 
        /// </summary>
        x3MonthPeriod,
        /// <summary>
        /// 
        /// </summary>
        x6MonthPeriod,
        /// <summary>
        /// 
        /// </summary>
        AnnualPeriod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingPeriod value)
        {
            return value switch
            {
                BillingPeriod.MonthlyPeriod => "monthly_period",
                BillingPeriod.x3MonthPeriod => "3_month_period",
                BillingPeriod.x6MonthPeriod => "6_month_period",
                BillingPeriod.AnnualPeriod => "annual_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingPeriod? ToEnum(string value)
        {
            return value switch
            {
                "monthly_period" => BillingPeriod.MonthlyPeriod,
                "3_month_period" => BillingPeriod.x3MonthPeriod,
                "6_month_period" => BillingPeriod.x6MonthPeriod,
                "annual_period" => BillingPeriod.AnnualPeriod,
                _ => null,
            };
        }
    }
}