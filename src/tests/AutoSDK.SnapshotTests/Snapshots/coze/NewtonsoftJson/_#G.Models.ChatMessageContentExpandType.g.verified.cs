//HintName: G.Models.ChatMessageContentExpandType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatMessageContentExpandType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document_ref")]
        DocumentRef,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedded_multimedia")]
        EmbeddedMultimedia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="insertable")]
        Insertable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="knowledge_card")]
        KnowledgeCard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="replaceable")]
        Replaceable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
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