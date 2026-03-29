//HintName: G.Models.PipelineFileResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelineFileResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IN_PROGRESS")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NOT_STARTED")]
        NotStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineFileResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineFileResponseStatus2 value)
        {
            return value switch
            {
                PipelineFileResponseStatus2.Cancelled => "CANCELLED",
                PipelineFileResponseStatus2.Error => "ERROR",
                PipelineFileResponseStatus2.InProgress => "IN_PROGRESS",
                PipelineFileResponseStatus2.NotStarted => "NOT_STARTED",
                PipelineFileResponseStatus2.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineFileResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => PipelineFileResponseStatus2.Cancelled,
                "ERROR" => PipelineFileResponseStatus2.Error,
                "IN_PROGRESS" => PipelineFileResponseStatus2.InProgress,
                "NOT_STARTED" => PipelineFileResponseStatus2.NotStarted,
                "SUCCESS" => PipelineFileResponseStatus2.Success,
                _ => null,
            };
        }
    }
}