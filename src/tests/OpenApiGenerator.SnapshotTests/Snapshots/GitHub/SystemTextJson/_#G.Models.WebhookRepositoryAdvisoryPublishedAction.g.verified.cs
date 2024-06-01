//HintName: G.Models.WebhookRepositoryAdvisoryPublishedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookRepositoryAdvisoryPublishedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRepositoryAdvisoryPublishedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRepositoryAdvisoryPublishedAction value)
        {
            return value switch
            {
                WebhookRepositoryAdvisoryPublishedAction.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRepositoryAdvisoryPublishedAction ToEnum(string value)
        {
            return value switch
            {
                "published" => WebhookRepositoryAdvisoryPublishedAction.Published,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}