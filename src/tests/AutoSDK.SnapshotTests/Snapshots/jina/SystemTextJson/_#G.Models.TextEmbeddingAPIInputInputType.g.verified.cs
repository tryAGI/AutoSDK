//HintName: G.Models.TextEmbeddingAPIInputInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the embedding to compute, query or document<br/>
    /// Default Value: document
    /// </summary>
    public enum TextEmbeddingAPIInputInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEmbeddingAPIInputInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbeddingAPIInputInputType value)
        {
            return value switch
            {
                TextEmbeddingAPIInputInputType.Document => "document",
                TextEmbeddingAPIInputInputType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbeddingAPIInputInputType? ToEnum(string value)
        {
            return value switch
            {
                "document" => TextEmbeddingAPIInputInputType.Document,
                "query" => TextEmbeddingAPIInputInputType.Query,
                _ => null,
            };
        }
    }
}