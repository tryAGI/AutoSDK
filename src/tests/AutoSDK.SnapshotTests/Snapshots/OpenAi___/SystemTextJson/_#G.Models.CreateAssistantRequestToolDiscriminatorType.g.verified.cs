//HintName: G.Models.CreateAssistantRequestToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAssistantRequestToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssistantRequestToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantRequestToolDiscriminatorType value)
        {
            return value switch
            {
                CreateAssistantRequestToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                CreateAssistantRequestToolDiscriminatorType.FileSearch => "file_search",
                CreateAssistantRequestToolDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantRequestToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => CreateAssistantRequestToolDiscriminatorType.CodeInterpreter,
                "file_search" => CreateAssistantRequestToolDiscriminatorType.FileSearch,
                "function" => CreateAssistantRequestToolDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}