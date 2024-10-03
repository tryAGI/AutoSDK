//HintName: G.Models.ObjectsClassGetConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsClassGetConsistencyLevel
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
    public static class ObjectsClassGetConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassGetConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassGetConsistencyLevel.ONE => "ONE",
                ObjectsClassGetConsistencyLevel.QUORUM => "QUORUM",
                ObjectsClassGetConsistencyLevel.ALL => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassGetConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => ObjectsClassGetConsistencyLevel.ONE,
                "QUORUM" => ObjectsClassGetConsistencyLevel.QUORUM,
                "ALL" => ObjectsClassGetConsistencyLevel.ALL,
                _ => null,
            };
        }
    }
}