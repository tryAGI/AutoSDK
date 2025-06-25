//HintName: G.Models.WebhookToolConfigInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool<br/>
    /// Default Value: webhook
    /// </summary>
    public enum WebhookToolConfigInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookToolConfigInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookToolConfigInputType value)
        {
            return value switch
            {
                WebhookToolConfigInputType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookToolConfigInputType? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => WebhookToolConfigInputType.Webhook,
                _ => null,
            };
        }
    }
}