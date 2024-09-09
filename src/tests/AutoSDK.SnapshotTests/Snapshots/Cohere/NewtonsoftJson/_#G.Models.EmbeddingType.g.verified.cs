//HintName: G.Models.EmbeddingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float")]
        Float,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="int8")]
        Int8,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uint8")]
        Uint8,
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
    public static class EmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingType value)
        {
            return value switch
            {
                EmbeddingType.Float => "float",
                EmbeddingType.Int8 => "int8",
                EmbeddingType.Uint8 => "uint8",
                EmbeddingType.Binary => "binary",
                EmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "float" => EmbeddingType.Float,
                "int8" => EmbeddingType.Int8,
                "uint8" => EmbeddingType.Uint8,
                "binary" => EmbeddingType.Binary,
                "ubinary" => EmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}