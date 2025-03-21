//HintName: G.Models.ChatCompletionListObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of this object. It is always set to "list".<br/>
    /// Default Value: list
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionListObject
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
    public static class ChatCompletionListObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionListObject value)
        {
            return value switch
            {
                ChatCompletionListObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionListObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ChatCompletionListObject.List,
                _ => null,
            };
        }
    }
}