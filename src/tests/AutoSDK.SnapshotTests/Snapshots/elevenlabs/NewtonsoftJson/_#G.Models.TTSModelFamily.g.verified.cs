//HintName: G.Models.TTSModelFamily.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TTSModelFamily
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flash")]
        Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="multilingual")]
        Multilingual,
        /// <summary>
        /// Deprecated: Use flash instead.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="turbo")]
        Turbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="v3_conversational")]
        V3Conversational,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSModelFamilyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSModelFamily value)
        {
            return value switch
            {
                TTSModelFamily.Flash => "flash",
                TTSModelFamily.Multilingual => "multilingual",
                TTSModelFamily.Turbo => "turbo",
                TTSModelFamily.V3Conversational => "v3_conversational",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSModelFamily? ToEnum(string value)
        {
            return value switch
            {
                "flash" => TTSModelFamily.Flash,
                "multilingual" => TTSModelFamily.Multilingual,
                "turbo" => TTSModelFamily.Turbo,
                "v3_conversational" => TTSModelFamily.V3Conversational,
                _ => null,
            };
        }
    }
}