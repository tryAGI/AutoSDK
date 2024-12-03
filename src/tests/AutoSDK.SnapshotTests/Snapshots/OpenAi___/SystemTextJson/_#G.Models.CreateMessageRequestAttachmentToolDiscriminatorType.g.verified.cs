//HintName: G.Models.CreateMessageRequestAttachmentToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateMessageRequestAttachmentToolDiscriminatorType
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
    public static class CreateMessageRequestAttachmentToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMessageRequestAttachmentToolDiscriminatorType value)
        {
            return value switch
            {
                CreateMessageRequestAttachmentToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                CreateMessageRequestAttachmentToolDiscriminatorType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMessageRequestAttachmentToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => CreateMessageRequestAttachmentToolDiscriminatorType.CodeInterpreter,
                "file_search" => CreateMessageRequestAttachmentToolDiscriminatorType.FileSearch,
                _ => null,
            };
        }
    }
}