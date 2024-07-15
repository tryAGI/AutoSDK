//HintName: G.Models.WebhookPullRequestSynchronizePullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestSynchronizePullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestSynchronizePullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestSynchronizePullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestSynchronizePullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestSynchronizePullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestSynchronizePullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestSynchronizePullRequestBaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}