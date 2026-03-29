//HintName: G.Models.GetKnowledgeBaseResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKnowledgeBaseResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseResponseStatus3 value)
        {
            return value switch
            {
                GetKnowledgeBaseResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetKnowledgeBaseResponseStatus3.Error,
                _ => null,
            };
        }
    }
}