//HintName: G.Models.DeleteResponseVariant1KnowledgeProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the knowledge base
    /// </summary>
    public enum DeleteResponseVariant1KnowledgeProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Pinecone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteResponseVariant1KnowledgeProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteResponseVariant1KnowledgeProvider value)
        {
            return value switch
            {
                DeleteResponseVariant1KnowledgeProvider.Pinecone => "pinecone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteResponseVariant1KnowledgeProvider? ToEnum(string value)
        {
            return value switch
            {
                "pinecone" => DeleteResponseVariant1KnowledgeProvider.Pinecone,
                _ => null,
            };
        }
    }
}