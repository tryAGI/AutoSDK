//HintName: G.Models.VectorIndexType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Name of the vector index to use, eg. (HNSW)<br/>
    /// Default Value: hnsw
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorIndexType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flat")]
        Flat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hnsw")]
        Hnsw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorIndexTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorIndexType value)
        {
            return value switch
            {
                VectorIndexType.Flat => "flat",
                VectorIndexType.Hnsw => "hnsw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorIndexType? ToEnum(string value)
        {
            return value switch
            {
                "flat" => VectorIndexType.Flat,
                "hnsw" => VectorIndexType.Hnsw,
                _ => null,
            };
        }
    }
}