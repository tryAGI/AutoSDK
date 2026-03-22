//HintName: G.Models.WebhooksPullRequest5HeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5HeadRepoVisibility
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
    public static class WebhooksPullRequest5HeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5HeadRepoVisibility value)
        {
            return value switch
            {
                WebhooksPullRequest5HeadRepoVisibility.Internal => "internal",
                WebhooksPullRequest5HeadRepoVisibility.Private => "private",
                WebhooksPullRequest5HeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5HeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhooksPullRequest5HeadRepoVisibility.Internal,
                "private" => WebhooksPullRequest5HeadRepoVisibility.Private,
                "public" => WebhooksPullRequest5HeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}