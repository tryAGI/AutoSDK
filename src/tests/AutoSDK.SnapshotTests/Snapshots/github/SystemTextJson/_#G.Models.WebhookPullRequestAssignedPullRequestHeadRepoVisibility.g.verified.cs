//HintName: G.Models.WebhookPullRequestAssignedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestAssignedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestAssignedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestAssignedPullRequestHeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestAssignedPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestAssignedPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestAssignedPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}