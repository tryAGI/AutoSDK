//HintName: G.Models.TextEmbeddingInputEmbeddingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextEmbeddingInputEmbeddingType
    {
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
        Float,
        /// <summary>
        /// 
        /// </summary>
        Ubinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEmbeddingInputEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbeddingInputEmbeddingType value)
        {
            return value switch
            {
                TextEmbeddingInputEmbeddingType.Base64 => "base64",
                TextEmbeddingInputEmbeddingType.Binary => "binary",
                TextEmbeddingInputEmbeddingType.Float => "float",
                TextEmbeddingInputEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbeddingInputEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => TextEmbeddingInputEmbeddingType.Base64,
                "binary" => TextEmbeddingInputEmbeddingType.Binary,
                "float" => TextEmbeddingInputEmbeddingType.Float,
                "ubinary" => TextEmbeddingInputEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}