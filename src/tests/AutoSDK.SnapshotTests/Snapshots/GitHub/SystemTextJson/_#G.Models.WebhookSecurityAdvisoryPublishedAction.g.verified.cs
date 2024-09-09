//HintName: G.Models.WebhookSecurityAdvisoryPublishedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookSecurityAdvisoryPublishedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecurityAdvisoryPublishedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecurityAdvisoryPublishedAction value)
        {
            return value switch
            {
                WebhookSecurityAdvisoryPublishedAction.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecurityAdvisoryPublishedAction? ToEnum(string value)
        {
            return value switch
            {
                "published" => WebhookSecurityAdvisoryPublishedAction.Published,
                _ => null,
            };
        }
    }
}