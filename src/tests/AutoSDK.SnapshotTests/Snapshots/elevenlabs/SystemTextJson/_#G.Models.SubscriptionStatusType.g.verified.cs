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
        Trialing,
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        IncompleteExpired,
        /// <summary>
        /// 
        /// </summary>
        PastDue,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        FreeDisabled,
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
                SubscriptionStatusType.Trialing => "trialing",
                SubscriptionStatusType.Active => "active",
                SubscriptionStatusType.Incomplete => "incomplete",
                SubscriptionStatusType.IncompleteExpired => "incomplete_expired",
                SubscriptionStatusType.PastDue => "past_due",
                SubscriptionStatusType.Free => "free",
                SubscriptionStatusType.FreeDisabled => "free_disabled",
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
                "trialing" => SubscriptionStatusType.Trialing,
                "active" => SubscriptionStatusType.Active,
                "incomplete" => SubscriptionStatusType.Incomplete,
                "incomplete_expired" => SubscriptionStatusType.IncompleteExpired,
                "past_due" => SubscriptionStatusType.PastDue,
                "free" => SubscriptionStatusType.Free,
                "free_disabled" => SubscriptionStatusType.FreeDisabled,
                _ => null,
            };
        }
    }
}