//HintName: G.Models.CreateImageToVideoRequestVeo31PromptImagePromptImagePosition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame of the video, "last" will use the image as the last frame of the video.
    /// </summary>
    public enum CreateImageToVideoRequestVeo31PromptImagePromptImagePosition
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
    public static class CreateImageToVideoRequestVeo31PromptImagePromptImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestVeo31PromptImagePromptImagePosition value)
        {
            return value switch
            {
                CreateImageToVideoRequestVeo31PromptImagePromptImagePosition.First => "first",
                CreateImageToVideoRequestVeo31PromptImagePromptImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestVeo31PromptImagePromptImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateImageToVideoRequestVeo31PromptImagePromptImagePosition.First,
                "last" => CreateImageToVideoRequestVeo31PromptImagePromptImagePosition.Last,
                _ => null,
            };
        }
    }
}