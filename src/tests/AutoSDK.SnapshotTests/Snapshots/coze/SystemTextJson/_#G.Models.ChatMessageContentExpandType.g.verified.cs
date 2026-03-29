//HintName: G.Models.ChatMessageContentExpandType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatMessageContentExpandType
    {
        /// <summary>
        /// 
        /// </summary>
        DocumentRef,
        /// <summary>
        /// 
        /// </summary>
        EmbeddedMultimedia,
        /// <summary>
        /// 
        /// </summary>
        Insertable,
        /// <summary>
        /// 
        /// </summary>
        KnowledgeCard,
        /// <summary>
        /// 
        /// </summary>
        Replaceable,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageContentExpandTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageContentExpandType value)
        {
            return value switch
            {
                ChatMessageContentExpandType.DocumentRef => "document_ref",
                ChatMessageContentExpandType.EmbeddedMultimedia => "embedded_multimedia",
                ChatMessageContentExpandType.Insertable => "insertable",
                ChatMessageContentExpandType.KnowledgeCard => "knowledge_card",
                ChatMessageContentExpandType.Replaceable => "replaceable",
                ChatMessageContentExpandType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageContentExpandType? ToEnum(string value)
        {
            return value switch
            {
                "document_ref" => ChatMessageContentExpandType.DocumentRef,
                "embedded_multimedia" => ChatMessageContentExpandType.EmbeddedMultimedia,
                "insertable" => ChatMessageContentExpandType.Insertable,
                "knowledge_card" => ChatMessageContentExpandType.KnowledgeCard,
                "replaceable" => ChatMessageContentExpandType.Replaceable,
                "unknown" => ChatMessageContentExpandType.Unknown,
                _ => null,
            };
        }
    }
}