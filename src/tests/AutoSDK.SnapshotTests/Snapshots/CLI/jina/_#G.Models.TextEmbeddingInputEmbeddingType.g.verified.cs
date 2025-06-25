﻿//HintName: G.Models.TextEmbeddingInputEmbeddingType.g.cs

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
    public static class TextEmbeddingInputEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbeddingInputEmbeddingType value)
        {
            return value switch
            {
                TextEmbeddingInputEmbeddingType.Float => "float",
                TextEmbeddingInputEmbeddingType.Base64 => "base64",
                TextEmbeddingInputEmbeddingType.Binary => "binary",
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
                "float" => TextEmbeddingInputEmbeddingType.Float,
                "base64" => TextEmbeddingInputEmbeddingType.Base64,
                "binary" => TextEmbeddingInputEmbeddingType.Binary,
                "ubinary" => TextEmbeddingInputEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}