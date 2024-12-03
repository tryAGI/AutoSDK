//HintName: G.Models.CreateMessageRequestAttachmentToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateMessageRequestAttachmentToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_interpreter")]
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_search")]
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