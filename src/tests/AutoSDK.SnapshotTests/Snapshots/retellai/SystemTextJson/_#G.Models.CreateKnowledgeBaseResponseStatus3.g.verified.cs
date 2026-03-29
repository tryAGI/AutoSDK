//HintName: G.Models.CreateKnowledgeBaseResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateKnowledgeBaseResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKnowledgeBaseResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKnowledgeBaseResponseStatus3 value)
        {
            return value switch
            {
                CreateKnowledgeBaseResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKnowledgeBaseResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateKnowledgeBaseResponseStatus3.Error,
                _ => null,
            };
        }
    }
}