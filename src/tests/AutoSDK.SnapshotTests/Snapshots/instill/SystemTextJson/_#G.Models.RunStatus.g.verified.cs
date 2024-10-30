//HintName: G.Models.RunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// RunStatus defines the status of a pipeline or model run.<br/>
    ///  - RUN_STATUS_PROCESSING: Run in progress.<br/>
    ///  - RUN_STATUS_COMPLETED: Run succeeded.<br/>
    ///  - RUN_STATUS_FAILED: Run failed.<br/>
    ///  - RUN_STATUS_QUEUED: Run is waiting to be executed.
    /// </summary>
    public enum RunStatus
    {
        /// <summary>
        /// Run in progress.
        /// </summary>
        PROCESSING,
        /// <summary>
        /// Run succeeded.
        /// </summary>
        COMPLETED,
        /// <summary>
        /// Run failed.
        /// </summary>
        FAILED,
        /// <summary>
        /// Run is waiting to be executed.
        /// </summary>
        QUEUED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStatus value)
        {
            return value switch
            {
                RunStatus.PROCESSING => "RUN_STATUS_PROCESSING",
                RunStatus.COMPLETED => "RUN_STATUS_COMPLETED",
                RunStatus.FAILED => "RUN_STATUS_FAILED",
                RunStatus.QUEUED => "RUN_STATUS_QUEUED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStatus? ToEnum(string value)
        {
            return value switch
            {
                "RUN_STATUS_PROCESSING" => RunStatus.PROCESSING,
                "RUN_STATUS_COMPLETED" => RunStatus.COMPLETED,
                "RUN_STATUS_FAILED" => RunStatus.FAILED,
                "RUN_STATUS_QUEUED" => RunStatus.QUEUED,
                _ => null,
            };
        }
    }
}