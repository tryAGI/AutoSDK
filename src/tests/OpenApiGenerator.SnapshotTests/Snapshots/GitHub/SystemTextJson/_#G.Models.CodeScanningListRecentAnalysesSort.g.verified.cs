//HintName: G.Models.CodeScanningListRecentAnalysesSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum CodeScanningListRecentAnalysesSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningListRecentAnalysesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningListRecentAnalysesSort value)
        {
            return value switch
            {
                CodeScanningListRecentAnalysesSort.Created => "created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningListRecentAnalysesSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => CodeScanningListRecentAnalysesSort.Created,
                _ => null,
            };
        }
    }
}