//HintName: G.Models.InteractionExpiry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The duration of the interaction restriction. Default: `one_day`.<br/>
    /// Example: one_month
    /// </summary>
    public enum InteractionExpiry
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
    public static class InteractionExpiryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InteractionExpiry value)
        {
            return value switch
            {
                InteractionExpiry.OneDay => "one_day",
                InteractionExpiry.ThreeDays => "three_days",
                InteractionExpiry.OneWeek => "one_week",
                InteractionExpiry.OneMonth => "one_month",
                InteractionExpiry.SixMonths => "six_months",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InteractionExpiry? ToEnum(string value)
        {
            return value switch
            {
                "one_day" => InteractionExpiry.OneDay,
                "three_days" => InteractionExpiry.ThreeDays,
                "one_week" => InteractionExpiry.OneWeek,
                "one_month" => InteractionExpiry.OneMonth,
                "six_months" => InteractionExpiry.SixMonths,
                _ => null,
            };
        }
    }
}