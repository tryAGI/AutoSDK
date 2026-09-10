//HintName: G.Models.PipelineFileStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineFileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        NotStarted,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineFileStatus value)
        {
            return value switch
            {
                PipelineFileStatus.Cancelled => "CANCELLED",
                PipelineFileStatus.Error => "ERROR",
                PipelineFileStatus.InProgress => "IN_PROGRESS",
                PipelineFileStatus.NotStarted => "NOT_STARTED",
                PipelineFileStatus.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineFileStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => PipelineFileStatus.Cancelled,
                "ERROR" => PipelineFileStatus.Error,
                "IN_PROGRESS" => PipelineFileStatus.InProgress,
                "NOT_STARTED" => PipelineFileStatus.NotStarted,
                "SUCCESS" => PipelineFileStatus.Success,
                _ => null,
            };
        }
    }
}