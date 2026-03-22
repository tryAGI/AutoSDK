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
        [global::System.Runtime.Serialization.EnumMember(Value="internal")]
        Internal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
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
                WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}