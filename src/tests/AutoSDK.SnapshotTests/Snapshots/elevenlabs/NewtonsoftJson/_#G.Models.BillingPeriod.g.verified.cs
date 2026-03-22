//HintName: G.Models.BillingPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BillingPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3_month_period")]
        x3MonthPeriod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="6_month_period")]
        x6MonthPeriod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="annual_period")]
        AnnualPeriod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="monthly_period")]
        MonthlyPeriod,
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
                BillingPeriod.x3MonthPeriod => "3_month_period",
                BillingPeriod.x6MonthPeriod => "6_month_period",
                BillingPeriod.AnnualPeriod => "annual_period",
                BillingPeriod.MonthlyPeriod => "monthly_period",
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
                "3_month_period" => BillingPeriod.x3MonthPeriod,
                "6_month_period" => BillingPeriod.x6MonthPeriod,
                "annual_period" => BillingPeriod.AnnualPeriod,
                "monthly_period" => BillingPeriod.MonthlyPeriod,
                _ => null,
            };
        }
    }
}