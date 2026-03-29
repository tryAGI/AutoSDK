//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minimal")]
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xhigh")]
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort value)
        {
            return value switch
            {
                TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.High => "high",
                TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.Low => "low",
                TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.Medium => "medium",
                TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.Minimal => "minimal",
                TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.None => "none",
                TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.High,
                "low" => TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.Low,
                "medium" => TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.Medium,
                "minimal" => TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.Minimal,
                "none" => TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.None,
                "xhigh" => TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}