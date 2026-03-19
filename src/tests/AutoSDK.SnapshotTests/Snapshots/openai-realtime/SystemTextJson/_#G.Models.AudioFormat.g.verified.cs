//HintName: G.Models.AudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of input/output audio.
    /// </summary>
    public enum AudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Pcm16,
        /// <summary>
        /// 
        /// </summary>
        G711Ulaw,
        /// <summary>
        /// 
        /// </summary>
        G711Alaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioFormat value)
        {
            return value switch
            {
                AudioFormat.Pcm16 => "pcm16",
                AudioFormat.G711Ulaw => "g711_ulaw",
                AudioFormat.G711Alaw => "g711_alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm16" => AudioFormat.Pcm16,
                "g711_ulaw" => AudioFormat.G711Ulaw,
                "g711_alaw" => AudioFormat.G711Alaw,
                _ => null,
            };
        }
    }
}