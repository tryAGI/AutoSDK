//HintName: G.Models.ObjectsClassReferencesPutConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsClassReferencesPutConsistencyLevel
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        One,
        /// <summary>
        /// 
        /// </summary>
        Quorum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectsClassReferencesPutConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassReferencesPutConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassReferencesPutConsistencyLevel.All => "ALL",
                ObjectsClassReferencesPutConsistencyLevel.One => "ONE",
                ObjectsClassReferencesPutConsistencyLevel.Quorum => "QUORUM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassReferencesPutConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => ObjectsClassReferencesPutConsistencyLevel.All,
                "ONE" => ObjectsClassReferencesPutConsistencyLevel.One,
                "QUORUM" => ObjectsClassReferencesPutConsistencyLevel.Quorum,
                _ => null,
            };
        }
    }
}