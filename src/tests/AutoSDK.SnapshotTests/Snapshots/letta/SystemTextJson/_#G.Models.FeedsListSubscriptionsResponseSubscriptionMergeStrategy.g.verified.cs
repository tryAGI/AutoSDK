//HintName: G.Models.FeedsListSubscriptionsResponseSubscriptionMergeStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedsListSubscriptionsResponseSubscriptionMergeStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        CombineIntoSingleMessage,
        /// <summary>
        /// 
        /// </summary>
        UniqueMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedsListSubscriptionsResponseSubscriptionMergeStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedsListSubscriptionsResponseSubscriptionMergeStrategy value)
        {
            return value switch
            {
                FeedsListSubscriptionsResponseSubscriptionMergeStrategy.CombineIntoSingleMessage => "combine-into-single-message",
                FeedsListSubscriptionsResponseSubscriptionMergeStrategy.UniqueMessages => "unique-messages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedsListSubscriptionsResponseSubscriptionMergeStrategy? ToEnum(string value)
        {
            return value switch
            {
                "combine-into-single-message" => FeedsListSubscriptionsResponseSubscriptionMergeStrategy.CombineIntoSingleMessage,
                "unique-messages" => FeedsListSubscriptionsResponseSubscriptionMergeStrategy.UniqueMessages,
                _ => null,
            };
        }
    }
}