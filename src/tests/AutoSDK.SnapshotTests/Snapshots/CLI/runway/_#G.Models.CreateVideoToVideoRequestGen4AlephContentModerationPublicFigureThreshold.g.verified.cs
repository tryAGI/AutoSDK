//HintName: G.Models.CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThreshold
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
    public static class CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThreshold.Auto => "auto",
                CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThreshold.Auto,
                "low" => CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}