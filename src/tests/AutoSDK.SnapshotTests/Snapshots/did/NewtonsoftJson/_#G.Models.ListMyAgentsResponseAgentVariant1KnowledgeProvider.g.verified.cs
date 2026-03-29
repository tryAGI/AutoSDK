//HintName: G.Models.ListMyAgentsResponseAgentVariant1KnowledgeProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the knowledge base
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListMyAgentsResponseAgentVariant1KnowledgeProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pinecone")]
        Pinecone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListMyAgentsResponseAgentVariant1KnowledgeProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1KnowledgeProvider value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1KnowledgeProvider.Pinecone => "pinecone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1KnowledgeProvider? ToEnum(string value)
        {
            return value switch
            {
                "pinecone" => ListMyAgentsResponseAgentVariant1KnowledgeProvider.Pinecone,
                _ => null,
            };
        }
    }
}