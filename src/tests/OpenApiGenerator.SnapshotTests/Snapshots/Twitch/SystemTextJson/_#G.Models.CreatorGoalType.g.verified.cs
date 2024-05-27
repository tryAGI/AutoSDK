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
    public abstract class CreatorGoalType
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Follower = "follower";
        /// <summary>
        /// 
        /// </summary>
        public const string Subscription = "subscription";
        /// <summary>
        /// 
        /// </summary>
        public const string SubscriptionCount = "subscription_count";
        /// <summary>
        /// 
        /// </summary>
        public const string NewSubscription = "new_subscription";
        /// <summary>
        /// 
        /// </summary>
        public const string NewSubscriptionCount = "new_subscription_count";
    }
}