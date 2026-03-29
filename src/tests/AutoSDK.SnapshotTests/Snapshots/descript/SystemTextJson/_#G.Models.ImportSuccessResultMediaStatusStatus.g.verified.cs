//HintName: G.Models.ImportSuccessResultMediaStatusStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of this individual media import
    /// </summary>
    public enum ImportSuccessResultMediaStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportSuccessResultMediaStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportSuccessResultMediaStatusStatus value)
        {
            return value switch
            {
                ImportSuccessResultMediaStatusStatus.Failed => "failed",
                ImportSuccessResultMediaStatusStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportSuccessResultMediaStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ImportSuccessResultMediaStatusStatus.Failed,
                "success" => ImportSuccessResultMediaStatusStatus.Success,
                _ => null,
            };
        }
    }
}