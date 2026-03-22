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
    public static class WebhookPullRequestUnassignedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.Public => "public",
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
                "internal" => WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestUnassignedPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}