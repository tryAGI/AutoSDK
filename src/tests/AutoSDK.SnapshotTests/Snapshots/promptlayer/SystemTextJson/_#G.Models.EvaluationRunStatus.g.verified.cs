//HintName: G.Models.EvaluationRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the batch run
    /// </summary>
    public enum EvaluationRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationRunStatus value)
        {
            return value switch
            {
                EvaluationRunStatus.Completed => "COMPLETED",
                EvaluationRunStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => EvaluationRunStatus.Completed,
                "RUNNING" => EvaluationRunStatus.Running,
                _ => null,
            };
        }
    }
}