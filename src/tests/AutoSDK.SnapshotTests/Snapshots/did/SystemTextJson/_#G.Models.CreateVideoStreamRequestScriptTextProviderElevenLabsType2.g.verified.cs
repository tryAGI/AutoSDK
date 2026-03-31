//HintName: G.Models.CreateVideoStreamRequestScriptTextProviderElevenLabsType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVideoStreamRequestScriptTextProviderElevenLabsType2
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoStreamRequestScriptTextProviderElevenLabsType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoStreamRequestScriptTextProviderElevenLabsType2 value)
        {
            return value switch
            {
                CreateVideoStreamRequestScriptTextProviderElevenLabsType2.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoStreamRequestScriptTextProviderElevenLabsType2? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => CreateVideoStreamRequestScriptTextProviderElevenLabsType2.Elevenlabs,
                _ => null,
            };
        }
    }
}