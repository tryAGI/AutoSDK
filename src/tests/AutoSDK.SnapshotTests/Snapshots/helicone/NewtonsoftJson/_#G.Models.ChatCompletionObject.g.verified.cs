//HintName: G.Models.ChatCompletionObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `chat.completion`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat.completion")]
        ChatCompletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionObject value)
        {
            return value switch
            {
                ChatCompletionObject.ChatCompletion => "chat.completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionObject? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion" => ChatCompletionObject.ChatCompletion,
                _ => null,
            };
        }
    }
}