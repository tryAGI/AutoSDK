//HintName: G.Models.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold
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
    public static class CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold.Auto => "auto",
                CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold.Auto,
                "low" => CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}