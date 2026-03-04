//HintName: G.Models.BatchObjectsCreateConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchObjectsCreateConsistencyLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ONE")]
        One,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QUORUM")]
        Quorum,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ALL")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectsCreateConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectsCreateConsistencyLevel value)
        {
            return value switch
            {
                BatchObjectsCreateConsistencyLevel.One => "ONE",
                BatchObjectsCreateConsistencyLevel.Quorum => "QUORUM",
                BatchObjectsCreateConsistencyLevel.All => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectsCreateConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => BatchObjectsCreateConsistencyLevel.One,
                "QUORUM" => BatchObjectsCreateConsistencyLevel.Quorum,
                "ALL" => BatchObjectsCreateConsistencyLevel.All,
                _ => null,
            };
        }
    }
}