//HintName: G.Models.CreateTrieveKnowledgeBaseDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This knowledge base is provided by Trieve.<br/>
    /// To learn more about Trieve, visit https://trieve.ai.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTrieveKnowledgeBaseDTOProvider
    {
        /// <summary>
        /// //trieve.ai.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trieve")]
        Trieve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTrieveKnowledgeBaseDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTrieveKnowledgeBaseDTOProvider value)
        {
            return value switch
            {
                CreateTrieveKnowledgeBaseDTOProvider.Trieve => "trieve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTrieveKnowledgeBaseDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "trieve" => CreateTrieveKnowledgeBaseDTOProvider.Trieve,
                _ => null,
            };
        }
    }
}