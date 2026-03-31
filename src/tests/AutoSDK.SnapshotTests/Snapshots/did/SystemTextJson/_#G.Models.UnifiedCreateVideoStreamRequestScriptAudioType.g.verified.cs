//HintName: G.Models.UnifiedCreateVideoStreamRequestScriptAudioType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    public enum UnifiedCreateVideoStreamRequestScriptAudioType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedCreateVideoStreamRequestScriptAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedCreateVideoStreamRequestScriptAudioType value)
        {
            return value switch
            {
                UnifiedCreateVideoStreamRequestScriptAudioType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedCreateVideoStreamRequestScriptAudioType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => UnifiedCreateVideoStreamRequestScriptAudioType.Audio,
                _ => null,
            };
        }
    }
}