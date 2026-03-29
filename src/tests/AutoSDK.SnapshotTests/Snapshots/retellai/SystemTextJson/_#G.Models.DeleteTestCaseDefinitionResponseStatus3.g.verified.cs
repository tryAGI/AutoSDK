//HintName: G.Models.DeleteTestCaseDefinitionResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteTestCaseDefinitionResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteTestCaseDefinitionResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteTestCaseDefinitionResponseStatus3 value)
        {
            return value switch
            {
                DeleteTestCaseDefinitionResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteTestCaseDefinitionResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteTestCaseDefinitionResponseStatus3.Error,
                _ => null,
            };
        }
    }
}