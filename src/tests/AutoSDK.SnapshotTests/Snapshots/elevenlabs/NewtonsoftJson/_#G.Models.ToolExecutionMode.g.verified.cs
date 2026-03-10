//HintName: G.Models.ToolExecutionMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolExecutionMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="immediate")]
        Immediate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="post_tool_speech")]
        PostToolSpeech,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="async")]
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