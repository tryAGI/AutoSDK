//HintName: G.Models.UpdateTestCaseDefinitionResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateTestCaseDefinitionResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTestCaseDefinitionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTestCaseDefinitionResponseStatus value)
        {
            return value switch
            {
                UpdateTestCaseDefinitionResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTestCaseDefinitionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateTestCaseDefinitionResponseStatus.Error,
                _ => null,
            };
        }
    }
}