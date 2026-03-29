//HintName: G.Models.AddKnowledgeBaseSourcesResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddKnowledgeBaseSourcesResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddKnowledgeBaseSourcesResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddKnowledgeBaseSourcesResponseStatus4 value)
        {
            return value switch
            {
                AddKnowledgeBaseSourcesResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddKnowledgeBaseSourcesResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => AddKnowledgeBaseSourcesResponseStatus4.Error,
                _ => null,
            };
        }
    }
}