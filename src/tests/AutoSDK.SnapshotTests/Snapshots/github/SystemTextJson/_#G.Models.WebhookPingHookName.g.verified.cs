//HintName: G.Models.WebhookPingHookName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of webhook. The only valid value is 'web'.
    /// </summary>
    public enum WebhookPingHookName
    {
        /// <summary>
        /// 
        /// </summary>
        Web,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPingHookNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPingHookName value)
        {
            return value switch
            {
                WebhookPingHookName.Web => "web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPingHookName? ToEnum(string value)
        {
            return value switch
            {
                "web" => WebhookPingHookName.Web,
                _ => null,
            };
        }
    }
}