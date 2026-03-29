//HintName: G.Models.CreateResponseVariant1KnowledgeProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the knowledge base
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateResponseVariant1KnowledgeProvider
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
    public static class CreateResponseVariant1KnowledgeProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1KnowledgeProvider value)
        {
            return value switch
            {
                CreateResponseVariant1KnowledgeProvider.Pinecone => "pinecone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1KnowledgeProvider? ToEnum(string value)
        {
            return value switch
            {
                "pinecone" => CreateResponseVariant1KnowledgeProvider.Pinecone,
                _ => null,
            };
        }
    }
}