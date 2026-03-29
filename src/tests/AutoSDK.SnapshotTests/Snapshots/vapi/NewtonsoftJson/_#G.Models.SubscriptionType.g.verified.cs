//HintName: G.Models.SubscriptionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type / tier of the subscription.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SubscriptionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agency")]
        Agency,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enterprise")]
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="growth")]
        Growth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pay-as-you-go")]
        PayAsYouGo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scale")]
        Scale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="startup")]
        Startup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionType value)
        {
            return value switch
            {
                SubscriptionType.Agency => "agency",
                SubscriptionType.Enterprise => "enterprise",
                SubscriptionType.Growth => "growth",
                SubscriptionType.PayAsYouGo => "pay-as-you-go",
                SubscriptionType.Scale => "scale",
                SubscriptionType.Startup => "startup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionType? ToEnum(string value)
        {
            return value switch
            {
                "agency" => SubscriptionType.Agency,
                "enterprise" => SubscriptionType.Enterprise,
                "growth" => SubscriptionType.Growth,
                "pay-as-you-go" => SubscriptionType.PayAsYouGo,
                "scale" => SubscriptionType.Scale,
                "startup" => SubscriptionType.Startup,
                _ => null,
            };
        }
    }
}