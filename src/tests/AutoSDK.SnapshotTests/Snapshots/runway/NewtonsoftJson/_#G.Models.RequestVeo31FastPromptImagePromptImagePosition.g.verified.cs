//HintName: G.Models.RequestVeo31FastPromptImagePromptImagePosition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The position of the image in the output video. "first" will use the image as the first frame of the video, "last" will use the image as the last frame of the video.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequestVeo31FastPromptImagePromptImagePosition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="first")]
        First,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="last")]
        Last,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestVeo31FastPromptImagePromptImagePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVeo31FastPromptImagePromptImagePosition value)
        {
            return value switch
            {
                RequestVeo31FastPromptImagePromptImagePosition.First => "first",
                RequestVeo31FastPromptImagePromptImagePosition.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVeo31FastPromptImagePromptImagePosition? ToEnum(string value)
        {
            return value switch
            {
                "first" => RequestVeo31FastPromptImagePromptImagePosition.First,
                "last" => RequestVeo31FastPromptImagePromptImagePosition.Last,
                _ => null,
            };
        }
    }
}