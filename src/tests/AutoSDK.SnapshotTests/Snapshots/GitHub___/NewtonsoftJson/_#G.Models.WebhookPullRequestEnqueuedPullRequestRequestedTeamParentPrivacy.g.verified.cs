//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestEnqueuedPullRequestRequestedTeamParentPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestEnqueuedPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestEnqueuedPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestEnqueuedPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestEnqueuedPullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestEnqueuedPullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestEnqueuedPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}