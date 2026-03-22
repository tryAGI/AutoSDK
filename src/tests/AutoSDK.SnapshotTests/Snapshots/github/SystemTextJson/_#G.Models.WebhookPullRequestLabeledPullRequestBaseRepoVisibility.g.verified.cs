//HintName: G.Models.WebhookPullRequestLabeledPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestLabeledPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestLabeledPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestLabeledPullRequestBaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestLabeledPullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestLabeledPullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestLabeledPullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}