//HintName: G.Models.GetGroupResponseTranslationTranscriptionVersion2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetGroupResponseTranslationTranscriptionVersion2
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
    public static class GetGroupResponseTranslationTranscriptionVersion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetGroupResponseTranslationTranscriptionVersion2 value)
        {
            return value switch
            {
                GetGroupResponseTranslationTranscriptionVersion2.Edit => "edit",
                GetGroupResponseTranslationTranscriptionVersion2.Original => "original",
                GetGroupResponseTranslationTranscriptionVersion2.Shortened => "shortened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetGroupResponseTranslationTranscriptionVersion2? ToEnum(string value)
        {
            return value switch
            {
                "edit" => GetGroupResponseTranslationTranscriptionVersion2.Edit,
                "original" => GetGroupResponseTranslationTranscriptionVersion2.Original,
                "shortened" => GetGroupResponseTranslationTranscriptionVersion2.Shortened,
                _ => null,
            };
        }
    }
}