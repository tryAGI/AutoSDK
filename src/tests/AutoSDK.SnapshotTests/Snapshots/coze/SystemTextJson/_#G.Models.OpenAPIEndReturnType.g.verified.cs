//HintName: G.Models.OpenAPIEndReturnType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAPIEndReturnType
    {
        /// <summary>
        /// 
        /// </summary>
        ReturnVariables,
        /// <summary>
        /// 
        /// </summary>
        UseAnswerContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAPIEndReturnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAPIEndReturnType value)
        {
            return value switch
            {
                OpenAPIEndReturnType.ReturnVariables => "return_variables",
                OpenAPIEndReturnType.UseAnswerContent => "use_answer_content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAPIEndReturnType? ToEnum(string value)
        {
            return value switch
            {
                "return_variables" => OpenAPIEndReturnType.ReturnVariables,
                "use_answer_content" => OpenAPIEndReturnType.UseAnswerContent,
                _ => null,
            };
        }
    }
}