//HintName: G.Models.DeleteTestCaseDefinitionResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteTestCaseDefinitionResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteTestCaseDefinitionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteTestCaseDefinitionResponseStatus value)
        {
            return value switch
            {
                DeleteTestCaseDefinitionResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteTestCaseDefinitionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteTestCaseDefinitionResponseStatus.Error,
                _ => null,
            };
        }
    }
}