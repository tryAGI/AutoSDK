//HintName: G.Models.ChatCompletionDeletedObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being deleted.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionDeletedObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat.completion.deleted")]
        ChatCompletionDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionDeletedObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionDeletedObject value)
        {
            return value switch
            {
                ChatCompletionDeletedObject.ChatCompletionDeleted => "chat.completion.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionDeletedObject? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion.deleted" => ChatCompletionDeletedObject.ChatCompletionDeleted,
                _ => null,
            };
        }
    }
}