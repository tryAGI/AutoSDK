//HintName: G.Models.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold
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
    public static class CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold.Auto => "auto",
                CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold.Auto,
                "low" => CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}