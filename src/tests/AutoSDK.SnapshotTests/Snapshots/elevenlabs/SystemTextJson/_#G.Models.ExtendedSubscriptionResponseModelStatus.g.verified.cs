//HintName: G.Models.ExtendedSubscriptionResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExtendedSubscriptionResponseModelStatus
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
    public static class ExtendedSubscriptionResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtendedSubscriptionResponseModelStatus value)
        {
            return value switch
            {
                ExtendedSubscriptionResponseModelStatus.Trialing => "trialing",
                ExtendedSubscriptionResponseModelStatus.Active => "active",
                ExtendedSubscriptionResponseModelStatus.Incomplete => "incomplete",
                ExtendedSubscriptionResponseModelStatus.IncompleteExpired => "incomplete_expired",
                ExtendedSubscriptionResponseModelStatus.PastDue => "past_due",
                ExtendedSubscriptionResponseModelStatus.Canceled => "canceled",
                ExtendedSubscriptionResponseModelStatus.Unpaid => "unpaid",
                ExtendedSubscriptionResponseModelStatus.Free => "free",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtendedSubscriptionResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "trialing" => ExtendedSubscriptionResponseModelStatus.Trialing,
                "active" => ExtendedSubscriptionResponseModelStatus.Active,
                "incomplete" => ExtendedSubscriptionResponseModelStatus.Incomplete,
                "incomplete_expired" => ExtendedSubscriptionResponseModelStatus.IncompleteExpired,
                "past_due" => ExtendedSubscriptionResponseModelStatus.PastDue,
                "canceled" => ExtendedSubscriptionResponseModelStatus.Canceled,
                "unpaid" => ExtendedSubscriptionResponseModelStatus.Unpaid,
                "free" => ExtendedSubscriptionResponseModelStatus.Free,
                _ => null,
            };
        }
    }
}