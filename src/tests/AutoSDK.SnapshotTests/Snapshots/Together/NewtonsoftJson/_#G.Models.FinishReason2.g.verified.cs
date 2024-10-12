//HintName: G.Models.FinishReason2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FinishReason2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stop")]
        Stop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eos")]
        Eos,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="length")]
        Length,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_calls")]
        ToolCalls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call")]
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinishReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinishReason2 value)
        {
            return value switch
            {
                FinishReason2.Stop => "stop",
                FinishReason2.Eos => "eos",
                FinishReason2.Length => "length",
                FinishReason2.ToolCalls => "tool_calls",
                FinishReason2.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinishReason2? ToEnum(string value)
        {
            return value switch
            {
                "stop" => FinishReason2.Stop,
                "eos" => FinishReason2.Eos,
                "length" => FinishReason2.Length,
                "tool_calls" => FinishReason2.ToolCalls,
                "function_call" => FinishReason2.FunctionCall,
                _ => null,
            };
        }
    }
}