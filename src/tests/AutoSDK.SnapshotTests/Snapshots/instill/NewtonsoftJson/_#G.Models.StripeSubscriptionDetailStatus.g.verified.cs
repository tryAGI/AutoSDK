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
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_INCOMPLETE")]
        STATUSINCOMPLETE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_INCOMPLETE_EXPIRED")]
        STATUSINCOMPLETEEXPIRED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_TRIALING")]
        STATUSTRIALING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_ACTIVE")]
        STATUSACTIVE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_PAST_DUE")]
        STATUSPASTDUE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_CANCELED")]
        STATUSCANCELED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_UNPAID")]
        STATUSUNPAID,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATUS_PAUSED")]
        STATUSPAUSED,
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
                StripeSubscriptionDetailStatus.STATUSINCOMPLETE => "STATUS_INCOMPLETE",
                StripeSubscriptionDetailStatus.STATUSINCOMPLETEEXPIRED => "STATUS_INCOMPLETE_EXPIRED",
                StripeSubscriptionDetailStatus.STATUSTRIALING => "STATUS_TRIALING",
                StripeSubscriptionDetailStatus.STATUSACTIVE => "STATUS_ACTIVE",
                StripeSubscriptionDetailStatus.STATUSPASTDUE => "STATUS_PAST_DUE",
                StripeSubscriptionDetailStatus.STATUSCANCELED => "STATUS_CANCELED",
                StripeSubscriptionDetailStatus.STATUSUNPAID => "STATUS_UNPAID",
                StripeSubscriptionDetailStatus.STATUSPAUSED => "STATUS_PAUSED",
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
                "STATUS_INCOMPLETE" => StripeSubscriptionDetailStatus.STATUSINCOMPLETE,
                "STATUS_INCOMPLETE_EXPIRED" => StripeSubscriptionDetailStatus.STATUSINCOMPLETEEXPIRED,
                "STATUS_TRIALING" => StripeSubscriptionDetailStatus.STATUSTRIALING,
                "STATUS_ACTIVE" => StripeSubscriptionDetailStatus.STATUSACTIVE,
                "STATUS_PAST_DUE" => StripeSubscriptionDetailStatus.STATUSPASTDUE,
                "STATUS_CANCELED" => StripeSubscriptionDetailStatus.STATUSCANCELED,
                "STATUS_UNPAID" => StripeSubscriptionDetailStatus.STATUSUNPAID,
                "STATUS_PAUSED" => StripeSubscriptionDetailStatus.STATUSPAUSED,
                _ => null,
            };
        }
    }
}