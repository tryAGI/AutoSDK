//HintName: G.Models.CreateTestCaseDefinitionResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTestCaseDefinitionResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTestCaseDefinitionResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTestCaseDefinitionResponseStatus5 value)
        {
            return value switch
            {
                CreateTestCaseDefinitionResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTestCaseDefinitionResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateTestCaseDefinitionResponseStatus5.Error,
                _ => null,
            };
        }
    }
}