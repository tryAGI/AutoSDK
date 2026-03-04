//HintName: G.Models.ObjectsClassPatchConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ObjectsClassPatchConsistencyLevel
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
    public static class ObjectsClassPatchConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassPatchConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassPatchConsistencyLevel.One => "ONE",
                ObjectsClassPatchConsistencyLevel.Quorum => "QUORUM",
                ObjectsClassPatchConsistencyLevel.All => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassPatchConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => ObjectsClassPatchConsistencyLevel.One,
                "QUORUM" => ObjectsClassPatchConsistencyLevel.Quorum,
                "ALL" => ObjectsClassPatchConsistencyLevel.All,
                _ => null,
            };
        }
    }
}