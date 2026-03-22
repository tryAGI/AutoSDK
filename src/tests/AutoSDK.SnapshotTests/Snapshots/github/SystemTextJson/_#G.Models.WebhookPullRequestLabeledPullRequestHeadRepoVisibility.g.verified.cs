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
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
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
                WebhookPullRequestLabeledPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestLabeledPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestLabeledPullRequestHeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestLabeledPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestLabeledPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestLabeledPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}