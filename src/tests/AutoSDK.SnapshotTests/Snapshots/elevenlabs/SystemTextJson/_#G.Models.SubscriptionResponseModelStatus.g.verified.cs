//HintName: G.Models.SubscriptionResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionResponseModelStatus
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
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Unpaid,
        /// <summary>
        /// 
        /// </summary>
        Free,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionResponseModelStatus value)
        {
            return value switch
            {
                SubscriptionResponseModelStatus.Trialing => "trialing",
                SubscriptionResponseModelStatus.Active => "active",
                SubscriptionResponseModelStatus.Incomplete => "incomplete",
                SubscriptionResponseModelStatus.IncompleteExpired => "incomplete_expired",
                SubscriptionResponseModelStatus.PastDue => "past_due",
                SubscriptionResponseModelStatus.Canceled => "canceled",
                SubscriptionResponseModelStatus.Unpaid => "unpaid",
                SubscriptionResponseModelStatus.Free => "free",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "trialing" => SubscriptionResponseModelStatus.Trialing,
                "active" => SubscriptionResponseModelStatus.Active,
                "incomplete" => SubscriptionResponseModelStatus.Incomplete,
                "incomplete_expired" => SubscriptionResponseModelStatus.IncompleteExpired,
                "past_due" => SubscriptionResponseModelStatus.PastDue,
                "canceled" => SubscriptionResponseModelStatus.Canceled,
                "unpaid" => SubscriptionResponseModelStatus.Unpaid,
                "free" => SubscriptionResponseModelStatus.Free,
                _ => null,
            };
        }
    }
}