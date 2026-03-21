//HintName: G.Models.CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When set to `low`, the content moderation system will be less strict about preventing generations that include recognizable public figures.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThreshold
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
    public static class CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThreshold value)
        {
            return value switch
            {
                CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThreshold.Auto => "auto",
                CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThreshold.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThreshold? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThreshold.Auto,
                "low" => CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThreshold.Low,
                _ => null,
            };
        }
    }
}