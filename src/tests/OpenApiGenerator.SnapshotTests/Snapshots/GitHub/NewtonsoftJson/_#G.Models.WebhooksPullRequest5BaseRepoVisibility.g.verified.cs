//HintName: G.Models.WebhooksPullRequest5BaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5BaseRepoVisibility
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
    public static class WebhooksPullRequest5BaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5BaseRepoVisibility value)
        {
            return value switch
            {
                WebhooksPullRequest5BaseRepoVisibility.Public => "public",
                WebhooksPullRequest5BaseRepoVisibility.Private => "private",
                WebhooksPullRequest5BaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5BaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhooksPullRequest5BaseRepoVisibility.Public,
                "private" => WebhooksPullRequest5BaseRepoVisibility.Private,
                "internal" => WebhooksPullRequest5BaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}