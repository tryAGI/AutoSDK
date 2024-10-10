//HintName: G.Models.SubscriptionResponseModelCharacterRefreshPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SubscriptionResponseModelCharacterRefreshPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="monthly_period")]
        MonthlyPeriod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="annual_period")]
        AnnualPeriod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionResponseModelCharacterRefreshPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionResponseModelCharacterRefreshPeriod value)
        {
            return value switch
            {
                SubscriptionResponseModelCharacterRefreshPeriod.MonthlyPeriod => "monthly_period",
                SubscriptionResponseModelCharacterRefreshPeriod.AnnualPeriod => "annual_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionResponseModelCharacterRefreshPeriod? ToEnum(string value)
        {
            return value switch
            {
                "monthly_period" => SubscriptionResponseModelCharacterRefreshPeriod.MonthlyPeriod,
                "annual_period" => SubscriptionResponseModelCharacterRefreshPeriod.AnnualPeriod,
                _ => null,
            };
        }
    }
}