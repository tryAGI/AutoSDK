//HintName: G.Models.ChatCompletionResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionResponseObject
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
    public static class ChatCompletionResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionResponseObject value)
        {
            return value switch
            {
                ChatCompletionResponseObject.ChatCompletion => "chat.completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion" => ChatCompletionResponseObject.ChatCompletion,
                _ => null,
            };
        }
    }
}