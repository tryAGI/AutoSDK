//HintName: G.Models.RequestGen4TurboContentModerationPublicFigureThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequestGen4TurboContentModerationPublicFigureThreshold
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestGen4TurboContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGen4TurboContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                RequestGen4TurboContentModerationPublicFigureThreshold.Auto => "auto",
                RequestGen4TurboContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGen4TurboContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RequestGen4TurboContentModerationPublicFigureThreshold.Auto,
                "low" => RequestGen4TurboContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}