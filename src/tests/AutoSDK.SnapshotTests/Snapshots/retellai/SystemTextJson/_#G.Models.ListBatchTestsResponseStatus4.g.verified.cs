//HintName: G.Models.ListBatchTestsResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListBatchTestsResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBatchTestsResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchTestsResponseStatus4 value)
        {
            return value switch
            {
                ListBatchTestsResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchTestsResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListBatchTestsResponseStatus4.Error,
                _ => null,
            };
        }
    }
}