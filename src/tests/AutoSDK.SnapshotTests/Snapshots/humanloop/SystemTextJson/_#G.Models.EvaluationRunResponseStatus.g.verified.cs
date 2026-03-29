//HintName: G.Models.EvaluationRunResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvaluationRunResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRunResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRunResponseStatus value)
        {
            return value switch
            {
                EvaluationRunResponseStatus.Cancelled => "cancelled",
                EvaluationRunResponseStatus.Completed => "completed",
                EvaluationRunResponseStatus.Failed => "failed",
                EvaluationRunResponseStatus.Pending => "pending",
                EvaluationRunResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRunResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => EvaluationRunResponseStatus.Cancelled,
                "completed" => EvaluationRunResponseStatus.Completed,
                "failed" => EvaluationRunResponseStatus.Failed,
                "pending" => EvaluationRunResponseStatus.Pending,
                "running" => EvaluationRunResponseStatus.Running,
                _ => null,
            };
        }
    }
}