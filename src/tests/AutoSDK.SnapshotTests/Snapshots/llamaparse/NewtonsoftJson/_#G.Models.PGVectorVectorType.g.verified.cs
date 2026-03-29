//HintName: G.Models.PGVectorVectorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Vector storage formats for PGVector.<br/>
    /// Docs:<br/>
    /// https://github.com/pgvector/pgvector?tab=readme-ov-file#query-options
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PGVectorVectorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bit")]
        Bit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="half_vec")]
        HalfVec,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sparse_vec")]
        SparseVec,
        /// <summary>
        /// //github.com/pgvector/pgvector?tab=readme-ov-file#query-options
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vector")]
        Vector,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PGVectorVectorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PGVectorVectorType value)
        {
            return value switch
            {
                PGVectorVectorType.Bit => "bit",
                PGVectorVectorType.HalfVec => "half_vec",
                PGVectorVectorType.SparseVec => "sparse_vec",
                PGVectorVectorType.Vector => "vector",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PGVectorVectorType? ToEnum(string value)
        {
            return value switch
            {
                "bit" => PGVectorVectorType.Bit,
                "half_vec" => PGVectorVectorType.HalfVec,
                "sparse_vec" => PGVectorVectorType.SparseVec,
                "vector" => PGVectorVectorType.Vector,
                _ => null,
            };
        }
    }
}