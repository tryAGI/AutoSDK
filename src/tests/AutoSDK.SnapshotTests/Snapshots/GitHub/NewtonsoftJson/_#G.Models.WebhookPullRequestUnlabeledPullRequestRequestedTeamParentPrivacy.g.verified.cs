//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlabeledPullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestUnlabeledPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestUnlabeledPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestUnlabeledPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestUnlabeledPullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestUnlabeledPullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestUnlabeledPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}