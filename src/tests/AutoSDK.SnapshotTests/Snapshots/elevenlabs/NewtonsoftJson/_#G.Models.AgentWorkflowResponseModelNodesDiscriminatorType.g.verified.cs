//HintName: G.Models.AgentWorkflowResponseModelNodesDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentWorkflowResponseModelNodesDiscriminatorType
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
    public static class AgentWorkflowResponseModelNodesDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentWorkflowResponseModelNodesDiscriminatorType value)
        {
            return value switch
            {
                AgentWorkflowResponseModelNodesDiscriminatorType.End => "end",
                AgentWorkflowResponseModelNodesDiscriminatorType.OverrideAgent => "override_agent",
                AgentWorkflowResponseModelNodesDiscriminatorType.PhoneNumber => "phone_number",
                AgentWorkflowResponseModelNodesDiscriminatorType.StandaloneAgent => "standalone_agent",
                AgentWorkflowResponseModelNodesDiscriminatorType.Start => "start",
                AgentWorkflowResponseModelNodesDiscriminatorType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentWorkflowResponseModelNodesDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "end" => AgentWorkflowResponseModelNodesDiscriminatorType.End,
                "override_agent" => AgentWorkflowResponseModelNodesDiscriminatorType.OverrideAgent,
                "phone_number" => AgentWorkflowResponseModelNodesDiscriminatorType.PhoneNumber,
                "standalone_agent" => AgentWorkflowResponseModelNodesDiscriminatorType.StandaloneAgent,
                "start" => AgentWorkflowResponseModelNodesDiscriminatorType.Start,
                "tool" => AgentWorkflowResponseModelNodesDiscriminatorType.Tool,
                _ => null,
            };
        }
    }
}