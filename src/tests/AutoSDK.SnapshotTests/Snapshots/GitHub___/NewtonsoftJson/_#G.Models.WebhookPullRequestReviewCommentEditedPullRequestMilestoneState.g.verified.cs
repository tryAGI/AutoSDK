//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentEditedPullRequestMilestoneState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentEditedPullRequestMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestMilestoneState value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestMilestoneState.Open => "open",
                WebhookPullRequestReviewCommentEditedPullRequestMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewCommentEditedPullRequestMilestoneState.Open,
                "closed" => WebhookPullRequestReviewCommentEditedPullRequestMilestoneState.Closed,
                _ => null,
            };
        }
    }
}