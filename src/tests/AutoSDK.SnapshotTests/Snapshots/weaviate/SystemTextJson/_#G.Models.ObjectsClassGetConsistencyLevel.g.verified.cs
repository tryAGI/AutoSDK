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
    public static class ObjectsClassGetConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassGetConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassGetConsistencyLevel.One => "ONE",
                ObjectsClassGetConsistencyLevel.Quorum => "QUORUM",
                ObjectsClassGetConsistencyLevel.All => "ALL",
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
                "ONE" => ObjectsClassGetConsistencyLevel.One,
                "QUORUM" => ObjectsClassGetConsistencyLevel.Quorum,
                "ALL" => ObjectsClassGetConsistencyLevel.All,
                _ => null,
            };
        }
    }
}