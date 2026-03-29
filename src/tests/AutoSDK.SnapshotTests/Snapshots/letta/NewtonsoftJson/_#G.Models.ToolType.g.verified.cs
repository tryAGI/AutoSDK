//HintName: G.Models.ToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom")]
        Custom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external_composio")]
        ExternalComposio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external_langchain")]
        ExternalLangchain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external_mcp")]
        ExternalMcp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="letta_builtin")]
        LettaBuiltin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="letta_core")]
        LettaCore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="letta_files_core")]
        LettaFilesCore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="letta_memory_core")]
        LettaMemoryCore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="letta_multi_agent_core")]
        LettaMultiAgentCore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="letta_sleeptime_core")]
        LettaSleeptimeCore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="letta_voice_sleeptime_core")]
        LettaVoiceSleeptimeCore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolType value)
        {
            return value switch
            {
                ToolType.Custom => "custom",
                ToolType.ExternalComposio => "external_composio",
                ToolType.ExternalLangchain => "external_langchain",
                ToolType.ExternalMcp => "external_mcp",
                ToolType.LettaBuiltin => "letta_builtin",
                ToolType.LettaCore => "letta_core",
                ToolType.LettaFilesCore => "letta_files_core",
                ToolType.LettaMemoryCore => "letta_memory_core",
                ToolType.LettaMultiAgentCore => "letta_multi_agent_core",
                ToolType.LettaSleeptimeCore => "letta_sleeptime_core",
                ToolType.LettaVoiceSleeptimeCore => "letta_voice_sleeptime_core",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ToolType.Custom,
                "external_composio" => ToolType.ExternalComposio,
                "external_langchain" => ToolType.ExternalLangchain,
                "external_mcp" => ToolType.ExternalMcp,
                "letta_builtin" => ToolType.LettaBuiltin,
                "letta_core" => ToolType.LettaCore,
                "letta_files_core" => ToolType.LettaFilesCore,
                "letta_memory_core" => ToolType.LettaMemoryCore,
                "letta_multi_agent_core" => ToolType.LettaMultiAgentCore,
                "letta_sleeptime_core" => ToolType.LettaSleeptimeCore,
                "letta_voice_sleeptime_core" => ToolType.LettaVoiceSleeptimeCore,
                _ => null,
            };
        }
    }
}