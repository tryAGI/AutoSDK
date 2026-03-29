//HintName: G.Models.BaseMessagesResultContentItemsOneOf4Name.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf4Name
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
    public static class BaseMessagesResultContentItemsOneOf4NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf4Name value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf4Name.BashCodeExecution => "bash_code_execution",
                BaseMessagesResultContentItemsOneOf4Name.CodeExecution => "code_execution",
                BaseMessagesResultContentItemsOneOf4Name.TextEditorCodeExecution => "text_editor_code_execution",
                BaseMessagesResultContentItemsOneOf4Name.ToolSearchToolBm25 => "tool_search_tool_bm25",
                BaseMessagesResultContentItemsOneOf4Name.ToolSearchToolRegex => "tool_search_tool_regex",
                BaseMessagesResultContentItemsOneOf4Name.WebFetch => "web_fetch",
                BaseMessagesResultContentItemsOneOf4Name.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf4Name? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution" => BaseMessagesResultContentItemsOneOf4Name.BashCodeExecution,
                "code_execution" => BaseMessagesResultContentItemsOneOf4Name.CodeExecution,
                "text_editor_code_execution" => BaseMessagesResultContentItemsOneOf4Name.TextEditorCodeExecution,
                "tool_search_tool_bm25" => BaseMessagesResultContentItemsOneOf4Name.ToolSearchToolBm25,
                "tool_search_tool_regex" => BaseMessagesResultContentItemsOneOf4Name.ToolSearchToolRegex,
                "web_fetch" => BaseMessagesResultContentItemsOneOf4Name.WebFetch,
                "web_search" => BaseMessagesResultContentItemsOneOf4Name.WebSearch,
                _ => null,
            };
        }
    }
}