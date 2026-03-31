//HintName: G.Models.UpdateResponseVariant1KnowledgeProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the knowledge base
    /// </summary>
    public enum UpdateResponseVariant1KnowledgeProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Pinecone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateResponseVariant1KnowledgeProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1KnowledgeProvider value)
        {
            return value switch
            {
                UpdateResponseVariant1KnowledgeProvider.Pinecone => "pinecone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1KnowledgeProvider? ToEnum(string value)
        {
            return value switch
            {
                "pinecone" => UpdateResponseVariant1KnowledgeProvider.Pinecone,
                _ => null,
            };
        }
    }
}