//HintName: G.Models.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipStreamRequestScriptVariant1ProviderElevenLabsType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateClipStreamRequestScriptVariant1ProviderElevenLabsType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestScriptVariant1ProviderElevenLabsType2 value)
        {
            return value switch
            {
                CreateClipStreamRequestScriptVariant1ProviderElevenLabsType2.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestScriptVariant1ProviderElevenLabsType2? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => CreateClipStreamRequestScriptVariant1ProviderElevenLabsType2.Elevenlabs,
                _ => null,
            };
        }
    }
}