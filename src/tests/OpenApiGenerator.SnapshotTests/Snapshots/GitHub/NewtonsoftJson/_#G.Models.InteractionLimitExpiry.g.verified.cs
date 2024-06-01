//HintName: G.Models.InteractionLimitExpiry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The duration of the interaction restriction. Default: `one_day`.
    /// <br/>Example: one_month
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InteractionLimitExpiry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="one_day")]
        OneDay,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="three_days")]
        ThreeDays,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="one_week")]
        OneWeek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="one_month")]
        OneMonth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="six_months")]
        SixMonths,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InteractionLimitExpiryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InteractionLimitExpiry value)
        {
            return value switch
            {
                InteractionLimitExpiry.OneDay => "one_day",
                InteractionLimitExpiry.ThreeDays => "three_days",
                InteractionLimitExpiry.OneWeek => "one_week",
                InteractionLimitExpiry.OneMonth => "one_month",
                InteractionLimitExpiry.SixMonths => "six_months",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InteractionLimitExpiry ToEnum(string value)
        {
            return value switch
            {
                "one_day" => InteractionLimitExpiry.OneDay,
                "three_days" => InteractionLimitExpiry.ThreeDays,
                "one_week" => InteractionLimitExpiry.OneWeek,
                "one_month" => InteractionLimitExpiry.OneMonth,
                "six_months" => InteractionLimitExpiry.SixMonths,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}