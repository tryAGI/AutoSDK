//HintName: G.Models.KnowledgeProvider2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the knowledge base
    /// </summary>
    public enum KnowledgeProvider2
    {
        /// <summary>
        /// 
        /// </summary>
        Pinecone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeProvider2 value)
        {
            return value switch
            {
                KnowledgeProvider2.Pinecone => "pinecone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeProvider2? ToEnum(string value)
        {
            return value switch
            {
                "pinecone" => KnowledgeProvider2.Pinecone,
                _ => null,
            };
        }
    }
}