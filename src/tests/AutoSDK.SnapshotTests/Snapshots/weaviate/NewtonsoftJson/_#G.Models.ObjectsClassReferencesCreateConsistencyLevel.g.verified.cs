//HintName: G.Models.ObjectsClassReferencesCreateConsistencyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ObjectsClassReferencesCreateConsistencyLevel
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
    public static class ObjectsClassReferencesCreateConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassReferencesCreateConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassReferencesCreateConsistencyLevel.All => "ALL",
                ObjectsClassReferencesCreateConsistencyLevel.One => "ONE",
                ObjectsClassReferencesCreateConsistencyLevel.Quorum => "QUORUM",
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
                "ALL" => ObjectsClassReferencesCreateConsistencyLevel.All,
                "ONE" => ObjectsClassReferencesCreateConsistencyLevel.One,
                "QUORUM" => ObjectsClassReferencesCreateConsistencyLevel.Quorum,
                _ => null,
            };
        }
    }
}