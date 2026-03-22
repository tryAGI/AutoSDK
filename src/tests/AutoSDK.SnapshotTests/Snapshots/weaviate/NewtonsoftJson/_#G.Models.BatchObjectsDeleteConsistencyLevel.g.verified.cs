//HintName: G.Models.BatchObjectsDeleteConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchObjectsDeleteConsistencyLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ALL")]
        All,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectsDeleteConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectsDeleteConsistencyLevel value)
        {
            return value switch
            {
                BatchObjectsDeleteConsistencyLevel.All => "ALL",
                BatchObjectsDeleteConsistencyLevel.One => "ONE",
                BatchObjectsDeleteConsistencyLevel.Quorum => "QUORUM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectsDeleteConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => BatchObjectsDeleteConsistencyLevel.All,
                "ONE" => BatchObjectsDeleteConsistencyLevel.One,
                "QUORUM" => BatchObjectsDeleteConsistencyLevel.Quorum,
                _ => null,
            };
        }
    }
}