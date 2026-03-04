//HintName: G.Models.ObjectsClassReferencesDeleteConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ObjectsClassReferencesDeleteConsistencyLevel
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
    public static class ObjectsClassReferencesDeleteConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassReferencesDeleteConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassReferencesDeleteConsistencyLevel.One => "ONE",
                ObjectsClassReferencesDeleteConsistencyLevel.Quorum => "QUORUM",
                ObjectsClassReferencesDeleteConsistencyLevel.All => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassReferencesDeleteConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => ObjectsClassReferencesDeleteConsistencyLevel.One,
                "QUORUM" => ObjectsClassReferencesDeleteConsistencyLevel.Quorum,
                "ALL" => ObjectsClassReferencesDeleteConsistencyLevel.All,
                _ => null,
            };
        }
    }
}