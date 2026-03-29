//HintName: G.Models.SubscriptionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type / tier of the subscription.
    /// </summary>
    public enum SubscriptionType
    {
        /// <summary>
        /// 
        /// </summary>
        Agency,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Growth,
        /// <summary>
        /// 
        /// </summary>
        PayAsYouGo,
        /// <summary>
        /// 
        /// </summary>
        Scale,
        /// <summary>
        /// 
        /// </summary>
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