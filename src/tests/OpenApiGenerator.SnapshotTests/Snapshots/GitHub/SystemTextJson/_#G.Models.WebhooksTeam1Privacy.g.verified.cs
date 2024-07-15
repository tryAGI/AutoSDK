//HintName: G.Models.WebhooksTeam1Privacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksTeam1Privacy
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
    public static class WebhooksTeam1PrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeam1Privacy value)
        {
            return value switch
            {
                WebhooksTeam1Privacy.Open => "open",
                WebhooksTeam1Privacy.Closed => "closed",
                WebhooksTeam1Privacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksTeam1Privacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksTeam1Privacy.Open,
                "closed" => WebhooksTeam1Privacy.Closed,
                "secret" => WebhooksTeam1Privacy.Secret,
                _ => null,
            };
        }
    }
}