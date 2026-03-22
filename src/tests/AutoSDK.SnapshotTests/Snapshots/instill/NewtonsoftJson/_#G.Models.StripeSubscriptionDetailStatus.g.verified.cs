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
    [global::System.Runtime.Serialization.DataContract]
    public enum StripeSubscriptionDetailStatus
    {
        /// <summary>
        /// Active.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_ACTIVE")]
        StatusActive,
        /// <summary>
        /// Canceled.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_CANCELED")]
        StatusCanceled,
        /// <summary>
        /// Incomplete.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_INCOMPLETE")]
        StatusIncomplete,
        /// <summary>
        /// Incomplete Expired.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_INCOMPLETE_EXPIRED")]
        StatusIncompleteExpired,
        /// <summary>
        /// Past due.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_PAST_DUE")]
        StatusPastDue,
        /// <summary>
        /// Paused.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_PAUSED")]
        StatusPaused,
        /// <summary>
        /// Trialing.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_TRIALING")]
        StatusTrialing,
        /// <summary>
        /// Unpaid.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_UNPAID")]
        StatusUnpaid,
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
                StripeSubscriptionDetailStatus.StatusActive => "STATUS_ACTIVE",
                StripeSubscriptionDetailStatus.StatusCanceled => "STATUS_CANCELED",
                StripeSubscriptionDetailStatus.StatusIncomplete => "STATUS_INCOMPLETE",
                StripeSubscriptionDetailStatus.StatusIncompleteExpired => "STATUS_INCOMPLETE_EXPIRED",
                StripeSubscriptionDetailStatus.StatusPastDue => "STATUS_PAST_DUE",
                StripeSubscriptionDetailStatus.StatusPaused => "STATUS_PAUSED",
                StripeSubscriptionDetailStatus.StatusTrialing => "STATUS_TRIALING",
                StripeSubscriptionDetailStatus.StatusUnpaid => "STATUS_UNPAID",
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
                "STATUS_ACTIVE" => StripeSubscriptionDetailStatus.StatusActive,
                "STATUS_CANCELED" => StripeSubscriptionDetailStatus.StatusCanceled,
                "STATUS_INCOMPLETE" => StripeSubscriptionDetailStatus.StatusIncomplete,
                "STATUS_INCOMPLETE_EXPIRED" => StripeSubscriptionDetailStatus.StatusIncompleteExpired,
                "STATUS_PAST_DUE" => StripeSubscriptionDetailStatus.StatusPastDue,
                "STATUS_PAUSED" => StripeSubscriptionDetailStatus.StatusPaused,
                "STATUS_TRIALING" => StripeSubscriptionDetailStatus.StatusTrialing,
                "STATUS_UNPAID" => StripeSubscriptionDetailStatus.StatusUnpaid,
                _ => null,
            };
        }
    }
}