//HintName: G.Models.WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlockedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestUnlockedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestBaseRepoVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}