//HintName: G.Models.ChatCompletionChoiceDeltaRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionChoiceDeltaRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionChoiceDeltaRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionChoiceDeltaRole value)
        {
            return value switch
            {
                ChatCompletionChoiceDeltaRole.System => "system",
                ChatCompletionChoiceDeltaRole.User => "user",
                ChatCompletionChoiceDeltaRole.Assistant => "assistant",
                ChatCompletionChoiceDeltaRole.Function => "function",
                ChatCompletionChoiceDeltaRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionChoiceDeltaRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionChoiceDeltaRole.System,
                "user" => ChatCompletionChoiceDeltaRole.User,
                "assistant" => ChatCompletionChoiceDeltaRole.Assistant,
                "function" => ChatCompletionChoiceDeltaRole.Function,
                "tool" => ChatCompletionChoiceDeltaRole.Tool,
                _ => null,
            };
        }
    }
}