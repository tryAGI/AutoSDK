//HintName: G.Models.ScriptVariant1ProviderElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScriptVariant1ProviderElevenLabsType
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
    public static class ScriptVariant1ProviderElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScriptVariant1ProviderElevenLabsType value)
        {
            return value switch
            {
                ScriptVariant1ProviderElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScriptVariant1ProviderElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => ScriptVariant1ProviderElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}