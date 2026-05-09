//HintName: G.Models.CodeInterpreterToolOutputDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeInterpreterToolOutputDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Files,
        /// <summary>
        /// 
        /// </summary>
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterToolOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterToolOutputDiscriminatorType value)
        {
            return value switch
            {
                CodeInterpreterToolOutputDiscriminatorType.Files => "files",
                CodeInterpreterToolOutputDiscriminatorType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterToolOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "files" => CodeInterpreterToolOutputDiscriminatorType.Files,
                "logs" => CodeInterpreterToolOutputDiscriminatorType.Logs,
                _ => null,
            };
        }
    }
}