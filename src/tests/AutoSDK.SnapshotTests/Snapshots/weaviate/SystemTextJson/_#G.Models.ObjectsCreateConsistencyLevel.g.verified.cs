//HintName: G.Models.ObjectsCreateConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsCreateConsistencyLevel
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
    public static class ObjectsCreateConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsCreateConsistencyLevel value)
        {
            return value switch
            {
                ObjectsCreateConsistencyLevel.All => "ALL",
                ObjectsCreateConsistencyLevel.One => "ONE",
                ObjectsCreateConsistencyLevel.Quorum => "QUORUM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsCreateConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => ObjectsCreateConsistencyLevel.All,
                "ONE" => ObjectsCreateConsistencyLevel.One,
                "QUORUM" => ObjectsCreateConsistencyLevel.Quorum,
                _ => null,
            };
        }
    }
}