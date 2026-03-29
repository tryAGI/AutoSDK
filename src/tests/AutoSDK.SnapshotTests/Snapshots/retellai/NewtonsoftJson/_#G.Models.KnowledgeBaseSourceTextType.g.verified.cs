//HintName: G.Models.KnowledgeBaseSourceTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the knowledge base source.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KnowledgeBaseSourceTextType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseSourceTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseSourceTextType value)
        {
            return value switch
            {
                KnowledgeBaseSourceTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseSourceTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => KnowledgeBaseSourceTextType.Text,
                _ => null,
            };
        }
    }
}