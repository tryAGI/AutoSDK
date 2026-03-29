//HintName: G.Models.OpenMessageApiType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenMessageApiType
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
    public static class OpenMessageApiTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenMessageApiType value)
        {
            return value switch
            {
                OpenMessageApiType.Answer => "answer",
                OpenMessageApiType.FunctionCall => "function_call",
                OpenMessageApiType.Question => "question",
                OpenMessageApiType.ToolOutput => "tool_output",
                OpenMessageApiType.ToolResponse => "tool_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenMessageApiType? ToEnum(string value)
        {
            return value switch
            {
                "answer" => OpenMessageApiType.Answer,
                "function_call" => OpenMessageApiType.FunctionCall,
                "question" => OpenMessageApiType.Question,
                "tool_output" => OpenMessageApiType.ToolOutput,
                "tool_response" => OpenMessageApiType.ToolResponse,
                _ => null,
            };
        }
    }
}