//HintName: G.Models.TemplatedReminderHook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplatedReminderHook
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_message")]
        InputMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_output")]
        ToolOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatedReminderHookExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatedReminderHook value)
        {
            return value switch
            {
                TemplatedReminderHook.InputMessage => "input_message",
                TemplatedReminderHook.ToolOutput => "tool_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatedReminderHook? ToEnum(string value)
        {
            return value switch
            {
                "input_message" => TemplatedReminderHook.InputMessage,
                "tool_output" => TemplatedReminderHook.ToolOutput,
                _ => null,
            };
        }
    }
}