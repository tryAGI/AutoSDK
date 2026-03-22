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
    public static class WebhookPullRequestEnqueuedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.Public => "public",
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
                "internal" => WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestEnqueuedPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}