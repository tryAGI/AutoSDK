//HintName: G.Models.ListTestRunsResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTestRunsResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTestRunsResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTestRunsResponseStatus4 value)
        {
            return value switch
            {
                ListTestRunsResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTestRunsResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListTestRunsResponseStatus4.Error,
                _ => null,
            };
        }
    }
}