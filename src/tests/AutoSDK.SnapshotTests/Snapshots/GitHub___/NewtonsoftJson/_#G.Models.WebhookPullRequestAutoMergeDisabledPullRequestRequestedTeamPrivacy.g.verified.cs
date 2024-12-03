//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}