//HintName: G.Models.GetEvalRunsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEvalRunsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEvalRunsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvalRunsStatus value)
        {
            return value switch
            {
                GetEvalRunsStatus.Canceled => "canceled",
                GetEvalRunsStatus.Completed => "completed",
                GetEvalRunsStatus.Failed => "failed",
                GetEvalRunsStatus.InProgress => "in_progress",
                GetEvalRunsStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvalRunsStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetEvalRunsStatus.Canceled,
                "completed" => GetEvalRunsStatus.Completed,
                "failed" => GetEvalRunsStatus.Failed,
                "in_progress" => GetEvalRunsStatus.InProgress,
                "queued" => GetEvalRunsStatus.Queued,
                _ => null,
            };
        }
    }
}