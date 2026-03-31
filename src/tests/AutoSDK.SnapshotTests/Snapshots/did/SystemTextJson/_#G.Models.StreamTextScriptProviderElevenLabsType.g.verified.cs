//HintName: G.Models.StreamTextScriptProviderElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamTextScriptProviderElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamTextScriptProviderElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamTextScriptProviderElevenLabsType value)
        {
            return value switch
            {
                StreamTextScriptProviderElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamTextScriptProviderElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => StreamTextScriptProviderElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}