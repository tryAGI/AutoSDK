//HintName: G.Models.GetKnowledgeBaseResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKnowledgeBaseResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseResponseStatus value)
        {
            return value switch
            {
                GetKnowledgeBaseResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetKnowledgeBaseResponseStatus.Error,
                _ => null,
            };
        }
    }
}