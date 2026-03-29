//HintName: G.Models.AddKnowledgeBaseSourcesResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddKnowledgeBaseSourcesResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddKnowledgeBaseSourcesResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddKnowledgeBaseSourcesResponseStatus5 value)
        {
            return value switch
            {
                AddKnowledgeBaseSourcesResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddKnowledgeBaseSourcesResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => AddKnowledgeBaseSourcesResponseStatus5.Error,
                _ => null,
            };
        }
    }
}