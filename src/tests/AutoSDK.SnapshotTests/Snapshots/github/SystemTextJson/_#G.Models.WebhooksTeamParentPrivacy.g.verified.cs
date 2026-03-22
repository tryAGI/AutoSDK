//HintName: G.Models.WebhooksTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksTeamParentPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeamParentPrivacy value)
        {
            return value switch
            {
                WebhooksTeamParentPrivacy.Closed => "closed",
                WebhooksTeamParentPrivacy.Open => "open",
                WebhooksTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhooksTeamParentPrivacy.Closed,
                "open" => WebhooksTeamParentPrivacy.Open,
                "secret" => WebhooksTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}