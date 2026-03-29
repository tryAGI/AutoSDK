//HintName: G.Models.ListTestCaseDefinitionsV2ResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTestCaseDefinitionsV2ResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTestCaseDefinitionsV2ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTestCaseDefinitionsV2ResponseStatus value)
        {
            return value switch
            {
                ListTestCaseDefinitionsV2ResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTestCaseDefinitionsV2ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListTestCaseDefinitionsV2ResponseStatus.Error,
                _ => null,
            };
        }
    }
}