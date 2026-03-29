//HintName: G.Models.VectorStorageDatatype.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Storage types for vectors
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStorageDatatype
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float16")]
        Float16,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float32")]
        Float32,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uint8")]
        Uint8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStorageDatatypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStorageDatatype value)
        {
            return value switch
            {
                VectorStorageDatatype.Float16 => "float16",
                VectorStorageDatatype.Float32 => "float32",
                VectorStorageDatatype.Uint8 => "uint8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStorageDatatype? ToEnum(string value)
        {
            return value switch
            {
                "float16" => VectorStorageDatatype.Float16,
                "float32" => VectorStorageDatatype.Float32,
                "uint8" => VectorStorageDatatype.Uint8,
                _ => null,
            };
        }
    }
}