//HintName: G.Models.WebhookPullRequestUnassignedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestUnassignedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestUnassignedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestUnassignedPullRequestBaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestUnassignedPullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestUnassignedPullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestUnassignedPullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}