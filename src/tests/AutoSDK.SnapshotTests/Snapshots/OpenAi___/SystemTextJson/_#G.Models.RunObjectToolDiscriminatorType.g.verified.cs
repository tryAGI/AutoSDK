//HintName: G.Models.RunObjectToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunObjectToolDiscriminatorType
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
    public static class RunObjectToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunObjectToolDiscriminatorType value)
        {
            return value switch
            {
                RunObjectToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                RunObjectToolDiscriminatorType.FileSearch => "file_search",
                RunObjectToolDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunObjectToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => RunObjectToolDiscriminatorType.CodeInterpreter,
                "file_search" => RunObjectToolDiscriminatorType.FileSearch,
                "function" => RunObjectToolDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}