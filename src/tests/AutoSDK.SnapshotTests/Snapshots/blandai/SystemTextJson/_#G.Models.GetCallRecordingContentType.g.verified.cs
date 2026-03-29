//HintName: G.Models.GetCallRecordingContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: audio/wav
    /// </summary>
    public enum GetCallRecordingContentType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioMpeg,
        /// <summary>
        /// 
        /// </summary>
        AudioWav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCallRecordingContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCallRecordingContentType value)
        {
            return value switch
            {
                GetCallRecordingContentType.AudioMpeg => "audio/mpeg",
                GetCallRecordingContentType.AudioWav => "audio/wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCallRecordingContentType? ToEnum(string value)
        {
            return value switch
            {
                "audio/mpeg" => GetCallRecordingContentType.AudioMpeg,
                "audio/wav" => GetCallRecordingContentType.AudioWav,
                _ => null,
            };
        }
    }
}