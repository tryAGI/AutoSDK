//HintName: G.Models.RequestGen3aTurboPromptImagePromptImagePosition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame of the video, "last" will use the image as the last frame of the video.
    /// </summary>
    public enum RequestGen3aTurboPromptImagePromptImagePosition
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
    public static class RequestGen3aTurboPromptImagePromptImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGen3aTurboPromptImagePromptImagePosition value)
        {
            return value switch
            {
                RequestGen3aTurboPromptImagePromptImagePosition.First => "first",
                RequestGen3aTurboPromptImagePromptImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGen3aTurboPromptImagePromptImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => RequestGen3aTurboPromptImagePromptImagePosition.First,
                "last" => RequestGen3aTurboPromptImagePromptImagePosition.Last,
                _ => null,
            };
        }
    }
}