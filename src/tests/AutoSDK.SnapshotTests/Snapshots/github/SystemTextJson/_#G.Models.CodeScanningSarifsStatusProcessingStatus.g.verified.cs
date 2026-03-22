//HintName: G.Models.CodeScanningSarifsStatusProcessingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `pending` files have not yet been processed, while `complete` means results from the SARIF have been stored. `failed` files have either not been processed at all, or could only be partially processed.
    /// </summary>
    public enum CodeScanningSarifsStatusProcessingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningSarifsStatusProcessingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningSarifsStatusProcessingStatus value)
        {
            return value switch
            {
                CodeScanningSarifsStatusProcessingStatus.Complete => "complete",
                CodeScanningSarifsStatusProcessingStatus.Failed => "failed",
                CodeScanningSarifsStatusProcessingStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningSarifsStatusProcessingStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => CodeScanningSarifsStatusProcessingStatus.Complete,
                "failed" => CodeScanningSarifsStatusProcessingStatus.Failed,
                "pending" => CodeScanningSarifsStatusProcessingStatus.Pending,
                _ => null,
            };
        }
    }
}