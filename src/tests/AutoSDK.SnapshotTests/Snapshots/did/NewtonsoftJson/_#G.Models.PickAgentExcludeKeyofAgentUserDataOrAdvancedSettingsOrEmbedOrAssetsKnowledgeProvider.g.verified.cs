//HintName: G.Models.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the knowledge base
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider
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
    public static class PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider value)
        {
            return value switch
            {
                PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider.Pinecone => "pinecone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider? ToEnum(string value)
        {
            return value switch
            {
                "pinecone" => PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider.Pinecone,
                _ => null,
            };
        }
    }
}