//HintName: G.Models.UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType value)
        {
            return value switch
            {
                UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => UnifiedCreateVideoStreamRequestScriptTextProviderElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}