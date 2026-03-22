//HintName: G.Models.ObjectsClassGetConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ObjectsClassGetConsistencyLevel
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
    public static class ObjectsClassGetConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassGetConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassGetConsistencyLevel.All => "ALL",
                ObjectsClassGetConsistencyLevel.One => "ONE",
                ObjectsClassGetConsistencyLevel.Quorum => "QUORUM",
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
                "ALL" => ObjectsClassGetConsistencyLevel.All,
                "ONE" => ObjectsClassGetConsistencyLevel.One,
                "QUORUM" => ObjectsClassGetConsistencyLevel.Quorum,
                _ => null,
            };
        }
    }
}