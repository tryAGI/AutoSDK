//HintName: G.Models.EvaluationResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvaluationResponseStatus
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
    public static class EvaluationResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationResponseStatus value)
        {
            return value switch
            {
                EvaluationResponseStatus.Cancelled => "cancelled",
                EvaluationResponseStatus.Completed => "completed",
                EvaluationResponseStatus.Failed => "failed",
                EvaluationResponseStatus.Pending => "pending",
                EvaluationResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => EvaluationResponseStatus.Cancelled,
                "completed" => EvaluationResponseStatus.Completed,
                "failed" => EvaluationResponseStatus.Failed,
                "pending" => EvaluationResponseStatus.Pending,
                "running" => EvaluationResponseStatus.Running,
                _ => null,
            };
        }
    }
}