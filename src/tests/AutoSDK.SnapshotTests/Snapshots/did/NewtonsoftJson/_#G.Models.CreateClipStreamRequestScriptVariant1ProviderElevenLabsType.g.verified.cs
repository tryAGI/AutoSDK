//HintName: G.Models.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipStreamRequestScriptVariant1ProviderElevenLabsType
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
    public static class CreateClipStreamRequestScriptVariant1ProviderElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestScriptVariant1ProviderElevenLabsType value)
        {
            return value switch
            {
                CreateClipStreamRequestScriptVariant1ProviderElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestScriptVariant1ProviderElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => CreateClipStreamRequestScriptVariant1ProviderElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}