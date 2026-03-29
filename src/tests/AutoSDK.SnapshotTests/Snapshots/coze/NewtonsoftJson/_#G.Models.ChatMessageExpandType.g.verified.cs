//HintName: G.Models.ChatMessageExpandType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatMessageExpandType
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
    public static class ChatMessageExpandTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageExpandType value)
        {
            return value switch
            {
                ChatMessageExpandType.DocumentRef => "document_ref",
                ChatMessageExpandType.EmbeddedMultimedia => "embedded_multimedia",
                ChatMessageExpandType.Insertable => "insertable",
                ChatMessageExpandType.KnowledgeCard => "knowledge_card",
                ChatMessageExpandType.Replaceable => "replaceable",
                ChatMessageExpandType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageExpandType? ToEnum(string value)
        {
            return value switch
            {
                "document_ref" => ChatMessageExpandType.DocumentRef,
                "embedded_multimedia" => ChatMessageExpandType.EmbeddedMultimedia,
                "insertable" => ChatMessageExpandType.Insertable,
                "knowledge_card" => ChatMessageExpandType.KnowledgeCard,
                "replaceable" => ChatMessageExpandType.Replaceable,
                "unknown" => ChatMessageExpandType.Unknown,
                _ => null,
            };
        }
    }
}