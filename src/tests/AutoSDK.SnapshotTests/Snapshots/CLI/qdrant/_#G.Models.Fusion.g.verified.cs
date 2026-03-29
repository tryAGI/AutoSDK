//HintName: G.Models.Fusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fusion algorithm allows to combine results of multiple prefetches.<br/>
    /// Available fusion algorithms:<br/>
    /// * `rrf` - Reciprocal Rank Fusion (with default parameters) * `dbsf` - Distribution-Based Score Fusion
    /// </summary>
    public enum Fusion
    {
        /// <summary>
        /// 
        /// </summary>
        Dbsf,
        /// <summary>
        /// 
        /// </summary>
        Rrf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Fusion value)
        {
            return value switch
            {
                Fusion.Dbsf => "dbsf",
                Fusion.Rrf => "rrf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Fusion? ToEnum(string value)
        {
            return value switch
            {
                "dbsf" => Fusion.Dbsf,
                "rrf" => Fusion.Rrf,
                _ => null,
            };
        }
    }
}