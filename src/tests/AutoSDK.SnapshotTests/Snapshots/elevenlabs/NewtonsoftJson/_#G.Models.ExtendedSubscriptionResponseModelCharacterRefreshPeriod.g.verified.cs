//HintName: G.Models.ExtendedSubscriptionResponseModelCharacterRefreshPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The character refresh period of the user's subscription.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtendedSubscriptionResponseModelCharacterRefreshPeriod
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
    public static class ExtendedSubscriptionResponseModelCharacterRefreshPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtendedSubscriptionResponseModelCharacterRefreshPeriod value)
        {
            return value switch
            {
                ExtendedSubscriptionResponseModelCharacterRefreshPeriod.MonthlyPeriod => "monthly_period",
                ExtendedSubscriptionResponseModelCharacterRefreshPeriod.AnnualPeriod => "annual_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtendedSubscriptionResponseModelCharacterRefreshPeriod? ToEnum(string value)
        {
            return value switch
            {
                "monthly_period" => ExtendedSubscriptionResponseModelCharacterRefreshPeriod.MonthlyPeriod,
                "annual_period" => ExtendedSubscriptionResponseModelCharacterRefreshPeriod.AnnualPeriod,
                _ => null,
            };
        }
    }
}