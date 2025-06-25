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
        ONE,
        /// <summary>
        /// 
        /// </summary>
        QUORUM,
        /// <summary>
        /// 
        /// </summary>
        ALL,
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
                ObjectsPatchConsistencyLevel.ONE => "ONE",
                ObjectsPatchConsistencyLevel.QUORUM => "QUORUM",
                ObjectsPatchConsistencyLevel.ALL => "ALL",
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
                "ONE" => ObjectsPatchConsistencyLevel.ONE,
                "QUORUM" => ObjectsPatchConsistencyLevel.QUORUM,
                "ALL" => ObjectsPatchConsistencyLevel.ALL,
                _ => null,
            };
        }
    }
}