//HintName: G.Models.ToolExecutionMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolExecutionMode
    {
        /// <summary>
        /// 
        /// </summary>
        Immediate,
        /// <summary>
        /// 
        /// </summary>
        PostToolSpeech,
        /// <summary>
        /// 
        /// </summary>
        Async,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolExecutionMode value)
        {
            return value switch
            {
                ToolExecutionMode.Immediate => "immediate",
                ToolExecutionMode.PostToolSpeech => "post_tool_speech",
                ToolExecutionMode.Async => "async",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "immediate" => ToolExecutionMode.Immediate,
                "post_tool_speech" => ToolExecutionMode.PostToolSpeech,
                "async" => ToolExecutionMode.Async,
                _ => null,
            };
        }
    }
}