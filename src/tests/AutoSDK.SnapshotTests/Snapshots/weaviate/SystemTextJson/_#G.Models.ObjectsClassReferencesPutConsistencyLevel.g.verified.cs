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
    public static class ObjectsClassReferencesPutConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassReferencesPutConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassReferencesPutConsistencyLevel.One => "ONE",
                ObjectsClassReferencesPutConsistencyLevel.Quorum => "QUORUM",
                ObjectsClassReferencesPutConsistencyLevel.All => "ALL",
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
                "ONE" => ObjectsClassReferencesPutConsistencyLevel.One,
                "QUORUM" => ObjectsClassReferencesPutConsistencyLevel.Quorum,
                "ALL" => ObjectsClassReferencesPutConsistencyLevel.All,
                _ => null,
            };
        }
    }
}