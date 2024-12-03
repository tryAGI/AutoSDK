//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}