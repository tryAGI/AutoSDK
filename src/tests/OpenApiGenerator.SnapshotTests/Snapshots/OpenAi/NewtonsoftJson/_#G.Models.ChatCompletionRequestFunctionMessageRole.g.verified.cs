//HintName: G.Models.ChatCompletionRequestFunctionMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the messages author, in this case `function`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRequestFunctionMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    public static class ChatCompletionRequestFunctionMessageRoleExtensions
    {
        public static string ToValueString(this ChatCompletionRequestFunctionMessageRole value)
        {
            return value switch
            {
                ChatCompletionRequestFunctionMessageRole.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestFunctionMessageRole ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionRequestFunctionMessageRole.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionRequestFunctionMessageRole ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionRequestFunctionMessageRole.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}