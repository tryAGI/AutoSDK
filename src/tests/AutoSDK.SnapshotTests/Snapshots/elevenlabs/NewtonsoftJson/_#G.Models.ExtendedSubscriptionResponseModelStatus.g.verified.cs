//HintName: G.Models.ExtendedSubscriptionResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtendedSubscriptionResponseModelStatus
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