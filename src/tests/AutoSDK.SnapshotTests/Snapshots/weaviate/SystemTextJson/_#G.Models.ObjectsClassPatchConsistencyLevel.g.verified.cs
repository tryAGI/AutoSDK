//HintName: G.Models.ObjectsClassPatchConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsClassPatchConsistencyLevel
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
    public static class ObjectsClassPatchConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassPatchConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassPatchConsistencyLevel.One => "ONE",
                ObjectsClassPatchConsistencyLevel.Quorum => "QUORUM",
                ObjectsClassPatchConsistencyLevel.All => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassPatchConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => ObjectsClassPatchConsistencyLevel.One,
                "QUORUM" => ObjectsClassPatchConsistencyLevel.Quorum,
                "ALL" => ObjectsClassPatchConsistencyLevel.All,
                _ => null,
            };
        }
    }
}