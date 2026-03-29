//HintName: G.Models.ListTestCaseDefinitionsResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTestCaseDefinitionsResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTestCaseDefinitionsResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTestCaseDefinitionsResponseStatus2 value)
        {
            return value switch
            {
                ListTestCaseDefinitionsResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTestCaseDefinitionsResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListTestCaseDefinitionsResponseStatus2.Error,
                _ => null,
            };
        }
    }
}