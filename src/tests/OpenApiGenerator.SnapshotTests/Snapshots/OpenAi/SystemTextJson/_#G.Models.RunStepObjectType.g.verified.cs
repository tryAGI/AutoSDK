//HintName: G.Models.RunStepObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of run step, which can be either `message_creation` or `tool_calls`.
    /// </summary>
    public enum RunStepObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageCreation,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    public static class RunStepObjectTypeExtensions
    {
        public static string ToValueString(this RunStepObjectType value)
        {
            return value switch
            {
                RunStepObjectType.MessageCreation => "message_creation",
                RunStepObjectType.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepObjectType ToEnum(string value)
        {
            return value switch
            {
                "message_creation" => RunStepObjectType.MessageCreation,
                "tool_calls" => RunStepObjectType.ToolCalls,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepObjectType.MessageCreation,
                1 => RunStepObjectType.ToolCalls,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}