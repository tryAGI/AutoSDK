//HintName: G.Models.KnowledgeBaseSourceUrlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the knowledge base source.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KnowledgeBaseSourceUrlType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseSourceUrlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseSourceUrlType value)
        {
            return value switch
            {
                KnowledgeBaseSourceUrlType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseSourceUrlType? ToEnum(string value)
        {
            return value switch
            {
                "url" => KnowledgeBaseSourceUrlType.Url,
                _ => null,
            };
        }
    }
}