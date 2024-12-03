//HintName: G.Models.AssistantObjectToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantObjectToolDiscriminatorType
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
    public static class AssistantObjectToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantObjectToolDiscriminatorType value)
        {
            return value switch
            {
                AssistantObjectToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                AssistantObjectToolDiscriminatorType.FileSearch => "file_search",
                AssistantObjectToolDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantObjectToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => AssistantObjectToolDiscriminatorType.CodeInterpreter,
                "file_search" => AssistantObjectToolDiscriminatorType.FileSearch,
                "function" => AssistantObjectToolDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}