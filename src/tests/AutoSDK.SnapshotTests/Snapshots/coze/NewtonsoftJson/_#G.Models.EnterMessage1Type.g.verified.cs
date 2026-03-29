//HintName: G.Models.EnterMessage1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EnterMessage1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="answer")]
        Answer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call")]
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="question")]
        Question,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_output")]
        ToolOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_response")]
        ToolResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnterMessage1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterMessage1Type value)
        {
            return value switch
            {
                EnterMessage1Type.Answer => "answer",
                EnterMessage1Type.FunctionCall => "function_call",
                EnterMessage1Type.Question => "question",
                EnterMessage1Type.ToolOutput => "tool_output",
                EnterMessage1Type.ToolResponse => "tool_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterMessage1Type? ToEnum(string value)
        {
            return value switch
            {
                "answer" => EnterMessage1Type.Answer,
                "function_call" => EnterMessage1Type.FunctionCall,
                "question" => EnterMessage1Type.Question,
                "tool_output" => EnterMessage1Type.ToolOutput,
                "tool_response" => EnterMessage1Type.ToolResponse,
                _ => null,
            };
        }
    }
}