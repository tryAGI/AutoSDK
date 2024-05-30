//HintName: G.Models.AssistantsNamedToolChoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool. If type is `function`, the function name must be set
    /// </summary>
    public enum AssistantsNamedToolChoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
    }

    public static class AssistantsNamedToolChoiceTypeExtensions
    {
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
        public static AssistantsNamedToolChoiceType ToEnum(int value)
        {
            return value switch
            {
                0 => AssistantsNamedToolChoiceType.Function,
                1 => AssistantsNamedToolChoiceType.CodeInterpreter,
                2 => AssistantsNamedToolChoiceType.FileSearch,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}