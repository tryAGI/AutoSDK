//HintName: G.Models.KnowledgeBaseCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of cost, always 'knowledge-base' for this class.
    /// </summary>
    public enum KnowledgeBaseCostType
    {
        /// <summary>
        /// 
        /// </summary>
        KnowledgeBase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseCostType value)
        {
            return value switch
            {
                KnowledgeBaseCostType.KnowledgeBase => "knowledge-base",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseCostType? ToEnum(string value)
        {
            return value switch
            {
                "knowledge-base" => KnowledgeBaseCostType.KnowledgeBase,
                _ => null,
            };
        }
    }
}