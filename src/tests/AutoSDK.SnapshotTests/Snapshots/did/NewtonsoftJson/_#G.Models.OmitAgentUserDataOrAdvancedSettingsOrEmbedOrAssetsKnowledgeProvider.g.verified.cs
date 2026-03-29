//HintName: G.Models.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the knowledge base
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider
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
    public static class OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider value)
        {
            return value switch
            {
                OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider.Pinecone => "pinecone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider? ToEnum(string value)
        {
            return value switch
            {
                "pinecone" => OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledgeProvider.Pinecone,
                _ => null,
            };
        }
    }
}