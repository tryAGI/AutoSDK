//HintName: G.Models.WebhookPullRequestAssignedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestAssignedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestAssignedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestAssignedPullRequestBaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestAssignedPullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestAssignedPullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestAssignedPullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}