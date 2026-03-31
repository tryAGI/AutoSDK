//HintName: G.Models.CreateVideoStreamRequestScriptTextProviderElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVideoStreamRequestScriptTextProviderElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoStreamRequestScriptTextProviderElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoStreamRequestScriptTextProviderElevenLabsType value)
        {
            return value switch
            {
                CreateVideoStreamRequestScriptTextProviderElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoStreamRequestScriptTextProviderElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => CreateVideoStreamRequestScriptTextProviderElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}