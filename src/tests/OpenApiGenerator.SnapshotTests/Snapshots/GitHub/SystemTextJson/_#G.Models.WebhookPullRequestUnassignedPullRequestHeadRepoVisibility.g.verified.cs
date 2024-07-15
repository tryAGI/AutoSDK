//HintName: G.Models.WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestUnassignedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}