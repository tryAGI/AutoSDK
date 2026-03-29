//HintName: G.Models.AddKnowledgeBaseSourcesResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddKnowledgeBaseSourcesResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddKnowledgeBaseSourcesResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddKnowledgeBaseSourcesResponseStatus2 value)
        {
            return value switch
            {
                AddKnowledgeBaseSourcesResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddKnowledgeBaseSourcesResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => AddKnowledgeBaseSourcesResponseStatus2.Error,
                _ => null,
            };
        }
    }
}