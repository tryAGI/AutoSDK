//HintName: G.Models.ChatCompletionMessageListObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of this object. It is always set to "list".<br/>
    /// Default Value: list
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionMessageListObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageListObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageListObject value)
        {
            return value switch
            {
                ChatCompletionMessageListObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageListObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ChatCompletionMessageListObject.List,
                _ => null,
            };
        }
    }
}