//HintName: G.Models.BatchReferencesCreateConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchReferencesCreateConsistencyLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ONE")]
        ONE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QUORUM")]
        QUORUM,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ALL")]
        ALL,
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
                BatchReferencesCreateConsistencyLevel.ONE => "ONE",
                BatchReferencesCreateConsistencyLevel.QUORUM => "QUORUM",
                BatchReferencesCreateConsistencyLevel.ALL => "ALL",
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
                "ONE" => BatchReferencesCreateConsistencyLevel.ONE,
                "QUORUM" => BatchReferencesCreateConsistencyLevel.QUORUM,
                "ALL" => BatchReferencesCreateConsistencyLevel.ALL,
                _ => null,
            };
        }
    }
}