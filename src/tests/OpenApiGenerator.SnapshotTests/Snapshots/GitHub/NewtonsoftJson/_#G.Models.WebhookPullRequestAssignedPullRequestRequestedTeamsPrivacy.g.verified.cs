//HintName: G.Models.WebhookPullRequestAssignedPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAssignedPullRequestRequestedTeamsPrivacy
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
    public static class WebhookPullRequestAssignedPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestAssignedPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestAssignedPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestRequestedTeamsPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestAssignedPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestAssignedPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestAssignedPullRequestRequestedTeamsPrivacy.Secret,
                _ => null,
            };
        }
    }
}