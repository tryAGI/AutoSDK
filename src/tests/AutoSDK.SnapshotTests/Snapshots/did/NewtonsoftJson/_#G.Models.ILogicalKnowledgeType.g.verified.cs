//HintName: G.Models.ILogicalKnowledgeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object to be stored
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ILogicalKnowledgeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document")]
        Document,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="knowledge")]
        Knowledge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="record")]
        Record,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ILogicalKnowledgeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ILogicalKnowledgeType value)
        {
            return value switch
            {
                ILogicalKnowledgeType.Document => "document",
                ILogicalKnowledgeType.Knowledge => "knowledge",
                ILogicalKnowledgeType.Record => "record",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ILogicalKnowledgeType? ToEnum(string value)
        {
            return value switch
            {
                "document" => ILogicalKnowledgeType.Document,
                "knowledge" => ILogicalKnowledgeType.Knowledge,
                "record" => ILogicalKnowledgeType.Record,
                _ => null,
            };
        }
    }
}