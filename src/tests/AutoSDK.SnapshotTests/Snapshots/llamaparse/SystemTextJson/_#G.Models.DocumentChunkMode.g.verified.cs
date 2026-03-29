//HintName: G.Models.DocumentChunkMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How to chunk documents.
    /// </summary>
    public enum DocumentChunkMode
    {
        /// <summary>
        /// 
        /// </summary>
        Page,
        /// <summary>
        /// 
        /// </summary>
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