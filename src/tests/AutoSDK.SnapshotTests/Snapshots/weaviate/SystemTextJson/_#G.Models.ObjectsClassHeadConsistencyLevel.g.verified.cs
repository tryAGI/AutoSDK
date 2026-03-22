//HintName: G.Models.ObjectsClassHeadConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsClassHeadConsistencyLevel
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
    public static class ObjectsClassHeadConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassHeadConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassHeadConsistencyLevel.All => "ALL",
                ObjectsClassHeadConsistencyLevel.One => "ONE",
                ObjectsClassHeadConsistencyLevel.Quorum => "QUORUM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassHeadConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => ObjectsClassHeadConsistencyLevel.All,
                "ONE" => ObjectsClassHeadConsistencyLevel.One,
                "QUORUM" => ObjectsClassHeadConsistencyLevel.Quorum,
                _ => null,
            };
        }
    }
}