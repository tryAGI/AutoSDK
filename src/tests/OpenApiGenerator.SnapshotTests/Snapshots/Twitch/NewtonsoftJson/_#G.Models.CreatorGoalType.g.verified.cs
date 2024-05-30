//HintName: G.Models.CreatorGoalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of goal. Possible values are:   
    ///   
    /// * follower — The goal is to increase followers.
    /// * subscription — The goal is to increase subscriptions. This type shows the net increase or decrease in tier points associated with the subscriptions.
    /// * subscription\_count — The goal is to increase subscriptions. This type shows the net increase or decrease in the number of subscriptions.
    /// * new\_subscription — The goal is to increase subscriptions. This type shows only the net increase in tier points associated with the subscriptions (it does not account for users that unsubscribed since the goal started).
    /// * new\_subscription\_count — The goal is to increase subscriptions. This type shows only the net increase in the number of subscriptions (it does not account for users that unsubscribed since the goal started).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreatorGoalType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="follower")]
        Follower,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subscription")]
        Subscription,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subscription_count")]
        SubscriptionCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="new_subscription")]
        NewSubscription,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="new_subscription_count")]
        NewSubscriptionCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatorGoalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatorGoalType value)
        {
            return value switch
            {
                CreatorGoalType.Follower => "follower",
                CreatorGoalType.Subscription => "subscription",
                CreatorGoalType.SubscriptionCount => "subscription_count",
                CreatorGoalType.NewSubscription => "new_subscription",
                CreatorGoalType.NewSubscriptionCount => "new_subscription_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatorGoalType ToEnum(string value)
        {
            return value switch
            {
                "follower" => CreatorGoalType.Follower,
                "subscription" => CreatorGoalType.Subscription,
                "subscription_count" => CreatorGoalType.SubscriptionCount,
                "new_subscription" => CreatorGoalType.NewSubscription,
                "new_subscription_count" => CreatorGoalType.NewSubscriptionCount,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}