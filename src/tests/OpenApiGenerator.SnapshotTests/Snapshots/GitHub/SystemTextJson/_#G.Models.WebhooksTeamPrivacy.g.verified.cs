//HintName: G.Models.WebhooksTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksTeamPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeamPrivacy value)
        {
            return value switch
            {
                WebhooksTeamPrivacy.Open => "open",
                WebhooksTeamPrivacy.Closed => "closed",
                WebhooksTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksTeamPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksTeamPrivacy.Open,
                "closed" => WebhooksTeamPrivacy.Closed,
                "secret" => WebhooksTeamPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}