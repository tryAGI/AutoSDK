//HintName: G.Models.DeleteKnowledgeBaseResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteKnowledgeBaseResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteKnowledgeBaseResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteKnowledgeBaseResponseStatus3 value)
        {
            return value switch
            {
                DeleteKnowledgeBaseResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteKnowledgeBaseResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteKnowledgeBaseResponseStatus3.Error,
                _ => null,
            };
        }
    }
}