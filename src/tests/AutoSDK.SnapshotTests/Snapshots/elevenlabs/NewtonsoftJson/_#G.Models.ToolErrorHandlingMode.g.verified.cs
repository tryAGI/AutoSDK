//HintName: G.Models.ToolErrorHandlingMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls how tool errors are processed before being shared with the agent.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolErrorHandlingMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hide")]
        Hide,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="passthrough")]
        Passthrough,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="summarized")]
        Summarized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolErrorHandlingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolErrorHandlingMode value)
        {
            return value switch
            {
                ToolErrorHandlingMode.Auto => "auto",
                ToolErrorHandlingMode.Hide => "hide",
                ToolErrorHandlingMode.Passthrough => "passthrough",
                ToolErrorHandlingMode.Summarized => "summarized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolErrorHandlingMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ToolErrorHandlingMode.Auto,
                "hide" => ToolErrorHandlingMode.Hide,
                "passthrough" => ToolErrorHandlingMode.Passthrough,
                "summarized" => ToolErrorHandlingMode.Summarized,
                _ => null,
            };
        }
    }
}