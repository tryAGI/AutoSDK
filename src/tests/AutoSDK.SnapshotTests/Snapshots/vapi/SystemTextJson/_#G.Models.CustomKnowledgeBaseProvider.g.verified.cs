//HintName: G.Models.CustomKnowledgeBaseProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This knowledge base is bring your own knowledge base implementation.
    /// </summary>
    public enum CustomKnowledgeBaseProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomKnowledgeBase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomKnowledgeBaseProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomKnowledgeBaseProvider value)
        {
            return value switch
            {
                CustomKnowledgeBaseProvider.CustomKnowledgeBase => "custom-knowledge-base",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomKnowledgeBaseProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-knowledge-base" => CustomKnowledgeBaseProvider.CustomKnowledgeBase,
                _ => null,
            };
        }
    }
}