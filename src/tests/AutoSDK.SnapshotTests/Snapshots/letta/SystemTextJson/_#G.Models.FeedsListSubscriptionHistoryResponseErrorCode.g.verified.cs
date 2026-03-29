//HintName: G.Models.FeedsListSubscriptionHistoryResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedsListSubscriptionHistoryResponseErrorCode
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
    public static class FeedsListSubscriptionHistoryResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedsListSubscriptionHistoryResponseErrorCode value)
        {
            return value switch
            {
                FeedsListSubscriptionHistoryResponseErrorCode.FeedNotFound => "feedNotFound",
                FeedsListSubscriptionHistoryResponseErrorCode.SubscriptionNotFound => "subscriptionNotFound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedsListSubscriptionHistoryResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "feedNotFound" => FeedsListSubscriptionHistoryResponseErrorCode.FeedNotFound,
                "subscriptionNotFound" => FeedsListSubscriptionHistoryResponseErrorCode.SubscriptionNotFound,
                _ => null,
            };
        }
    }
}