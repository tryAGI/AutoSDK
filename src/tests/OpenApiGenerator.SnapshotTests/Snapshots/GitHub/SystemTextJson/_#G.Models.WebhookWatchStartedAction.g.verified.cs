//HintName: G.Models.WebhookWatchStartedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWatchStartedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWatchStartedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWatchStartedAction value)
        {
            return value switch
            {
                WebhookWatchStartedAction.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWatchStartedAction ToEnum(string value)
        {
            return value switch
            {
                "started" => WebhookWatchStartedAction.Started,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}