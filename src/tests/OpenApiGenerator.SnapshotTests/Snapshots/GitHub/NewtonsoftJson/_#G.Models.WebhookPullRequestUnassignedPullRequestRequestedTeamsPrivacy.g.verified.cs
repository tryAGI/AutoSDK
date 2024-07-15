//HintName: G.Models.WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy
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
    public static class WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestUnassignedPullRequestRequestedTeamsPrivacy.Secret,
                _ => null,
            };
        }
    }
}