//HintName: G.Models.WebhookPullRequestLabeledPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestHeadRepoVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestLabeledPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestLabeledPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestLabeledPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestHeadRepoVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestLabeledPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestLabeledPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestLabeledPullRequestHeadRepoVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}