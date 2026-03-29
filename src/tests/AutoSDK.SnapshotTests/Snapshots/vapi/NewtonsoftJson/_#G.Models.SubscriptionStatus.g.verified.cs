//HintName: G.Models.SubscriptionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the subscription. Past due subscriptions are subscriptions<br/>
    /// with past due payments.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SubscriptionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="frozen")]
        Frozen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionStatus value)
        {
            return value switch
            {
                SubscriptionStatus.Active => "active",
                SubscriptionStatus.Frozen => "frozen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionStatus.Active,
                "frozen" => SubscriptionStatus.Frozen,
                _ => null,
            };
        }
    }
}