//HintName: G.Models.FinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Eos,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinishReason value)
        {
            return value switch
            {
                FinishReason.Eos => "eos",
                FinishReason.FunctionCall => "function_call",
                FinishReason.Length => "length",
                FinishReason.Stop => "stop",
                FinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinishReason? ToEnum(string value)
        {
            return value switch
            {
                "eos" => FinishReason.Eos,
                "function_call" => FinishReason.FunctionCall,
                "length" => FinishReason.Length,
                "stop" => FinishReason.Stop,
                "tool_calls" => FinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}