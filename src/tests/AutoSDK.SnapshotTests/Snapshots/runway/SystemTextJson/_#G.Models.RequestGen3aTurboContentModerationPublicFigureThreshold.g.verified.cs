//HintName: G.Models.RequestGen3aTurboContentModerationPublicFigureThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    public enum RequestGen3aTurboContentModerationPublicFigureThreshold
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
    public static class RequestGen3aTurboContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGen3aTurboContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                RequestGen3aTurboContentModerationPublicFigureThreshold.Auto => "auto",
                RequestGen3aTurboContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGen3aTurboContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RequestGen3aTurboContentModerationPublicFigureThreshold.Auto,
                "low" => RequestGen3aTurboContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}