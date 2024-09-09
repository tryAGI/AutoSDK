//HintName: G.Models.ChatCompletionChunkChoiceDeltaRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionChunkChoiceDeltaRole
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
    public static class ChatCompletionChunkChoiceDeltaRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionChunkChoiceDeltaRole value)
        {
            return value switch
            {
                ChatCompletionChunkChoiceDeltaRole.System => "system",
                ChatCompletionChunkChoiceDeltaRole.User => "user",
                ChatCompletionChunkChoiceDeltaRole.Assistant => "assistant",
                ChatCompletionChunkChoiceDeltaRole.Function => "function",
                ChatCompletionChunkChoiceDeltaRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionChunkChoiceDeltaRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionChunkChoiceDeltaRole.System,
                "user" => ChatCompletionChunkChoiceDeltaRole.User,
                "assistant" => ChatCompletionChunkChoiceDeltaRole.Assistant,
                "function" => ChatCompletionChunkChoiceDeltaRole.Function,
                "tool" => ChatCompletionChunkChoiceDeltaRole.Tool,
                _ => null,
            };
        }
    }
}