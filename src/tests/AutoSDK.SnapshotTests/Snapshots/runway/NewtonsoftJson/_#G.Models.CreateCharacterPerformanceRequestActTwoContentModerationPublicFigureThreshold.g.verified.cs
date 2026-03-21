//HintName: G.Models.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold
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
    public static class CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold.Auto => "auto",
                CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold.Auto,
                "low" => CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}