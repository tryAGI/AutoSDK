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
    public static class ObjectsDeleteConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsDeleteConsistencyLevel value)
        {
            return value switch
            {
                ObjectsDeleteConsistencyLevel.One => "ONE",
                ObjectsDeleteConsistencyLevel.Quorum => "QUORUM",
                ObjectsDeleteConsistencyLevel.All => "ALL",
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
                "ONE" => ObjectsDeleteConsistencyLevel.One,
                "QUORUM" => ObjectsDeleteConsistencyLevel.Quorum,
                "ALL" => ObjectsDeleteConsistencyLevel.All,
                _ => null,
            };
        }
    }
}