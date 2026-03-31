//HintName: G.Models.StreamAudioScriptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    public enum StreamAudioScriptType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamAudioScriptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamAudioScriptType value)
        {
            return value switch
            {
                StreamAudioScriptType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamAudioScriptType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => StreamAudioScriptType.Audio,
                _ => null,
            };
        }
    }
}