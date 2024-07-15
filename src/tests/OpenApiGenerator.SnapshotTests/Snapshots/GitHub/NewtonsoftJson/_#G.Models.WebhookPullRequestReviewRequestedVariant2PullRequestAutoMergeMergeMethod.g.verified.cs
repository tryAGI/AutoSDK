//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeMergeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge")]
        Merge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="squash")]
        Squash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rebase")]
        Rebase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeMergeMethod.Squash => "squash",
                WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeMergeMethod.Merge,
                "squash" => WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeMergeMethod.Squash,
                "rebase" => WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}