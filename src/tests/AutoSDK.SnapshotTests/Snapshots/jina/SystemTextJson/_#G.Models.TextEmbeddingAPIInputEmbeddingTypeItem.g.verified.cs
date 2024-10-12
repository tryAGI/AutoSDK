//HintName: G.Models.TextEmbeddingAPIInputEmbeddingTypeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextEmbeddingAPIInputEmbeddingTypeItem
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
    public static class TextEmbeddingAPIInputEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbeddingAPIInputEmbeddingTypeItem value)
        {
            return value switch
            {
                TextEmbeddingAPIInputEmbeddingTypeItem.Float => "float",
                TextEmbeddingAPIInputEmbeddingTypeItem.Base64 => "base64",
                TextEmbeddingAPIInputEmbeddingTypeItem.Binary => "binary",
                TextEmbeddingAPIInputEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbeddingAPIInputEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "float" => TextEmbeddingAPIInputEmbeddingTypeItem.Float,
                "base64" => TextEmbeddingAPIInputEmbeddingTypeItem.Base64,
                "binary" => TextEmbeddingAPIInputEmbeddingTypeItem.Binary,
                "ubinary" => TextEmbeddingAPIInputEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}