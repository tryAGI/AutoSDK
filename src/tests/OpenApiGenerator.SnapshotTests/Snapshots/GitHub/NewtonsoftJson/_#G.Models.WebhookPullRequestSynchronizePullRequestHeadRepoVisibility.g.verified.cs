//HintName: G.Models.WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestSynchronizePullRequestHeadRepoVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal")]
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestSynchronizePullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}