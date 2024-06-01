//HintName: G.Models.CodeScanningSarifsStatusProcessingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `pending` files have not yet been processed, while `complete` means results from the SARIF have been stored. `failed` files have either not been processed at all, or could only be partially processed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningSarifsStatusProcessingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="complete")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
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
                CodeScanningSarifsStatusProcessingStatus.Pending => "pending",
                CodeScanningSarifsStatusProcessingStatus.Complete => "complete",
                CodeScanningSarifsStatusProcessingStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningSarifsStatusProcessingStatus ToEnum(string value)
        {
            return value switch
            {
                "pending" => CodeScanningSarifsStatusProcessingStatus.Pending,
                "complete" => CodeScanningSarifsStatusProcessingStatus.Complete,
                "failed" => CodeScanningSarifsStatusProcessingStatus.Failed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}