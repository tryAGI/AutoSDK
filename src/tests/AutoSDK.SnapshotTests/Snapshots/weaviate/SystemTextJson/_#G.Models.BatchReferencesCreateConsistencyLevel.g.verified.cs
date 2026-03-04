//HintName: G.Models.BatchReferencesCreateConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum BatchReferencesCreateConsistencyLevel
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
    public static class BatchReferencesCreateConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchReferencesCreateConsistencyLevel value)
        {
            return value switch
            {
                BatchReferencesCreateConsistencyLevel.One => "ONE",
                BatchReferencesCreateConsistencyLevel.Quorum => "QUORUM",
                BatchReferencesCreateConsistencyLevel.All => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchReferencesCreateConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => BatchReferencesCreateConsistencyLevel.One,
                "QUORUM" => BatchReferencesCreateConsistencyLevel.Quorum,
                "ALL" => BatchReferencesCreateConsistencyLevel.All,
                _ => null,
            };
        }
    }
}