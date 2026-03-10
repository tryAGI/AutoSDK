//HintName: G.Models.AgentWorkflowRequestModelNodesDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentWorkflowRequestModelNodesDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="end")]
        End,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="override_agent")]
        OverrideAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone_number")]
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standalone_agent")]
        StandaloneAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="start")]
        Start,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentWorkflowRequestModelNodesDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentWorkflowRequestModelNodesDiscriminatorType value)
        {
            return value switch
            {
                AgentWorkflowRequestModelNodesDiscriminatorType.End => "end",
                AgentWorkflowRequestModelNodesDiscriminatorType.OverrideAgent => "override_agent",
                AgentWorkflowRequestModelNodesDiscriminatorType.PhoneNumber => "phone_number",
                AgentWorkflowRequestModelNodesDiscriminatorType.StandaloneAgent => "standalone_agent",
                AgentWorkflowRequestModelNodesDiscriminatorType.Start => "start",
                AgentWorkflowRequestModelNodesDiscriminatorType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentWorkflowRequestModelNodesDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "end" => AgentWorkflowRequestModelNodesDiscriminatorType.End,
                "override_agent" => AgentWorkflowRequestModelNodesDiscriminatorType.OverrideAgent,
                "phone_number" => AgentWorkflowRequestModelNodesDiscriminatorType.PhoneNumber,
                "standalone_agent" => AgentWorkflowRequestModelNodesDiscriminatorType.StandaloneAgent,
                "start" => AgentWorkflowRequestModelNodesDiscriminatorType.Start,
                "tool" => AgentWorkflowRequestModelNodesDiscriminatorType.Tool,
                _ => null,
            };
        }
    }
}