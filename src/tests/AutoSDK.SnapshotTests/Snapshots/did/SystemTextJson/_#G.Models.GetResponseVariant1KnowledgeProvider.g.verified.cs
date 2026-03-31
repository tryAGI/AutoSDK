//HintName: G.Models.GetResponseVariant1KnowledgeProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the knowledge base
    /// </summary>
    public enum GetResponseVariant1KnowledgeProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Pinecone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetResponseVariant1KnowledgeProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseVariant1KnowledgeProvider value)
        {
            return value switch
            {
                GetResponseVariant1KnowledgeProvider.Pinecone => "pinecone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseVariant1KnowledgeProvider? ToEnum(string value)
        {
            return value switch
            {
                "pinecone" => GetResponseVariant1KnowledgeProvider.Pinecone,
                _ => null,
            };
        }
    }
}