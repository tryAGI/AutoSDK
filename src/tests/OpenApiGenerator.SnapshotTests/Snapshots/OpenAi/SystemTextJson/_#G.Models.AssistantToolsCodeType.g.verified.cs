//HintName: G.Models.AssistantToolsCodeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool being defined: `code_interpreter`
    /// </summary>
    public enum AssistantToolsCodeType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantToolsCodeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantToolsCodeType value)
        {
            return value switch
            {
                AssistantToolsCodeType.CodeInterpreter => "code_interpreter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantToolsCodeType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => AssistantToolsCodeType.CodeInterpreter,
                _ => null,
            };
        }
    }
}