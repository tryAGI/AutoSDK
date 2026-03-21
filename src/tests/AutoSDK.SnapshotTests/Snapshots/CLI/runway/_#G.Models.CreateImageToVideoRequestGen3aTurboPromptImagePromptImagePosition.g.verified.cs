//HintName: G.Models.CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePosition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame of the video, "last" will use the image as the last frame of the video.
    /// </summary>
    public enum CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePosition
    {
        /// <summary>
        /// 
        /// </summary>
        First,
        /// <summary>
        /// 
        /// </summary>
        Last,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePosition value)
        {
            return value switch
            {
                CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePosition.First => "first",
                CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePosition.First,
                "last" => CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePosition.Last,
                _ => null,
            };
        }
    }
}