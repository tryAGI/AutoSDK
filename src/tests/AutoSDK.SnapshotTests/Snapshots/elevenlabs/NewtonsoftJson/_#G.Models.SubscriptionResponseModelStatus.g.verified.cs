//HintName: G.Models.SubscriptionResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the user's subscription.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SubscriptionResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trialing")]
        Trialing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="incomplete")]
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="incomplete_expired")]
        IncompleteExpired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="past_due")]
        PastDue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="canceled")]
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unpaid")]
        Unpaid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="free")]
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