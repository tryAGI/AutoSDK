//HintName: G.Models.TextChunkType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: text
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextChunkType value)
        {
            return value switch
            {
                TextChunkType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextChunkType? ToEnum(string value)
        {
            return value switch
            {
                "text" => TextChunkType.Text,
                _ => null,
            };
        }
    }
}