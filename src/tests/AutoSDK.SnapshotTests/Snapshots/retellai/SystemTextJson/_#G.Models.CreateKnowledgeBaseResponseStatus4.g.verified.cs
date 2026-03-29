//HintName: G.Models.CreateKnowledgeBaseResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateKnowledgeBaseResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKnowledgeBaseResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKnowledgeBaseResponseStatus4 value)
        {
            return value switch
            {
                CreateKnowledgeBaseResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKnowledgeBaseResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateKnowledgeBaseResponseStatus4.Error,
                _ => null,
            };
        }
    }
}