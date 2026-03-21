//HintName: G.Models.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold
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
    public static class CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold.Auto => "auto",
                CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold.Auto,
                "low" => CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}