//HintName: G.Models.ObjectsUpdateConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsUpdateConsistencyLevel
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
    public static class ObjectsUpdateConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsUpdateConsistencyLevel value)
        {
            return value switch
            {
                ObjectsUpdateConsistencyLevel.All => "ALL",
                ObjectsUpdateConsistencyLevel.One => "ONE",
                ObjectsUpdateConsistencyLevel.Quorum => "QUORUM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsUpdateConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => ObjectsUpdateConsistencyLevel.All,
                "ONE" => ObjectsUpdateConsistencyLevel.One,
                "QUORUM" => ObjectsUpdateConsistencyLevel.Quorum,
                _ => null,
            };
        }
    }
}