//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentAgentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplatesGetTemplateSnapshotResponseAgentAgentType
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
    public static class TemplatesGetTemplateSnapshotResponseAgentAgentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesGetTemplateSnapshotResponseAgentAgentType value)
        {
            return value switch
            {
                TemplatesGetTemplateSnapshotResponseAgentAgentType.LettaV1Agent => "letta_v1_agent",
                TemplatesGetTemplateSnapshotResponseAgentAgentType.MemgptAgent => "memgpt_agent",
                TemplatesGetTemplateSnapshotResponseAgentAgentType.MemgptV2Agent => "memgpt_v2_agent",
                TemplatesGetTemplateSnapshotResponseAgentAgentType.ReactAgent => "react_agent",
                TemplatesGetTemplateSnapshotResponseAgentAgentType.SleeptimeAgent => "sleeptime_agent",
                TemplatesGetTemplateSnapshotResponseAgentAgentType.SplitThreadAgent => "split_thread_agent",
                TemplatesGetTemplateSnapshotResponseAgentAgentType.VoiceConvoAgent => "voice_convo_agent",
                TemplatesGetTemplateSnapshotResponseAgentAgentType.VoiceSleeptimeAgent => "voice_sleeptime_agent",
                TemplatesGetTemplateSnapshotResponseAgentAgentType.WorkflowAgent => "workflow_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesGetTemplateSnapshotResponseAgentAgentType? ToEnum(string value)
        {
            return value switch
            {
                "letta_v1_agent" => TemplatesGetTemplateSnapshotResponseAgentAgentType.LettaV1Agent,
                "memgpt_agent" => TemplatesGetTemplateSnapshotResponseAgentAgentType.MemgptAgent,
                "memgpt_v2_agent" => TemplatesGetTemplateSnapshotResponseAgentAgentType.MemgptV2Agent,
                "react_agent" => TemplatesGetTemplateSnapshotResponseAgentAgentType.ReactAgent,
                "sleeptime_agent" => TemplatesGetTemplateSnapshotResponseAgentAgentType.SleeptimeAgent,
                "split_thread_agent" => TemplatesGetTemplateSnapshotResponseAgentAgentType.SplitThreadAgent,
                "voice_convo_agent" => TemplatesGetTemplateSnapshotResponseAgentAgentType.VoiceConvoAgent,
                "voice_sleeptime_agent" => TemplatesGetTemplateSnapshotResponseAgentAgentType.VoiceSleeptimeAgent,
                "workflow_agent" => TemplatesGetTemplateSnapshotResponseAgentAgentType.WorkflowAgent,
                _ => null,
            };
        }
    }
}