//HintName: G.Models.CreateResponseTranslationTranscriptionVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateResponseTranslationTranscriptionVersion
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
    public static class CreateResponseTranslationTranscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseTranslationTranscriptionVersion value)
        {
            return value switch
            {
                CreateResponseTranslationTranscriptionVersion.Edit => "edit",
                CreateResponseTranslationTranscriptionVersion.Original => "original",
                CreateResponseTranslationTranscriptionVersion.Shortened => "shortened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseTranslationTranscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "edit" => CreateResponseTranslationTranscriptionVersion.Edit,
                "original" => CreateResponseTranslationTranscriptionVersion.Original,
                "shortened" => CreateResponseTranslationTranscriptionVersion.Shortened,
                _ => null,
            };
        }
    }
}