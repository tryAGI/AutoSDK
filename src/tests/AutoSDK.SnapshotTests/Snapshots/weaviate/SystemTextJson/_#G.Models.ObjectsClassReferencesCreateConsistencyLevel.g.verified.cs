//HintName: G.Models.ObjectsClassReferencesCreateConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsClassReferencesCreateConsistencyLevel
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
    public static class ObjectsClassReferencesCreateConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassReferencesCreateConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassReferencesCreateConsistencyLevel.One => "ONE",
                ObjectsClassReferencesCreateConsistencyLevel.Quorum => "QUORUM",
                ObjectsClassReferencesCreateConsistencyLevel.All => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassReferencesCreateConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => ObjectsClassReferencesCreateConsistencyLevel.One,
                "QUORUM" => ObjectsClassReferencesCreateConsistencyLevel.Quorum,
                "ALL" => ObjectsClassReferencesCreateConsistencyLevel.All,
                _ => null,
            };
        }
    }
}