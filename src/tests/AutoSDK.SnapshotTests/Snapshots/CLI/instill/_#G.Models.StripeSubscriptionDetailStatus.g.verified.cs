//HintName: G.Models.StripeSubscriptionDetailStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enumerates the status types for the user's subscription.<br/>
    ///  - STATUS_INCOMPLETE: Incomplete.<br/>
    ///  - STATUS_INCOMPLETE_EXPIRED: Incomplete Expired.<br/>
    ///  - STATUS_TRIALING: Trialing.<br/>
    ///  - STATUS_ACTIVE: Active.<br/>
    ///  - STATUS_PAST_DUE: Past due.<br/>
    ///  - STATUS_CANCELED: Canceled.<br/>
    ///  - STATUS_UNPAID: Unpaid.<br/>
    ///  - STATUS_PAUSED: Paused.
    /// </summary>
    public enum StripeSubscriptionDetailStatus
    {
        /// <summary>
        /// Incomplete.
        /// </summary>
        StatusIncomplete,
        /// <summary>
        /// Incomplete Expired.
        /// </summary>
        StatusIncompleteExpired,
        /// <summary>
        /// Trialing.
        /// </summary>
        StatusTrialing,
        /// <summary>
        /// Active.
        /// </summary>
        StatusActive,
        /// <summary>
        /// Past due.
        /// </summary>
        StatusPastDue,
        /// <summary>
        /// Canceled.
        /// </summary>
        StatusCanceled,
        /// <summary>
        /// Unpaid.
        /// </summary>
        StatusUnpaid,
        /// <summary>
        /// Paused.
        /// </summary>
        StatusPaused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StripeSubscriptionDetailStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StripeSubscriptionDetailStatus value)
        {
            return value switch
            {
                StripeSubscriptionDetailStatus.StatusIncomplete => "STATUS_INCOMPLETE",
                StripeSubscriptionDetailStatus.StatusIncompleteExpired => "STATUS_INCOMPLETE_EXPIRED",
                StripeSubscriptionDetailStatus.StatusTrialing => "STATUS_TRIALING",
                StripeSubscriptionDetailStatus.StatusActive => "STATUS_ACTIVE",
                StripeSubscriptionDetailStatus.StatusPastDue => "STATUS_PAST_DUE",
                StripeSubscriptionDetailStatus.StatusCanceled => "STATUS_CANCELED",
                StripeSubscriptionDetailStatus.StatusUnpaid => "STATUS_UNPAID",
                StripeSubscriptionDetailStatus.StatusPaused => "STATUS_PAUSED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StripeSubscriptionDetailStatus? ToEnum(string value)
        {
            return value switch
            {
                "STATUS_INCOMPLETE" => StripeSubscriptionDetailStatus.StatusIncomplete,
                "STATUS_INCOMPLETE_EXPIRED" => StripeSubscriptionDetailStatus.StatusIncompleteExpired,
                "STATUS_TRIALING" => StripeSubscriptionDetailStatus.StatusTrialing,
                "STATUS_ACTIVE" => StripeSubscriptionDetailStatus.StatusActive,
                "STATUS_PAST_DUE" => StripeSubscriptionDetailStatus.StatusPastDue,
                "STATUS_CANCELED" => StripeSubscriptionDetailStatus.StatusCanceled,
                "STATUS_UNPAID" => StripeSubscriptionDetailStatus.StatusUnpaid,
                "STATUS_PAUSED" => StripeSubscriptionDetailStatus.StatusPaused,
                _ => null,
            };
        }
    }
}