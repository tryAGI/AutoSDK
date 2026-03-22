//HintName: G.Models.InteractionExpiry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The duration of the interaction restriction. Default: `one_day`.<br/>
    /// Example: one_month
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InteractionExpiry
    {
        /// <summary>
        /// `one_day`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="one_day")]
        OneDay,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="one_month")]
        OneMonth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="one_week")]
        OneWeek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="six_months")]
        SixMonths,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="three_days")]
        ThreeDays,
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
                InteractionExpiry.OneMonth => "one_month",
                InteractionExpiry.OneWeek => "one_week",
                InteractionExpiry.SixMonths => "six_months",
                InteractionExpiry.ThreeDays => "three_days",
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
                "one_month" => InteractionExpiry.OneMonth,
                "one_week" => InteractionExpiry.OneWeek,
                "six_months" => InteractionExpiry.SixMonths,
                "three_days" => InteractionExpiry.ThreeDays,
                _ => null,
            };
        }
    }
}