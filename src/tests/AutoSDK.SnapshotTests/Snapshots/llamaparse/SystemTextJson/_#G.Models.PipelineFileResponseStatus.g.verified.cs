//HintName: G.Models.PipelineFileResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineFileResponseStatus
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
    public static class PipelineFileResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineFileResponseStatus value)
        {
            return value switch
            {
                PipelineFileResponseStatus.Cancelled => "CANCELLED",
                PipelineFileResponseStatus.Error => "ERROR",
                PipelineFileResponseStatus.InProgress => "IN_PROGRESS",
                PipelineFileResponseStatus.NotStarted => "NOT_STARTED",
                PipelineFileResponseStatus.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineFileResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => PipelineFileResponseStatus.Cancelled,
                "ERROR" => PipelineFileResponseStatus.Error,
                "IN_PROGRESS" => PipelineFileResponseStatus.InProgress,
                "NOT_STARTED" => PipelineFileResponseStatus.NotStarted,
                "SUCCESS" => PipelineFileResponseStatus.Success,
                _ => null,
            };
        }
    }
}