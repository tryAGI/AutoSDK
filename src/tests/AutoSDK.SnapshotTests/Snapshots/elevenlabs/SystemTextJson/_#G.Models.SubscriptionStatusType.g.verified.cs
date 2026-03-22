//HintName: G.Models.SubscriptionStatusType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionStatusType
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        FreeDisabled,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        PastDue,
        /// <summary>
        /// 
        /// </summary>
        Trialing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionStatusTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionStatusType value)
        {
            return value switch
            {
                SubscriptionStatusType.Active => "active",
                SubscriptionStatusType.Free => "free",
                SubscriptionStatusType.FreeDisabled => "free_disabled",
                SubscriptionStatusType.Incomplete => "incomplete",
                SubscriptionStatusType.PastDue => "past_due",
                SubscriptionStatusType.Trialing => "trialing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionStatusType? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionStatusType.Active,
                "free" => SubscriptionStatusType.Free,
                "free_disabled" => SubscriptionStatusType.FreeDisabled,
                "incomplete" => SubscriptionStatusType.Incomplete,
                "past_due" => SubscriptionStatusType.PastDue,
                "trialing" => SubscriptionStatusType.Trialing,
                _ => null,
            };
        }
    }
}