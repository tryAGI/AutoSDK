//HintName: G.Models.RunStepObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of run step, which can be either `message_creation` or `tool_calls`.
    /// </summary>
    public abstract class RunStepObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        public const string MessageCreation = "message_creation";
        /// <summary>
        /// 
        /// </summary>
        public const string ToolCalls = "tool_calls";
    }
}