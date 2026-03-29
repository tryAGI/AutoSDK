//HintName: G.Models.PGVectorDistanceMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Distance methods for PGVector.<br/>
    /// Docs:<br/>
    /// https://github.com/pgvector/pgvector?tab=readme-ov-file#query-options
    /// </summary>
    public enum PGVectorDistanceMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Cosine,
        /// <summary>
        /// 
        /// </summary>
        Hamming,
        /// <summary>
        /// 
        /// </summary>
        Ip,
        /// <summary>
        /// 
        /// </summary>
        Jaccard,
        /// <summary>
        /// 
        /// </summary>
        L1,
        /// <summary>
        /// 
        /// </summary>
        L2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PGVectorDistanceMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PGVectorDistanceMethod value)
        {
            return value switch
            {
                PGVectorDistanceMethod.Cosine => "cosine",
                PGVectorDistanceMethod.Hamming => "hamming",
                PGVectorDistanceMethod.Ip => "ip",
                PGVectorDistanceMethod.Jaccard => "jaccard",
                PGVectorDistanceMethod.L1 => "l1",
                PGVectorDistanceMethod.L2 => "l2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PGVectorDistanceMethod? ToEnum(string value)
        {
            return value switch
            {
                "cosine" => PGVectorDistanceMethod.Cosine,
                "hamming" => PGVectorDistanceMethod.Hamming,
                "ip" => PGVectorDistanceMethod.Ip,
                "jaccard" => PGVectorDistanceMethod.Jaccard,
                "l1" => PGVectorDistanceMethod.L1,
                "l2" => PGVectorDistanceMethod.L2,
                _ => null,
            };
        }
    }
}