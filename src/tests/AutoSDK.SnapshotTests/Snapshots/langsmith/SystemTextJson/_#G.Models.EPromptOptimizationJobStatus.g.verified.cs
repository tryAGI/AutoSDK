//HintName: G.Models.EPromptOptimizationJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EPromptOptimizationJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Successful,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EPromptOptimizationJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EPromptOptimizationJobStatus value)
        {
            return value switch
            {
                EPromptOptimizationJobStatus.Created => "created",
                EPromptOptimizationJobStatus.Failed => "failed",
                EPromptOptimizationJobStatus.Running => "running",
                EPromptOptimizationJobStatus.Successful => "successful",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EPromptOptimizationJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => EPromptOptimizationJobStatus.Created,
                "failed" => EPromptOptimizationJobStatus.Failed,
                "running" => EPromptOptimizationJobStatus.Running,
                "successful" => EPromptOptimizationJobStatus.Successful,
                _ => null,
            };
        }
    }
}