//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestEnqueuedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}