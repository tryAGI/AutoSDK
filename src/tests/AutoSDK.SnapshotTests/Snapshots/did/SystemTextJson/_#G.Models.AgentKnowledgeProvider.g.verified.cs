//HintName: G.Models.AgentKnowledgeProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the knowledge base
    /// </summary>
    public enum AgentKnowledgeProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Pinecone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentKnowledgeProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentKnowledgeProvider value)
        {
            return value switch
            {
                AgentKnowledgeProvider.Pinecone => "pinecone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentKnowledgeProvider? ToEnum(string value)
        {
            return value switch
            {
                "pinecone" => AgentKnowledgeProvider.Pinecone,
                _ => null,
            };
        }
    }
}