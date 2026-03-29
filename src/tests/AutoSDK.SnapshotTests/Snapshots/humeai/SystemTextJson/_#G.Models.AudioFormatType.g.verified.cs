//HintName: G.Models.AudioFormatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioFormatType value)
        {
            return value switch
            {
                AudioFormatType.Mp3 => "mp3",
                AudioFormatType.Pcm => "pcm",
                AudioFormatType.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioFormatType? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => AudioFormatType.Mp3,
                "pcm" => AudioFormatType.Pcm,
                "wav" => AudioFormatType.Wav,
                _ => null,
            };
        }
    }
}