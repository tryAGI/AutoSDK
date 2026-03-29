//HintName: G.Models.EnterMessage2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// function_call, tool_output, knowledge, answer, follow_up, verbose, (普通请求可以不填)<br/>
    ///  用户输入时可用：function_call，tool_output<br/>
    ///  不支持用户输入使用：follow_up，knowledge，verbose，answer
    /// </summary>
    public enum EnterMessage2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Answer,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        Question,
        /// <summary>
        /// 
        /// </summary>
        ToolOutput,
        /// <summary>
        /// 
        /// </summary>
        ToolResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnterMessage2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterMessage2Type value)
        {
            return value switch
            {
                EnterMessage2Type.Answer => "answer",
                EnterMessage2Type.FunctionCall => "function_call",
                EnterMessage2Type.Question => "question",
                EnterMessage2Type.ToolOutput => "tool_output",
                EnterMessage2Type.ToolResponse => "tool_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterMessage2Type? ToEnum(string value)
        {
            return value switch
            {
                "answer" => EnterMessage2Type.Answer,
                "function_call" => EnterMessage2Type.FunctionCall,
                "question" => EnterMessage2Type.Question,
                "tool_output" => EnterMessage2Type.ToolOutput,
                "tool_response" => EnterMessage2Type.ToolResponse,
                _ => null,
            };
        }
    }
}