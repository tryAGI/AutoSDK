//HintName: G.Models.MessageObjectAttachmentToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageObjectAttachmentToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageObjectAttachmentToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageObjectAttachmentToolDiscriminatorType value)
        {
            return value switch
            {
                MessageObjectAttachmentToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                MessageObjectAttachmentToolDiscriminatorType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageObjectAttachmentToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => MessageObjectAttachmentToolDiscriminatorType.CodeInterpreter,
                "file_search" => MessageObjectAttachmentToolDiscriminatorType.FileSearch,
                _ => null,
            };
        }
    }
}