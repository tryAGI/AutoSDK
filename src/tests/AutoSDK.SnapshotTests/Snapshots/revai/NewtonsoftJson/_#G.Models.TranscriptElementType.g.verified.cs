//HintName: G.Models.TranscriptElementType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of element
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptElementType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="punct")]
        Punct,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptElementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptElementType value)
        {
            return value switch
            {
                TranscriptElementType.Punct => "punct",
                TranscriptElementType.Text => "text",
                TranscriptElementType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptElementType? ToEnum(string value)
        {
            return value switch
            {
                "punct" => TranscriptElementType.Punct,
                "text" => TranscriptElementType.Text,
                "unknown" => TranscriptElementType.Unknown,
                _ => null,
            };
        }
    }
}