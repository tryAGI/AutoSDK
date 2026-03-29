//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf7Name.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesMessageParamContentOneOf1ItemsOneOf7Name
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bash_code_execution")]
        BashCodeExecution,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_execution")]
        CodeExecution,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_editor_code_execution")]
        TextEditorCodeExecution,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_search_tool_bm25")]
        ToolSearchToolBm25,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_search_tool_regex")]
        ToolSearchToolRegex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_fetch")]
        WebFetch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search")]
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf7NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf7Name value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf7Name.BashCodeExecution => "bash_code_execution",
                MessagesMessageParamContentOneOf1ItemsOneOf7Name.CodeExecution => "code_execution",
                MessagesMessageParamContentOneOf1ItemsOneOf7Name.TextEditorCodeExecution => "text_editor_code_execution",
                MessagesMessageParamContentOneOf1ItemsOneOf7Name.ToolSearchToolBm25 => "tool_search_tool_bm25",
                MessagesMessageParamContentOneOf1ItemsOneOf7Name.ToolSearchToolRegex => "tool_search_tool_regex",
                MessagesMessageParamContentOneOf1ItemsOneOf7Name.WebFetch => "web_fetch",
                MessagesMessageParamContentOneOf1ItemsOneOf7Name.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf7Name? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution" => MessagesMessageParamContentOneOf1ItemsOneOf7Name.BashCodeExecution,
                "code_execution" => MessagesMessageParamContentOneOf1ItemsOneOf7Name.CodeExecution,
                "text_editor_code_execution" => MessagesMessageParamContentOneOf1ItemsOneOf7Name.TextEditorCodeExecution,
                "tool_search_tool_bm25" => MessagesMessageParamContentOneOf1ItemsOneOf7Name.ToolSearchToolBm25,
                "tool_search_tool_regex" => MessagesMessageParamContentOneOf1ItemsOneOf7Name.ToolSearchToolRegex,
                "web_fetch" => MessagesMessageParamContentOneOf1ItemsOneOf7Name.WebFetch,
                "web_search" => MessagesMessageParamContentOneOf1ItemsOneOf7Name.WebSearch,
                _ => null,
            };
        }
    }
}