//HintName: G.Models.AssistantToolsCodeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool being defined: `code_interpreter`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantToolsCodeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_interpreter")]
        CodeInterpreter,
    }

    public static class AssistantToolsCodeTypeExtensions
    {
        public static string ToValueString(this AssistantToolsCodeType value)
        {
            return value switch
            {
                AssistantToolsCodeType.CodeInterpreter => "code_interpreter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AssistantToolsCodeType ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => AssistantToolsCodeType.CodeInterpreter,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AssistantToolsCodeType ToEnum(int value)
        {
            return value switch
            {
                0 => AssistantToolsCodeType.CodeInterpreter,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}