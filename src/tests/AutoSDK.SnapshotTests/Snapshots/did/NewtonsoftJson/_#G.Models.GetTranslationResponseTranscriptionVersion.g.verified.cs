//HintName: G.Models.GetTranslationResponseTranscriptionVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTranslationResponseTranscriptionVersion
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
    public static class GetTranslationResponseTranscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTranslationResponseTranscriptionVersion value)
        {
            return value switch
            {
                GetTranslationResponseTranscriptionVersion.Edit => "edit",
                GetTranslationResponseTranscriptionVersion.Original => "original",
                GetTranslationResponseTranscriptionVersion.Shortened => "shortened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTranslationResponseTranscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "edit" => GetTranslationResponseTranscriptionVersion.Edit,
                "original" => GetTranslationResponseTranscriptionVersion.Original,
                "shortened" => GetTranslationResponseTranscriptionVersion.Shortened,
                _ => null,
            };
        }
    }
}