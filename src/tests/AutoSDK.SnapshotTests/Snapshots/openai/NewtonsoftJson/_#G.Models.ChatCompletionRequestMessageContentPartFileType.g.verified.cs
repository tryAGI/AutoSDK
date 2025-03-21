//HintName: G.Models.ChatCompletionRequestMessageContentPartFileType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the content part. Always `file`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRequestMessageContentPartFileType
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
    public static class ChatCompletionRequestMessageContentPartFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageContentPartFileType value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentPartFileType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageContentPartFileType? ToEnum(string value)
        {
            return value switch
            {
                "file" => ChatCompletionRequestMessageContentPartFileType.File,
                _ => null,
            };
        }
    }
}