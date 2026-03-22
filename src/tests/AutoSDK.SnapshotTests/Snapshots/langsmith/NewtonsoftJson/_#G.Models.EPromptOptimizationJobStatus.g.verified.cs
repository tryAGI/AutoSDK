//HintName: G.Models.EPromptOptimizationJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EPromptOptimizationJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="running")]
        Running,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="successful")]
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