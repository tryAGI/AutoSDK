//HintName: G.Models.DeleteKnowledgeBaseResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteKnowledgeBaseResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteKnowledgeBaseResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteKnowledgeBaseResponseStatus4 value)
        {
            return value switch
            {
                DeleteKnowledgeBaseResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteKnowledgeBaseResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteKnowledgeBaseResponseStatus4.Error,
                _ => null,
            };
        }
    }
}