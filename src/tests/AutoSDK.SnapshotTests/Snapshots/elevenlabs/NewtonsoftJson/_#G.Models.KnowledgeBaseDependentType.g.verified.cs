//HintName: G.Models.KnowledgeBaseDependentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KnowledgeBaseDependentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="direct")]
        Direct,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transitive")]
        Transitive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseDependentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseDependentType value)
        {
            return value switch
            {
                KnowledgeBaseDependentType.All => "all",
                KnowledgeBaseDependentType.Direct => "direct",
                KnowledgeBaseDependentType.Transitive => "transitive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseDependentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => KnowledgeBaseDependentType.All,
                "direct" => KnowledgeBaseDependentType.Direct,
                "transitive" => KnowledgeBaseDependentType.Transitive,
                _ => null,
            };
        }
    }
}