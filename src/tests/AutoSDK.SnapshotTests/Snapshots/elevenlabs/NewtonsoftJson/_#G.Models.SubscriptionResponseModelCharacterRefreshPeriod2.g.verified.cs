//HintName: G.Models.SubscriptionResponseModelCharacterRefreshPeriod2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SubscriptionResponseModelCharacterRefreshPeriod2
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
    public static class SubscriptionResponseModelCharacterRefreshPeriod2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionResponseModelCharacterRefreshPeriod2 value)
        {
            return value switch
            {
                SubscriptionResponseModelCharacterRefreshPeriod2.MonthlyPeriod => "monthly_period",
                SubscriptionResponseModelCharacterRefreshPeriod2.AnnualPeriod => "annual_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionResponseModelCharacterRefreshPeriod2? ToEnum(string value)
        {
            return value switch
            {
                "monthly_period" => SubscriptionResponseModelCharacterRefreshPeriod2.MonthlyPeriod,
                "annual_period" => SubscriptionResponseModelCharacterRefreshPeriod2.AnnualPeriod,
                _ => null,
            };
        }
    }
}