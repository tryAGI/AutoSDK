//HintName: G.Models.PipelineDataSourceStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineDataSourceStatus
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
    public static class PipelineDataSourceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineDataSourceStatus value)
        {
            return value switch
            {
                PipelineDataSourceStatus.Cancelled => "CANCELLED",
                PipelineDataSourceStatus.Error => "ERROR",
                PipelineDataSourceStatus.InProgress => "IN_PROGRESS",
                PipelineDataSourceStatus.NotStarted => "NOT_STARTED",
                PipelineDataSourceStatus.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineDataSourceStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => PipelineDataSourceStatus.Cancelled,
                "ERROR" => PipelineDataSourceStatus.Error,
                "IN_PROGRESS" => PipelineDataSourceStatus.InProgress,
                "NOT_STARTED" => PipelineDataSourceStatus.NotStarted,
                "SUCCESS" => PipelineDataSourceStatus.Success,
                _ => null,
            };
        }
    }
}