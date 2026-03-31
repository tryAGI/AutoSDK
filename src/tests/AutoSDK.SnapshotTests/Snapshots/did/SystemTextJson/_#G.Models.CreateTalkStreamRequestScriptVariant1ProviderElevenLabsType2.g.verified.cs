//HintName: G.Models.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType2
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType2 value)
        {
            return value switch
            {
                CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType2.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType2? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType2.Elevenlabs,
                _ => null,
            };
        }
    }
}