//HintName: G.Models.BaseMessagesResultContentItemsOneOf7Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf7Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_execution_tool_result")]
        CodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf7Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf7Type.CodeExecutionToolResult => "code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf7Type? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_tool_result" => BaseMessagesResultContentItemsOneOf7Type.CodeExecutionToolResult,
                _ => null,
            };
        }
    }
}