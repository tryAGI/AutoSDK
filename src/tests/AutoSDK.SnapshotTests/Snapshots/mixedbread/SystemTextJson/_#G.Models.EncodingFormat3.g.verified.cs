//HintName: G.Models.EncodingFormat3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enumeration of encoding formats.
    /// </summary>
    public enum EncodingFormat3
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
        Float16,
        /// <summary>
        /// 
        /// </summary>
        Int8,
        /// <summary>
        /// 
        /// </summary>
        Ubinary,
        /// <summary>
        /// 
        /// </summary>
        Uint8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EncodingFormat3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EncodingFormat3 value)
        {
            return value switch
            {
                EncodingFormat3.Base64 => "base64",
                EncodingFormat3.Binary => "binary",
                EncodingFormat3.Float => "float",
                EncodingFormat3.Float16 => "float16",
                EncodingFormat3.Int8 => "int8",
                EncodingFormat3.Ubinary => "ubinary",
                EncodingFormat3.Uint8 => "uint8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EncodingFormat3? ToEnum(string value)
        {
            return value switch
            {
                "base64" => EncodingFormat3.Base64,
                "binary" => EncodingFormat3.Binary,
                "float" => EncodingFormat3.Float,
                "float16" => EncodingFormat3.Float16,
                "int8" => EncodingFormat3.Int8,
                "ubinary" => EncodingFormat3.Ubinary,
                "uint8" => EncodingFormat3.Uint8,
                _ => null,
            };
        }
    }
}