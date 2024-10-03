//HintName: G.Models.ObjectsUpdateConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ObjectsUpdateConsistencyLevel
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
    public static class ObjectsUpdateConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsUpdateConsistencyLevel value)
        {
            return value switch
            {
                ObjectsUpdateConsistencyLevel.ONE => "ONE",
                ObjectsUpdateConsistencyLevel.QUORUM => "QUORUM",
                ObjectsUpdateConsistencyLevel.ALL => "ALL",
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
                "ONE" => ObjectsUpdateConsistencyLevel.ONE,
                "QUORUM" => ObjectsUpdateConsistencyLevel.QUORUM,
                "ALL" => ObjectsUpdateConsistencyLevel.ALL,
                _ => null,
            };
        }
    }
}