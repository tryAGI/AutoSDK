//HintName: G.Models.SubscriptionMinutesIncludedResetFrequency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the minutes_included reset frequency for the subscription.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SubscriptionMinutesIncludedResetFrequency
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="annually")]
        Annually,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="monthly")]
        Monthly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionMinutesIncludedResetFrequencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionMinutesIncludedResetFrequency value)
        {
            return value switch
            {
                SubscriptionMinutesIncludedResetFrequency.Annually => "annually",
                SubscriptionMinutesIncludedResetFrequency.Monthly => "monthly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionMinutesIncludedResetFrequency? ToEnum(string value)
        {
            return value switch
            {
                "annually" => SubscriptionMinutesIncludedResetFrequency.Annually,
                "monthly" => SubscriptionMinutesIncludedResetFrequency.Monthly,
                _ => null,
            };
        }
    }
}