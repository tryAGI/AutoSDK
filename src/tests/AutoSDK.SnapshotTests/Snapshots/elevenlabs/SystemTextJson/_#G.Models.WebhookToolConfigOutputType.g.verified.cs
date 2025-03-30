//HintName: G.Models.WebhookToolConfigOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool<br/>
    /// Default Value: webhook
    /// </summary>
    public enum WebhookToolConfigOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookToolConfigOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookToolConfigOutputType value)
        {
            return value switch
            {
                WebhookToolConfigOutputType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookToolConfigOutputType? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => WebhookToolConfigOutputType.Webhook,
                _ => null,
            };
        }
    }
}