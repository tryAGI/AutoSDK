//HintName: G.Models.FeedsBackfillSubscriptionResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedsBackfillSubscriptionResponseErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        FeedNotFound,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedsBackfillSubscriptionResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedsBackfillSubscriptionResponseErrorCode value)
        {
            return value switch
            {
                FeedsBackfillSubscriptionResponseErrorCode.FeedNotFound => "feedNotFound",
                FeedsBackfillSubscriptionResponseErrorCode.SubscriptionNotFound => "subscriptionNotFound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedsBackfillSubscriptionResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "feedNotFound" => FeedsBackfillSubscriptionResponseErrorCode.FeedNotFound,
                "subscriptionNotFound" => FeedsBackfillSubscriptionResponseErrorCode.SubscriptionNotFound,
                _ => null,
            };
        }
    }
}