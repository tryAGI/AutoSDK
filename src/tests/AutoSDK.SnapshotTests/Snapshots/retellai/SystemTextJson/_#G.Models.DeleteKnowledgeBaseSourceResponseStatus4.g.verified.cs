//HintName: G.Models.DeleteKnowledgeBaseSourceResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteKnowledgeBaseSourceResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteKnowledgeBaseSourceResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteKnowledgeBaseSourceResponseStatus4 value)
        {
            return value switch
            {
                DeleteKnowledgeBaseSourceResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteKnowledgeBaseSourceResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteKnowledgeBaseSourceResponseStatus4.Error,
                _ => null,
            };
        }
    }
}