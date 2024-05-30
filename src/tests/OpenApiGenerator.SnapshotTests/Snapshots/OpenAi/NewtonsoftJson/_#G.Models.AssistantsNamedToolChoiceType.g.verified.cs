//HintName: G.Models.AssistantsNamedToolChoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool. If type is `function`, the function name must be set
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantsNamedToolChoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
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
    public static class AssistantsNamedToolChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantsNamedToolChoiceType value)
        {
            return value switch
            {
                AssistantsNamedToolChoiceType.Function => "function",
                AssistantsNamedToolChoiceType.CodeInterpreter => "code_interpreter",
                AssistantsNamedToolChoiceType.FileSearch => "file_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantsNamedToolChoiceType ToEnum(string value)
        {
            return value switch
            {
                "function" => AssistantsNamedToolChoiceType.Function,
                "code_interpreter" => AssistantsNamedToolChoiceType.CodeInterpreter,
                "file_search" => AssistantsNamedToolChoiceType.FileSearch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}