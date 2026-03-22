//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestUnlabeledPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}