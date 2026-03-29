//HintName: G.Models.DeleteKnowledgeBaseResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteKnowledgeBaseResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteKnowledgeBaseResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteKnowledgeBaseResponseStatus value)
        {
            return value switch
            {
                DeleteKnowledgeBaseResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteKnowledgeBaseResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteKnowledgeBaseResponseStatus.Error,
                _ => null,
            };
        }
    }
}