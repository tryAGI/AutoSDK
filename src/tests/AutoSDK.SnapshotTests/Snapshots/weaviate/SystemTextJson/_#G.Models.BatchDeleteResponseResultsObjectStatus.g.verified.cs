//HintName: G.Models.BatchDeleteResponseResultsObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: SUCCESS
    /// </summary>
    public enum BatchDeleteResponseResultsObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Dryrun,
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
    public static class BatchDeleteResponseResultsObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchDeleteResponseResultsObjectStatus value)
        {
            return value switch
            {
                BatchDeleteResponseResultsObjectStatus.Dryrun => "DRYRUN",
                BatchDeleteResponseResultsObjectStatus.Failed => "FAILED",
                BatchDeleteResponseResultsObjectStatus.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchDeleteResponseResultsObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "DRYRUN" => BatchDeleteResponseResultsObjectStatus.Dryrun,
                "FAILED" => BatchDeleteResponseResultsObjectStatus.Failed,
                "SUCCESS" => BatchDeleteResponseResultsObjectStatus.Success,
                _ => null,
            };
        }
    }
}