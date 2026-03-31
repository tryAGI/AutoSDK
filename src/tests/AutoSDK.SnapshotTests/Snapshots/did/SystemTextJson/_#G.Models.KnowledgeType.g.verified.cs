//HintName: G.Models.KnowledgeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Knowledge,
        /// <summary>
        /// 
        /// </summary>
        Record,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeType value)
        {
            return value switch
            {
                KnowledgeType.Document => "document",
                KnowledgeType.Knowledge => "knowledge",
                KnowledgeType.Record => "record",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeType? ToEnum(string value)
        {
            return value switch
            {
                "document" => KnowledgeType.Document,
                "knowledge" => KnowledgeType.Knowledge,
                "record" => KnowledgeType.Record,
                _ => null,
            };
        }
    }
}