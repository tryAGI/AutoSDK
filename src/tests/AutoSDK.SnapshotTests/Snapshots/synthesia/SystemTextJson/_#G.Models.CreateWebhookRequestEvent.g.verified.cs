//HintName: G.Models.CreateWebhookRequestEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWebhookRequestEvent
    {
        /// <summary>
        /// 
        /// </summary>
        VideoCompleted,
        /// <summary>
        /// 
        /// </summary>
        VideoFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWebhookRequestEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebhookRequestEvent value)
        {
            return value switch
            {
                CreateWebhookRequestEvent.VideoCompleted => "video.completed",
                CreateWebhookRequestEvent.VideoFailed => "video.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebhookRequestEvent? ToEnum(string value)
        {
            return value switch
            {
                "video.completed" => CreateWebhookRequestEvent.VideoCompleted,
                "video.failed" => CreateWebhookRequestEvent.VideoFailed,
                _ => null,
            };
        }
    }
}