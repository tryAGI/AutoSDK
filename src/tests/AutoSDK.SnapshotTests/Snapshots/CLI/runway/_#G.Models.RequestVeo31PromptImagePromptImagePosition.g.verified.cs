//HintName: G.Models.RequestVeo31PromptImagePromptImagePosition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame of the video, "last" will use the image as the last frame of the video.
    /// </summary>
    public enum RequestVeo31PromptImagePromptImagePosition
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
    public static class RequestVeo31PromptImagePromptImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVeo31PromptImagePromptImagePosition value)
        {
            return value switch
            {
                RequestVeo31PromptImagePromptImagePosition.First => "first",
                RequestVeo31PromptImagePromptImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVeo31PromptImagePromptImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => RequestVeo31PromptImagePromptImagePosition.First,
                "last" => RequestVeo31PromptImagePromptImagePosition.Last,
                _ => null,
            };
        }
    }
}