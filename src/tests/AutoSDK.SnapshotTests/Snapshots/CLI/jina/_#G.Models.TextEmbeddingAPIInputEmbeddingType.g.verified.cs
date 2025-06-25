//HintName: G.Models.TextEmbeddingAPIInputEmbeddingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextEmbeddingAPIInputEmbeddingType
    {
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Binary,
        /// <summary>
        /// 
        /// </summary>
        Ubinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEmbeddingAPIInputEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbeddingAPIInputEmbeddingType value)
        {
            return value switch
            {
                TextEmbeddingAPIInputEmbeddingType.Float => "float",
                TextEmbeddingAPIInputEmbeddingType.Base64 => "base64",
                TextEmbeddingAPIInputEmbeddingType.Binary => "binary",
                TextEmbeddingAPIInputEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbeddingAPIInputEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "float" => TextEmbeddingAPIInputEmbeddingType.Float,
                "base64" => TextEmbeddingAPIInputEmbeddingType.Base64,
                "binary" => TextEmbeddingAPIInputEmbeddingType.Binary,
                "ubinary" => TextEmbeddingAPIInputEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}