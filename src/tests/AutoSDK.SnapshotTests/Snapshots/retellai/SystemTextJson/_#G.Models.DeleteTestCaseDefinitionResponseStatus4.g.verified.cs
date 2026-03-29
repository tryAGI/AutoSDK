//HintName: G.Models.DeleteTestCaseDefinitionResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteTestCaseDefinitionResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteTestCaseDefinitionResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteTestCaseDefinitionResponseStatus4 value)
        {
            return value switch
            {
                DeleteTestCaseDefinitionResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteTestCaseDefinitionResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteTestCaseDefinitionResponseStatus4.Error,
                _ => null,
            };
        }
    }
}