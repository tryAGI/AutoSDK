//HintName: G.Models.GetTestCaseDefinitionResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTestCaseDefinitionResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTestCaseDefinitionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTestCaseDefinitionResponseStatus value)
        {
            return value switch
            {
                GetTestCaseDefinitionResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTestCaseDefinitionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetTestCaseDefinitionResponseStatus.Error,
                _ => null,
            };
        }
    }
}