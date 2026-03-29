//HintName: G.Models.TranscriptionVersion2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptionVersion2
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
    public static class TranscriptionVersion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionVersion2 value)
        {
            return value switch
            {
                TranscriptionVersion2.Edit => "edit",
                TranscriptionVersion2.Original => "original",
                TranscriptionVersion2.Shortened => "shortened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionVersion2? ToEnum(string value)
        {
            return value switch
            {
                "edit" => TranscriptionVersion2.Edit,
                "original" => TranscriptionVersion2.Original,
                "shortened" => TranscriptionVersion2.Shortened,
                _ => null,
            };
        }
    }
}