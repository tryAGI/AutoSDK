//HintName: G.Models.ObjectsClassDeleteConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsClassDeleteConsistencyLevel
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
    public static class ObjectsClassDeleteConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassDeleteConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassDeleteConsistencyLevel.One => "ONE",
                ObjectsClassDeleteConsistencyLevel.Quorum => "QUORUM",
                ObjectsClassDeleteConsistencyLevel.All => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassDeleteConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => ObjectsClassDeleteConsistencyLevel.One,
                "QUORUM" => ObjectsClassDeleteConsistencyLevel.Quorum,
                "ALL" => ObjectsClassDeleteConsistencyLevel.All,
                _ => null,
            };
        }
    }
}