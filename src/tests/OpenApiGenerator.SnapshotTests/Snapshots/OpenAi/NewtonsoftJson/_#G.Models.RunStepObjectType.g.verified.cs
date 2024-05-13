//HintName: G.Models.RunStepObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of run step, which can be either `message_creation` or `tool_calls`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message_creation")]
        MessageCreation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_calls")]
        ToolCalls,
    }
}