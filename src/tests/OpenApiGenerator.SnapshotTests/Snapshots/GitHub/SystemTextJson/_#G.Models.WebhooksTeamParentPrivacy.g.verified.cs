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
    public static class WebhooksTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeamParentPrivacy value)
        {
            return value switch
            {
                WebhooksTeamParentPrivacy.Open => "open",
                WebhooksTeamParentPrivacy.Closed => "closed",
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
                "open" => WebhooksTeamParentPrivacy.Open,
                "closed" => WebhooksTeamParentPrivacy.Closed,
                "secret" => WebhooksTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}