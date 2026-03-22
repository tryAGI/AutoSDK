//HintName: G.Models.ObjectsDeleteConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsDeleteConsistencyLevel
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
    public static class ObjectsDeleteConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsDeleteConsistencyLevel value)
        {
            return value switch
            {
                ObjectsDeleteConsistencyLevel.All => "ALL",
                ObjectsDeleteConsistencyLevel.One => "ONE",
                ObjectsDeleteConsistencyLevel.Quorum => "QUORUM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsDeleteConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => ObjectsDeleteConsistencyLevel.All,
                "ONE" => ObjectsDeleteConsistencyLevel.One,
                "QUORUM" => ObjectsDeleteConsistencyLevel.Quorum,
                _ => null,
            };
        }
    }
}