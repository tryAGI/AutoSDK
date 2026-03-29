//HintName: G.Models.ListBatchTestsV2ResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListBatchTestsV2ResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBatchTestsV2ResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchTestsV2ResponseStatus2 value)
        {
            return value switch
            {
                ListBatchTestsV2ResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchTestsV2ResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListBatchTestsV2ResponseStatus2.Error,
                _ => null,
            };
        }
    }
}