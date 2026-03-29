//HintName: G.Models.ChatCompletionToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool. `function`, `browser_search`, and `code_interpreter` are supported.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="browser_search")]
        BrowserSearch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_interpreter")]
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionToolType value)
        {
            return value switch
            {
                ChatCompletionToolType.BrowserSearch => "browser_search",
                ChatCompletionToolType.CodeInterpreter => "code_interpreter",
                ChatCompletionToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionToolType? ToEnum(string value)
        {
            return value switch
            {
                "browser_search" => ChatCompletionToolType.BrowserSearch,
                "code_interpreter" => ChatCompletionToolType.CodeInterpreter,
                "function" => ChatCompletionToolType.Function,
                _ => null,
            };
        }
    }
}