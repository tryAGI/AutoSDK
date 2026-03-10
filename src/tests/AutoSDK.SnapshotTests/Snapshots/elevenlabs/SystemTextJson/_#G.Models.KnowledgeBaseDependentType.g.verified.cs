//HintName: G.Models.KnowledgeBaseDependentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeBaseDependentType
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Transitive,
        /// <summary>
        /// 
        /// </summary>
        All,
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
                KnowledgeBaseDependentType.Direct => "direct",
                KnowledgeBaseDependentType.Transitive => "transitive",
                KnowledgeBaseDependentType.All => "all",
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
                "direct" => KnowledgeBaseDependentType.Direct,
                "transitive" => KnowledgeBaseDependentType.Transitive,
                "all" => KnowledgeBaseDependentType.All,
                _ => null,
            };
        }
    }
}