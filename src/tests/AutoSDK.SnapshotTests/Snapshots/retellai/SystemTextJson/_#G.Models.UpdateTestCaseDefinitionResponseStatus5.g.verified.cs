//HintName: G.Models.UpdateTestCaseDefinitionResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateTestCaseDefinitionResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTestCaseDefinitionResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTestCaseDefinitionResponseStatus5 value)
        {
            return value switch
            {
                UpdateTestCaseDefinitionResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTestCaseDefinitionResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateTestCaseDefinitionResponseStatus5.Error,
                _ => null,
            };
        }
    }
}