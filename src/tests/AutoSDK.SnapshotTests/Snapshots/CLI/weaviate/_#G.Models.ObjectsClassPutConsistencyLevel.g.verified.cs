//HintName: G.Models.ObjectsClassPutConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsClassPutConsistencyLevel
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
    public static class ObjectsClassPutConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassPutConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassPutConsistencyLevel.ONE => "ONE",
                ObjectsClassPutConsistencyLevel.QUORUM => "QUORUM",
                ObjectsClassPutConsistencyLevel.ALL => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassPutConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => ObjectsClassPutConsistencyLevel.ONE,
                "QUORUM" => ObjectsClassPutConsistencyLevel.QUORUM,
                "ALL" => ObjectsClassPutConsistencyLevel.ALL,
                _ => null,
            };
        }
    }
}