//HintName: G.Models.InteractionLimitExpiry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The duration of the interaction restriction. Default: `one_day`.
    /// <br/>Example: one_month
    /// </summary>
    public enum InteractionLimitExpiry
    {
        /// <summary>
        /// 
        /// </summary>
        OneDay,
        /// <summary>
        /// 
        /// </summary>
        ThreeDays,
        /// <summary>
        /// 
        /// </summary>
        OneWeek,
        /// <summary>
        /// 
        /// </summary>
        OneMonth,
        /// <summary>
        /// 
        /// </summary>
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