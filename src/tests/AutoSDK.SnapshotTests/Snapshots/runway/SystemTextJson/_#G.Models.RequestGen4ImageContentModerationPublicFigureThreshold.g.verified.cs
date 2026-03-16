//HintName: G.Models.RequestGen4ImageContentModerationPublicFigureThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum RequestGen4ImageContentModerationPublicFigureThreshold
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestGen4ImageContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGen4ImageContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                RequestGen4ImageContentModerationPublicFigureThreshold.Auto => "auto",
                RequestGen4ImageContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGen4ImageContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RequestGen4ImageContentModerationPublicFigureThreshold.Auto,
                "low" => RequestGen4ImageContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}