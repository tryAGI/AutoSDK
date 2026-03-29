//HintName: G.Models.PipelineDataSourceStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineDataSourceStatus2
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
    public static class PipelineDataSourceStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineDataSourceStatus2 value)
        {
            return value switch
            {
                PipelineDataSourceStatus2.Cancelled => "CANCELLED",
                PipelineDataSourceStatus2.Error => "ERROR",
                PipelineDataSourceStatus2.InProgress => "IN_PROGRESS",
                PipelineDataSourceStatus2.NotStarted => "NOT_STARTED",
                PipelineDataSourceStatus2.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineDataSourceStatus2? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => PipelineDataSourceStatus2.Cancelled,
                "ERROR" => PipelineDataSourceStatus2.Error,
                "IN_PROGRESS" => PipelineDataSourceStatus2.InProgress,
                "NOT_STARTED" => PipelineDataSourceStatus2.NotStarted,
                "SUCCESS" => PipelineDataSourceStatus2.Success,
                _ => null,
            };
        }
    }
}