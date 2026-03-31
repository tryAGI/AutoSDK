//HintName: G.Models.KnowledgeProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Pinecone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeProvider value)
        {
            return value switch
            {
                KnowledgeProvider.Pinecone => "pinecone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeProvider? ToEnum(string value)
        {
            return value switch
            {
                "pinecone" => KnowledgeProvider.Pinecone,
                _ => null,
            };
        }
    }
}