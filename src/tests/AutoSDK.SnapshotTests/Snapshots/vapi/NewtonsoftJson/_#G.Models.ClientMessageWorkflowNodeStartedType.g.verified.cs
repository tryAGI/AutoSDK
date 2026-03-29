//HintName: G.Models.ClientMessageWorkflowNodeStartedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "workflow.node.started" is sent when the active node changes.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientMessageWorkflowNodeStartedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow.node.started")]
        WorkflowNodeStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageWorkflowNodeStartedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageWorkflowNodeStartedType value)
        {
            return value switch
            {
                ClientMessageWorkflowNodeStartedType.WorkflowNodeStarted => "workflow.node.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageWorkflowNodeStartedType? ToEnum(string value)
        {
            return value switch
            {
                "workflow.node.started" => ClientMessageWorkflowNodeStartedType.WorkflowNodeStarted,
                _ => null,
            };
        }
    }
}