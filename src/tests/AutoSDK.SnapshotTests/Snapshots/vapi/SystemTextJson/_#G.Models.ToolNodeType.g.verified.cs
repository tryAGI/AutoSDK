//HintName: G.Models.ToolNodeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the Tool node. This can be used to call a tool in your workflow.<br/>
    /// The flow is:<br/>
    /// - Workflow starts the tool node<br/>
    /// - Model is called to extract parameters needed by the tool from the conversation history<br/>
    /// - Tool is called with the parameters<br/>
    /// - Server returns a response<br/>
    /// - Workflow continues with the response
    /// </summary>
    public enum ToolNodeType
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolNodeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolNodeType value)
        {
            return value switch
            {
                ToolNodeType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolNodeType? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ToolNodeType.Tool,
                _ => null,
            };
        }
    }
}