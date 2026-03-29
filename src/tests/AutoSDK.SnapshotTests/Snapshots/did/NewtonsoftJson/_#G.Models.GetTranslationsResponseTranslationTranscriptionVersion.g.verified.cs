//HintName: G.Models.GetTranslationsResponseTranslationTranscriptionVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTranslationsResponseTranslationTranscriptionVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="edit")]
        Edit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="original")]
        Original,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shortened")]
        Shortened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTranslationsResponseTranslationTranscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTranslationsResponseTranslationTranscriptionVersion value)
        {
            return value switch
            {
                GetTranslationsResponseTranslationTranscriptionVersion.Edit => "edit",
                GetTranslationsResponseTranslationTranscriptionVersion.Original => "original",
                GetTranslationsResponseTranslationTranscriptionVersion.Shortened => "shortened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTranslationsResponseTranslationTranscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "edit" => GetTranslationsResponseTranslationTranscriptionVersion.Edit,
                "original" => GetTranslationsResponseTranslationTranscriptionVersion.Original,
                "shortened" => GetTranslationsResponseTranslationTranscriptionVersion.Shortened,
                _ => null,
            };
        }
    }
}