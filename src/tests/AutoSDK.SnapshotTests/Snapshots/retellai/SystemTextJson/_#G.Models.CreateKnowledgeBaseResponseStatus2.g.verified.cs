//HintName: G.Models.CreateKnowledgeBaseResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateKnowledgeBaseResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKnowledgeBaseResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKnowledgeBaseResponseStatus2 value)
        {
            return value switch
            {
                CreateKnowledgeBaseResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKnowledgeBaseResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateKnowledgeBaseResponseStatus2.Error,
                _ => null,
            };
        }
    }
}