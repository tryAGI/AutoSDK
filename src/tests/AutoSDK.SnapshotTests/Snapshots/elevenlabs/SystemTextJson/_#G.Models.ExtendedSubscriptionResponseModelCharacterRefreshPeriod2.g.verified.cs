//HintName: G.Models.ExtendedSubscriptionResponseModelCharacterRefreshPeriod2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExtendedSubscriptionResponseModelCharacterRefreshPeriod2
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
    public static class ExtendedSubscriptionResponseModelCharacterRefreshPeriod2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtendedSubscriptionResponseModelCharacterRefreshPeriod2 value)
        {
            return value switch
            {
                ExtendedSubscriptionResponseModelCharacterRefreshPeriod2.MonthlyPeriod => "monthly_period",
                ExtendedSubscriptionResponseModelCharacterRefreshPeriod2.AnnualPeriod => "annual_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtendedSubscriptionResponseModelCharacterRefreshPeriod2? ToEnum(string value)
        {
            return value switch
            {
                "monthly_period" => ExtendedSubscriptionResponseModelCharacterRefreshPeriod2.MonthlyPeriod,
                "annual_period" => ExtendedSubscriptionResponseModelCharacterRefreshPeriod2.AnnualPeriod,
                _ => null,
            };
        }
    }
}