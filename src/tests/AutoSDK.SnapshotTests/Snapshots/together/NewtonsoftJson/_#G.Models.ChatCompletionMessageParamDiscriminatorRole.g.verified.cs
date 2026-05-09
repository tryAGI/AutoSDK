//HintName: G.Models.ChatCompletionMessageParamDiscriminatorRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionMessageParamDiscriminatorRole
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageParamDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageParamDiscriminatorRole value)
        {
            return value switch
            {
                ChatCompletionMessageParamDiscriminatorRole.Assistant => "assistant",
                ChatCompletionMessageParamDiscriminatorRole.Function => "function",
                ChatCompletionMessageParamDiscriminatorRole.System => "system",
                ChatCompletionMessageParamDiscriminatorRole.Tool => "tool",
                ChatCompletionMessageParamDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageParamDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionMessageParamDiscriminatorRole.Assistant,
                "function" => ChatCompletionMessageParamDiscriminatorRole.Function,
                "system" => ChatCompletionMessageParamDiscriminatorRole.System,
                "tool" => ChatCompletionMessageParamDiscriminatorRole.Tool,
                "user" => ChatCompletionMessageParamDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}