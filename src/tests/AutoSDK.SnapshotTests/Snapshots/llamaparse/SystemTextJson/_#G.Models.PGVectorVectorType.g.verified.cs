//HintName: G.Models.PGVectorVectorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Vector storage formats for PGVector.<br/>
    /// Docs:<br/>
    /// https://github.com/pgvector/pgvector?tab=readme-ov-file#query-options
    /// </summary>
    public enum PGVectorVectorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bit,
        /// <summary>
        /// 
        /// </summary>
        HalfVec,
        /// <summary>
        /// 
        /// </summary>
        SparseVec,
        /// <summary>
        /// //github.com/pgvector/pgvector?tab=readme-ov-file#query-options
        /// </summary>
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