//HintName: G.Models.ObjectsClassReferencesDeleteConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsClassReferencesDeleteConsistencyLevel
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
    public static class ObjectsClassReferencesDeleteConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassReferencesDeleteConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassReferencesDeleteConsistencyLevel.ONE => "ONE",
                ObjectsClassReferencesDeleteConsistencyLevel.QUORUM => "QUORUM",
                ObjectsClassReferencesDeleteConsistencyLevel.ALL => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassReferencesDeleteConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => ObjectsClassReferencesDeleteConsistencyLevel.ONE,
                "QUORUM" => ObjectsClassReferencesDeleteConsistencyLevel.QUORUM,
                "ALL" => ObjectsClassReferencesDeleteConsistencyLevel.ALL,
                _ => null,
            };
        }
    }
}