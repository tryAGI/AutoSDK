//HintName: G.Models.WebhookCheckRunRequestedActionAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckRunRequestedActionAction
    {
        /// <summary>
        /// 
        /// </summary>
        RequestedAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckRunRequestedActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckRunRequestedActionAction value)
        {
            return value switch
            {
                WebhookCheckRunRequestedActionAction.RequestedAction => "requested_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckRunRequestedActionAction ToEnum(string value)
        {
            return value switch
            {
                "requested_action" => WebhookCheckRunRequestedActionAction.RequestedAction,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}