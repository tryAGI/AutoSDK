//HintName: G.Models.DocumentChunkMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How to chunk documents.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DocumentChunkMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PAGE")]
        Page,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SECTION")]
        Section,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentChunkModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentChunkMode value)
        {
            return value switch
            {
                DocumentChunkMode.Page => "PAGE",
                DocumentChunkMode.Section => "SECTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentChunkMode? ToEnum(string value)
        {
            return value switch
            {
                "PAGE" => DocumentChunkMode.Page,
                "SECTION" => DocumentChunkMode.Section,
                _ => null,
            };
        }
    }
}