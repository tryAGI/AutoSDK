//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlabeledPullRequestRequestedTeamsPrivacy
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
    public static class WebhookPullRequestUnlabeledPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestUnlabeledPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestUnlabeledPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestRequestedTeamsPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestUnlabeledPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestUnlabeledPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestUnlabeledPullRequestRequestedTeamsPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}