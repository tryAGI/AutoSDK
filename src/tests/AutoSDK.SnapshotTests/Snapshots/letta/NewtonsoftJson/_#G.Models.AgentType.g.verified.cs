//HintName: G.Models.AgentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum to represent the type of agent.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="letta_v1_agent")]
        LettaV1Agent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="memgpt_agent")]
        MemgptAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="memgpt_v2_agent")]
        MemgptV2Agent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="react_agent")]
        ReactAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sleeptime_agent")]
        SleeptimeAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="split_thread_agent")]
        SplitThreadAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice_convo_agent")]
        VoiceConvoAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice_sleeptime_agent")]
        VoiceSleeptimeAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow_agent")]
        WorkflowAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentType value)
        {
            return value switch
            {
                AgentType.LettaV1Agent => "letta_v1_agent",
                AgentType.MemgptAgent => "memgpt_agent",
                AgentType.MemgptV2Agent => "memgpt_v2_agent",
                AgentType.ReactAgent => "react_agent",
                AgentType.SleeptimeAgent => "sleeptime_agent",
                AgentType.SplitThreadAgent => "split_thread_agent",
                AgentType.VoiceConvoAgent => "voice_convo_agent",
                AgentType.VoiceSleeptimeAgent => "voice_sleeptime_agent",
                AgentType.WorkflowAgent => "workflow_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentType? ToEnum(string value)
        {
            return value switch
            {
                "letta_v1_agent" => AgentType.LettaV1Agent,
                "memgpt_agent" => AgentType.MemgptAgent,
                "memgpt_v2_agent" => AgentType.MemgptV2Agent,
                "react_agent" => AgentType.ReactAgent,
                "sleeptime_agent" => AgentType.SleeptimeAgent,
                "split_thread_agent" => AgentType.SplitThreadAgent,
                "voice_convo_agent" => AgentType.VoiceConvoAgent,
                "voice_sleeptime_agent" => AgentType.VoiceSleeptimeAgent,
                "workflow_agent" => AgentType.WorkflowAgent,
                _ => null,
            };
        }
    }
}