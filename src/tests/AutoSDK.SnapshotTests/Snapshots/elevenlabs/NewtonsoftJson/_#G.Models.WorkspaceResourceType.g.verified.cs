//HintName: G.Models.WorkspaceResourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Resource types that can be shared in the workspace. The name always need to match the collection names
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkspaceResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice")]
        Voice,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice_collection")]
        VoiceCollection,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pronunciation_dictionary")]
        PronunciationDictionary,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dubbing")]
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_agents")]
        ConvaiAgents,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_knowledge_base_documents")]
        ConvaiKnowledgeBaseDocuments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_tools")]
        ConvaiTools,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_settings")]
        ConvaiSettings,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_secrets")]
        ConvaiSecrets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="music_latent")]
        MusicLatent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_phone_numbers")]
        ConvaiPhoneNumbers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_mcp_servers")]
        ConvaiMcpServers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="convai_batch_calls")]
        ConvaiBatchCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceResourceType value)
        {
            return value switch
            {
                WorkspaceResourceType.Voice => "voice",
                WorkspaceResourceType.VoiceCollection => "voice_collection",
                WorkspaceResourceType.PronunciationDictionary => "pronunciation_dictionary",
                WorkspaceResourceType.Dubbing => "dubbing",
                WorkspaceResourceType.Project => "project",
                WorkspaceResourceType.ConvaiAgents => "convai_agents",
                WorkspaceResourceType.ConvaiKnowledgeBaseDocuments => "convai_knowledge_base_documents",
                WorkspaceResourceType.ConvaiTools => "convai_tools",
                WorkspaceResourceType.ConvaiSettings => "convai_settings",
                WorkspaceResourceType.ConvaiSecrets => "convai_secrets",
                WorkspaceResourceType.MusicLatent => "music_latent",
                WorkspaceResourceType.ConvaiPhoneNumbers => "convai_phone_numbers",
                WorkspaceResourceType.ConvaiMcpServers => "convai_mcp_servers",
                WorkspaceResourceType.ConvaiBatchCalls => "convai_batch_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceResourceType? ToEnum(string value)
        {
            return value switch
            {
                "voice" => WorkspaceResourceType.Voice,
                "voice_collection" => WorkspaceResourceType.VoiceCollection,
                "pronunciation_dictionary" => WorkspaceResourceType.PronunciationDictionary,
                "dubbing" => WorkspaceResourceType.Dubbing,
                "project" => WorkspaceResourceType.Project,
                "convai_agents" => WorkspaceResourceType.ConvaiAgents,
                "convai_knowledge_base_documents" => WorkspaceResourceType.ConvaiKnowledgeBaseDocuments,
                "convai_tools" => WorkspaceResourceType.ConvaiTools,
                "convai_settings" => WorkspaceResourceType.ConvaiSettings,
                "convai_secrets" => WorkspaceResourceType.ConvaiSecrets,
                "music_latent" => WorkspaceResourceType.MusicLatent,
                "convai_phone_numbers" => WorkspaceResourceType.ConvaiPhoneNumbers,
                "convai_mcp_servers" => WorkspaceResourceType.ConvaiMcpServers,
                "convai_batch_calls" => WorkspaceResourceType.ConvaiBatchCalls,
                _ => null,
            };
        }
    }
}