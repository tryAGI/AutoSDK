//HintName: G.Models.CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType
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
    public static class CreateTalkStreamRequestScriptVariant1ProviderElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType value)
        {
            return value switch
            {
                CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => CreateTalkStreamRequestScriptVariant1ProviderElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}