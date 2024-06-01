//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsParentPrivacy
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsParentPrivacy.Open => "open",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsParentPrivacy.Closed => "closed",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsParentPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsParentPrivacy.Open,
                "closed" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsParentPrivacy.Closed,
                "secret" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedTeamsParentPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}