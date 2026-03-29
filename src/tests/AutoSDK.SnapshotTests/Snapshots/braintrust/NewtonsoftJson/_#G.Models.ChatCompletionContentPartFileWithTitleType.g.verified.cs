//HintName: G.Models.ChatCompletionContentPartFileWithTitleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionContentPartFileWithTitleType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionContentPartFileWithTitleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionContentPartFileWithTitleType value)
        {
            return value switch
            {
                ChatCompletionContentPartFileWithTitleType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionContentPartFileWithTitleType? ToEnum(string value)
        {
            return value switch
            {
                "file" => ChatCompletionContentPartFileWithTitleType.File,
                _ => null,
            };
        }
    }
}