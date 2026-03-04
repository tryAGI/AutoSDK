//HintName: G.Models.ObjectsPatchConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsPatchConsistencyLevel
    {
        /// <summary>
        /// 
        /// </summary>
        One,
        /// <summary>
        /// 
        /// </summary>
        Quorum,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectsPatchConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsPatchConsistencyLevel value)
        {
            return value switch
            {
                ObjectsPatchConsistencyLevel.One => "ONE",
                ObjectsPatchConsistencyLevel.Quorum => "QUORUM",
                ObjectsPatchConsistencyLevel.All => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsPatchConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => ObjectsPatchConsistencyLevel.One,
                "QUORUM" => ObjectsPatchConsistencyLevel.Quorum,
                "ALL" => ObjectsPatchConsistencyLevel.All,
                _ => null,
            };
        }
    }
}