//HintName: G.Models.DeleteKnowledgeBaseSourceResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteKnowledgeBaseSourceResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteKnowledgeBaseSourceResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteKnowledgeBaseSourceResponseStatus value)
        {
            return value switch
            {
                DeleteKnowledgeBaseSourceResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteKnowledgeBaseSourceResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteKnowledgeBaseSourceResponseStatus.Error,
                _ => null,
            };
        }
    }
}