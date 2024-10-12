//HintName: G.Models.TextEmbeddingInputEmbeddingTypeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextEmbeddingInputEmbeddingTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float")]
        Float,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="binary")]
        Binary,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ubinary")]
        Ubinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEmbeddingInputEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbeddingInputEmbeddingTypeItem value)
        {
            return value switch
            {
                TextEmbeddingInputEmbeddingTypeItem.Float => "float",
                TextEmbeddingInputEmbeddingTypeItem.Base64 => "base64",
                TextEmbeddingInputEmbeddingTypeItem.Binary => "binary",
                TextEmbeddingInputEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbeddingInputEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "float" => TextEmbeddingInputEmbeddingTypeItem.Float,
                "base64" => TextEmbeddingInputEmbeddingTypeItem.Base64,
                "binary" => TextEmbeddingInputEmbeddingTypeItem.Binary,
                "ubinary" => TextEmbeddingInputEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}