//HintName: G.Models.CodeExecutionResultContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: code_execution_result
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeExecutionResultContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_execution_result")]
        CodeExecutionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeExecutionResultContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeExecutionResultContentType value)
        {
            return value switch
            {
                CodeExecutionResultContentType.CodeExecutionResult => "code_execution_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeExecutionResultContentType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_result" => CodeExecutionResultContentType.CodeExecutionResult,
                _ => null,
            };
        }
    }
}